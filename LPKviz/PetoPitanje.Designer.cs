namespace LPKviz
{
    partial class PetoPitanje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetoPitanje));
            this.cbPanicar = new System.Windows.Forms.CheckBox();
            this.cbBotanicar = new System.Windows.Forms.CheckBox();
            this.cbHigijenicar = new System.Windows.Forms.CheckBox();
            this.cbAlkemicar = new System.Windows.Forms.CheckBox();
            this.btnSljedece = new System.Windows.Forms.Button();
            this.lblBrojPitanja = new System.Windows.Forms.Label();
            this.lblPetoPitanje = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPanicar
            // 
            this.cbPanicar.AutoSize = true;
            this.cbPanicar.BackColor = System.Drawing.Color.Transparent;
            this.cbPanicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPanicar.Location = new System.Drawing.Point(356, 203);
            this.cbPanicar.Margin = new System.Windows.Forms.Padding(2);
            this.cbPanicar.Name = "cbPanicar";
            this.cbPanicar.Size = new System.Drawing.Size(81, 24);
            this.cbPanicar.TabIndex = 30;
            this.cbPanicar.Text = "Paničar";
            this.cbPanicar.UseVisualStyleBackColor = false;
            this.cbPanicar.CheckedChanged += new System.EventHandler(this.cbPanicar_CheckedChanged);
            // 
            // cbBotanicar
            // 
            this.cbBotanicar.AutoSize = true;
            this.cbBotanicar.BackColor = System.Drawing.Color.Transparent;
            this.cbBotanicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBotanicar.Location = new System.Drawing.Point(356, 162);
            this.cbBotanicar.Margin = new System.Windows.Forms.Padding(2);
            this.cbBotanicar.Name = "cbBotanicar";
            this.cbBotanicar.Size = new System.Drawing.Size(96, 24);
            this.cbBotanicar.TabIndex = 29;
            this.cbBotanicar.Text = "Botaničar";
            this.cbBotanicar.UseVisualStyleBackColor = false;
            this.cbBotanicar.CheckedChanged += new System.EventHandler(this.cbBotanicar_CheckedChanged);
            // 
            // cbHigijenicar
            // 
            this.cbHigijenicar.AutoSize = true;
            this.cbHigijenicar.BackColor = System.Drawing.Color.Transparent;
            this.cbHigijenicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHigijenicar.Location = new System.Drawing.Point(356, 124);
            this.cbHigijenicar.Margin = new System.Windows.Forms.Padding(2);
            this.cbHigijenicar.Name = "cbHigijenicar";
            this.cbHigijenicar.Size = new System.Drawing.Size(101, 24);
            this.cbHigijenicar.TabIndex = 28;
            this.cbHigijenicar.Text = "Higijeničar";
            this.cbHigijenicar.UseVisualStyleBackColor = false;
            this.cbHigijenicar.CheckedChanged += new System.EventHandler(this.cbHigijenicar_CheckedChanged);
            // 
            // cbAlkemicar
            // 
            this.cbAlkemicar.AutoSize = true;
            this.cbAlkemicar.BackColor = System.Drawing.Color.Transparent;
            this.cbAlkemicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlkemicar.Location = new System.Drawing.Point(356, 84);
            this.cbAlkemicar.Margin = new System.Windows.Forms.Padding(2);
            this.cbAlkemicar.Name = "cbAlkemicar";
            this.cbAlkemicar.Size = new System.Drawing.Size(97, 24);
            this.cbAlkemicar.TabIndex = 27;
            this.cbAlkemicar.Text = "Alkemičar";
            this.cbAlkemicar.UseVisualStyleBackColor = false;
            this.cbAlkemicar.CheckedChanged += new System.EventHandler(this.cbAlkemicar_CheckedChanged);
            // 
            // btnSljedece
            // 
            this.btnSljedece.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSljedece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSljedece.Location = new System.Drawing.Point(762, 394);
            this.btnSljedece.Margin = new System.Windows.Forms.Padding(2);
            this.btnSljedece.Name = "btnSljedece";
            this.btnSljedece.Size = new System.Drawing.Size(94, 34);
            this.btnSljedece.TabIndex = 26;
            this.btnSljedece.Text = "Sljedeće";
            this.btnSljedece.UseVisualStyleBackColor = false;
            this.btnSljedece.Click += new System.EventHandler(this.btnSljedece_Click);
            // 
            // lblBrojPitanja
            // 
            this.lblBrojPitanja.AutoSize = true;
            this.lblBrojPitanja.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojPitanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojPitanja.Location = new System.Drawing.Point(11, 9);
            this.lblBrojPitanja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrojPitanja.Name = "lblBrojPitanja";
            this.lblBrojPitanja.Size = new System.Drawing.Size(55, 24);
            this.lblBrojPitanja.TabIndex = 25;
            this.lblBrojPitanja.Text = "5 / 15";
            // 
            // lblPetoPitanje
            // 
            this.lblPetoPitanje.AutoSize = true;
            this.lblPetoPitanje.BackColor = System.Drawing.Color.Transparent;
            this.lblPetoPitanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetoPitanje.Location = new System.Drawing.Point(305, 40);
            this.lblPetoPitanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPetoPitanje.Name = "lblPetoPitanje";
            this.lblPetoPitanje.Size = new System.Drawing.Size(470, 24);
            this.lblPetoPitanje.TabIndex = 24;
            this.lblPetoPitanje.Text = "Kojim je romanom Paulo Coehlo stekao svjetsku slavu?";
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.BurlyWood;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Location = new System.Drawing.Point(354, 394);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(94, 34);
            this.btnOdustani.TabIndex = 23;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // PetoPitanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(989, 451);
            this.Controls.Add(this.cbPanicar);
            this.Controls.Add(this.cbBotanicar);
            this.Controls.Add(this.cbHigijenicar);
            this.Controls.Add(this.cbAlkemicar);
            this.Controls.Add(this.btnSljedece);
            this.Controls.Add(this.lblBrojPitanja);
            this.Controls.Add(this.lblPetoPitanje);
            this.Controls.Add(this.btnOdustani);
            this.Name = "PetoPitanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetoPitanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPanicar;
        private System.Windows.Forms.CheckBox cbBotanicar;
        private System.Windows.Forms.CheckBox cbHigijenicar;
        private System.Windows.Forms.CheckBox cbAlkemicar;
        private System.Windows.Forms.Button btnSljedece;
        private System.Windows.Forms.Label lblBrojPitanja;
        private System.Windows.Forms.Label lblPetoPitanje;
        private System.Windows.Forms.Button btnOdustani;
    }
}