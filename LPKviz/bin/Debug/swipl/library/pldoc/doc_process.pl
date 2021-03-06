/*  $Id$

    Part of SWI-Prolog

    Author:        Jan Wielemaker
    E-mail:        J.Wielemaker@cs.vu.nl
    WWW:           http://www.swi-prolog.org
    Copyright (C): 2011, University of Amsterdam
			 VU University Amsterdam

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public
    License along with this library; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA

    As a special exception, if you link this library with other files,
    compiled with a Free Software compiler, to produce an executable, this
    library does not by itself cause the resulting executable to be covered
    by the GNU General Public License. This exception does not however
    invalidate any other reasons why the executable file might be covered by
    the GNU General Public License.
*/

:- module(pldoc_process,
	  [ doc_comment/4,		% ?Object, ?Pos, ?Summary, ?Comment
	    doc_file_has_comments/1,	% +File
	    is_structured_comment/2,	% +Comment, -Prefixes
	    process_comments/3,		% +Comments, +StartTermPos, +File
	    doc_file_name/3		% +Source, -Doc, +Options
	  ]).

:- dynamic   user:file_search_path/2.
:- multifile user:file_search_path/2.

user:file_search_path(pldoc, library(pldoc)).

:- load_files([ pldoc(doc_register),
		pldoc(doc_modes),
		pldoc(doc_wiki),
		library(debug),
		library(option),
		library(lists),
		library(operators),
		library(prolog_source)
	      ],
	      [ silent(true),
		if(not_loaded)
	      ]).

/** <module> Process source documentation
The pldoc module processes structured comments in Prolog source files into
well formatted HTML documents.

@author  Jan Wielemaker
@license GPL
*/

:- predicate_options(doc_file_name/3, 3,
		     [ format(oneof([html,tex]))
		     ]).

%%	prolog:predicate_summary(+PI, -Summary) is semidet.
%
%	Provide    predicate    summaries    to     the    XPCE    class
%	=prolog_predicate=, used by the IDE tools.

:- multifile
	prolog:predicate_summary/2.	% ?PI, -Summary


%%	is_structured_comment(+Comment:string,
%%			      -Prefixes:list(codes)) is semidet.
%
%	True if Comment is a structured comment that should use Prefixes
%	to extract the plain text using indented_lines/3.
%
%	@tbd	=|%% SWI begin|= and =|%% SICStus begin|= are used by chr.
%		We need a more general mechanism to block some comments.

is_structured_comment(_Pos-Comment, Prefixes) :- !,
	is_structured_comment(Comment, Prefixes).
is_structured_comment(Comment, Prefixes) :-
	is_list(Comment), !,
	phrase(structured_comment(Prefixes), Comment, _).
is_structured_comment(Comment, Prefixes) :-
	string_to_atom(Comment, CommentA),
	sub_atom(CommentA, 0, _, _, '%%'), !,
	sub_atom(CommentA, 2, 1, _, Space),
	char_type(Space, space),
	\+ blanks_to_nl(Comment),
	\+ sub_atom(CommentA, 2, _, _, ' SWI '),	% HACK
	\+ sub_atom(CommentA, 2, _, _, ' SICStus '),	% HACK
	\+ sub_atom(CommentA, 2, _, _, ' Mats '),	% HACK
	Prefixes = ["%"].
is_structured_comment(Comment, Prefixes) :-
	string_to_atom(Comment, CommentA),
	sub_atom(CommentA, 0, _, _, '/**'), !,
	sub_atom(CommentA, 3, 1, _, Space),
	char_type(Space, space),
	Prefixes = ["/**", " *"].

blanks_to_nl(Comment) :-
	string_to_atom(Comment, CommentA),
	sub_atom(CommentA, At, 1, _, Char),
	At >= 2,
	(   char_type(Char, end_of_line)
	->  !
	;   (   char_type(Char, space)
	    ;	Char == '%'
	    )
	->  fail
	;   !, fail
	).
blanks_to_nl(_).

%%	structured_comment(-Prefixes:list(codes)) is semidet.
%
%	Grammar rule version of the above.  Avoids the need for
%	conversion.

structured_comment(["%"]) -->
	"%%", space,
	\+ separator_line.
structured_comment(Prefixes) -->
	"/**", space,
	{ Prefixes = ["/**", " *"]
	}.

space -->
	[H],
	{ code_type(H, space) }.

%%	separator_line// is semidet.
%
%	Matches a line like %% SWI or %%%%%%%%%%%%%%%%%%%%%%%%%, etc.

separator_line -->
	string(S), "\n", !,
	{   maplist(blank_or_percent, S)
	;   contains(S, " SWI ")
	;   contains(S, " SICStus ")
	;   contains(S, " Mats ")
	}.

string([]) --> [].
string([H|T]) --> [H], string(T).

blank_or_percent(0'%) :- !.
blank_or_percent(C) :-
	code_type(C, space).

contains(Haystack, Needle) :-
	append(_, Start, Haystack),
	append(Needle, _, Start), !.


%%	doc_file_name(+Source:atom, -Doc:atom, +Options:list) is det.
%
%	Doc is the name of the file for documenting Source.
%
%	@param Source	Prolog source to be documented
%	@param Doc	the name of the file documenting Source.
%	@param Options	Option list:
%
%			* format(+Format)
%			Output format.  One of =html= or =tex=
%
%	@error	permission_error(overwrite, Source)

doc_file_name(Source, Doc, Options) :-
	option(format(Format), Options, html),
	file_name_extension(Base, _Ext, Source),
	file_name_extension(Base, Format, Doc),
	(   Source == Doc
	->  throw(error(permission_error(overwrite, Source), _))
	;   true
	).

%%	doc_file_has_comments(+Source:atom) is semidet.
%
%	True if we have loaded comments from Source.

doc_file_has_comments(Source) :-
	source_file_property(Source, module(M)),
	locally_defined(M:'$pldoc'/4),
	M:'$pldoc'(_, _, _, _).


%%	doc_comment(?Objects, -Pos,
%%		    -Summary:string, -Comment:string) is nondet.
%
%	True if Comment is the  comment   describing  object. Comment is
%	returned as a string object  containing   the  original from the
%	source-code.  Object is one of
%
%		* Name/Arity
%		Predicate indicator
%
%		* Name//Arity
%		DCG rule indicator.  Same as Name/Arity+2
%
%		* module(ModuleTitle)
%		Comment appearing in a module.
%
%	If Object is  unbound  and  multiple   objects  share  the  same
%	description, Object is unified with a   list  of terms described
%	above.
%
%	@param Summary	First sentence.  Normalised spacing.
%	@param Comment	Comment string from the source-code (untranslated)

doc_comment(Object, Pos, Summary, Comment) :-
	var(Object), !,
	locally_defined(M:'$pldoc'/4),
	M:'$pldoc'(Obj, Pos, Summary, Comment),
	qualify(M, Obj, Object0),
	(   locally_defined(M:'$pldoc_link'/2),
	    findall(L, M:'$pldoc_link'(L, Obj), Ls), Ls \== []
	->  maplist(qualify(M),	Ls, QLs),
	    Object = [Object0|QLs]
	;   Object = Object0
	).
doc_comment(M:Object, Pos, Summary, Comment) :- !,
	locally_defined(M:'$pldoc'/4),
	(   M:'$pldoc'(Object, Pos, Summary, Comment)
	;   locally_defined(M:'$pldoc_link'/2),
	    M:'$pldoc_link'(Object, Obj2),
	    M:'$pldoc'(Obj2, Pos, Summary, Comment)
	).
doc_comment(Name/Arity, Pos, Summary, Comment) :-
	system_module(M),
	doc_comment(M:Name/Arity, Pos, Summary, Comment).


locally_defined(M:Name/Arity) :-
	current_module(M),
	current_predicate(M:Name/Arity),
	functor(Head, Name, Arity),
	\+ predicate_property(M:Head, imported_from(_)).


qualify(M, H, H) :- system_module(M), !.
qualify(M, H, H) :- sub_atom(M, 0, _, _, $), !.
qualify(M, H, M:H).

system_module(user).
system_module(system).


%	Make the summary available to external tools on plugin basis.

prolog:predicate_summary(PI, Summary) :-
	doc_comment(PI, _, Summary, _).


		 /*******************************
		 *	CALL-BACK COLLECT	*
		 *******************************/

%%	process_comments(+Comments:list, +TermPos, +File) is det.
%
%	Processes comments returned by read_term/3 using the =comments=
%	option.  It creates clauses of the form
%
%		* '$mode'(Head, Det)
%		* '$pldoc'(Id, Pos, Summary, Comment)
%		* '$pldoc_link'(Id0, Id)
%
%	where Id is one of
%
%		* module(Title)
%		Generated from /** <module> Title */
%		* Name/Arity
%		Generated from Name(Arg, ...)
%		* Name//Arity
%		Generated from Name(Arg, ...)//
%
%	@param Comments is a list Pos-Comment returned by read_term/3
%	@param TermPos is the start-location of the actual term
%	@param File is the file that is being loaded.

process_comments([], _, _).
process_comments([Pos-Comment|T], TermPos, File) :-
	(   Pos @> TermPos		% comments inside term
	->  true
	;   process_comment(Pos, Comment, File),
	    process_comments(T, TermPos, File)
	).

process_comment(Pos, Comment, File) :-
	is_structured_comment(Comment, Prefixes), !,
	stream_position_data(line_count, Pos, Line),
	FilePos = File:Line,
	process_structured_comment(FilePos, Comment, Prefixes).
process_comment(_, _, _).

%%	process_structured_comment(+FilePos,
%%				   +Comment:string,
%%				   +Prefixed:list) is det.

process_structured_comment(FilePos, Comment, _) :- % already processed
	prolog_load_context(module, M),
	locally_defined(M:'$pldoc'/4),
	catch(M:'$pldoc'(_, FilePos, _, Comment), _, fail), !.
process_structured_comment(FilePos, Comment, Prefixes) :-
	string_to_list(Comment, CommentCodes),
	indented_lines(CommentCodes, Prefixes, Lines),
	(   section_comment_header(Lines, Header, RestLines)
	->  Header = \section(Type, Title),
	    Id =.. [Type,Title],
	    compile_clause('$pldoc'(Id, FilePos, Title, Comment), FilePos)
	;   prolog_load_context(module, Module),
	    process_modes(Lines, Module, FilePos, Modes, _, RestLines)
	->  store_modes(Modes, FilePos),
	    modes_to_predicate_indicators(Modes, AllPIs),
	    decl_module(AllPIs, M, [PI0|PIs]),
	    summary_from_lines(RestLines, Codes),
	    string_to_list(Summary, Codes),
	    compile_clause(M:'$pldoc'(PI0, FilePos, Summary, Comment),
			   FilePos),
	    forall(member(PI, PIs),
		   compile_clause(M:'$pldoc_link'(PI, PI0), FilePos))
	), !.
process_structured_comment(Location, Comment, _) :-
	print_message(warning,
		      pldoc(invalid_comment(Location, Comment))),
	fail.

decl_module([], M, []) :-
	(   var(M)
	->  prolog_load_context(module, M)
	;   true
	).
decl_module([H0|T0], M, [H|T]) :-
	(   H0 = M1:H
	->  M = M1
	;   H = H0
	),
	decl_module(T0, M, T).


		 /*******************************
		 *	     MESSAGES		*
		 *******************************/

:- multifile
	prolog:message//1.

prolog:message(pldoc(invalid_comment(File:Line, Comment))) -->
	[ '~w:~d: PlDoc: failed to process structured comment:~n~s~n'-
		[File, Line, Comment]
	].
