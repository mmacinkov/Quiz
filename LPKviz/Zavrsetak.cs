using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SbsSW.SwiPlCs;

namespace LPKviz
{
    public partial class Zavrsetak : Form
    {
        public Zavrsetak()
        {
            InitializeComponent();
        }

        private void btnPonovno_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForma = new Form1();
            PomocUNavigaciji.IdiNaFormu(this, pocetnaForma);
        }

        private void btnUvid_Click(object sender, EventArgs e)
        {
            Odgovori odgovori = new Odgovori();
            PomocUNavigaciji.IdiNaFormu(this, odgovori);
        }

        private void Zavrsetak_Load(object sender, EventArgs e)
        {
            int brojac = 0;
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"swipl");
            Environment.SetEnvironmentVariable("Path", @"swipl");
            Environment.SetEnvironmentVariable("Path", @"swipl\bin");
            string[] p = { "-q", "-f", @"kviz.pl" };
            if (!PlEngine.IsInitialized)
                PlEngine.Initialize(p);

            PlQuery prvoPitanje = new PlQuery("prvo(Odgovor)");
            foreach (PlQueryVariables variable in prvoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Prvo)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }

            PlQuery drugoPitanje = new PlQuery("drugo(Odgovor)");
            foreach (PlQueryVariables variable in drugoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Drugo)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }

            PlQuery trecePitanje = new PlQuery("trece(Odgovor)");
            foreach (PlQueryVariables variable in trecePitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Trece)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }

            PlQuery cetvrtoPitanje = new PlQuery("cetvrto(Odgovor)");
            foreach (PlQueryVariables variable in cetvrtoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Cetvrto)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }

            PlQuery petoPitanje = new PlQuery("peto(Odgovor)");
            foreach (PlQueryVariables variable in petoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Peto)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }

            PlQuery sestoPitanje = new PlQuery("sesto(Odgovor)");
            foreach (PlQueryVariables variable in sestoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Sesto)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }

            PlQuery sedmooPitanje = new PlQuery("sedmo(Odgovor)");
            foreach (PlQueryVariables variable in sedmooPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Sedmo)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }

            PlQuery osmoPitanje = new PlQuery("osmo(Odgovor)");
            foreach (PlQueryVariables variable in osmoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Osmo)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }

            PlQuery devetoPitanje = new PlQuery("deveto(Odgovor)");
            foreach (PlQueryVariables variable in devetoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Deveto)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }

            PlQuery desetoPitanje = new PlQuery("deseto(Odgovor)");
            foreach (PlQueryVariables variable in desetoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Deseto)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }

            PlQuery jedanaestoPitanje = new PlQuery("jedanaesto(Odgovor)");
            foreach (PlQueryVariables variable in jedanaestoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Jedanaesto)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }

            PlQuery dvanaestoPitanje = new PlQuery("dvanaesto(Odgovor)");
            foreach (PlQueryVariables variable in dvanaestoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Dvanaesto)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }

            PlQuery trinaestoPitanje = new PlQuery("trinaesto(Odgovor)");
            foreach (PlQueryVariables variable in trinaestoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Trinaesto)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }

            PlQuery cetrnaestoPitanje = new PlQuery("cetrnaesto(Odgovor)");
            foreach (PlQueryVariables variable in cetrnaestoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Cetrnaesto)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }

            PlQuery petnaestoPitanje = new PlQuery("petnaesto(Odgovor)");
            foreach (PlQueryVariables variable in petnaestoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Petnaesto)
                {
                    brojac++;
                }
                lblBodovi.Text = brojac.ToString();
            }
        }
    }
}
