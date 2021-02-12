namespace LPKviz
{
    partial class Zavrsetak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zavrsetak));
            this.lblOstvariliSte = new System.Windows.Forms.Label();
            this.lblBodovi = new System.Windows.Forms.Label();
            this.btnUvid = new System.Windows.Forms.Button();
            this.btnPonovno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOstvariliSte
            // 
            this.lblOstvariliSte.AutoSize = true;
            this.lblOstvariliSte.BackColor = System.Drawing.Color.Transparent;
            this.lblOstvariliSte.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOstvariliSte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOstvariliSte.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOstvariliSte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOstvariliSte.Location = new System.Drawing.Point(127, 266);
            this.lblOstvariliSte.Name = "lblOstvariliSte";
            this.lblOstvariliSte.Size = new System.Drawing.Size(231, 29);
            this.lblOstvariliSte.TabIndex = 0;
            this.lblOstvariliSte.Text = "TOČNI ODGOVORI:";
            // 
            // lblBodovi
            // 
            this.lblBodovi.BackColor = System.Drawing.Color.Transparent;
            this.lblBodovi.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBodovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBodovi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodovi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBodovi.Location = new System.Drawing.Point(181, 295);
            this.lblBodovi.Name = "lblBodovi";
            this.lblBodovi.Size = new System.Drawing.Size(120, 68);
            this.lblBodovi.TabIndex = 1;
            this.lblBodovi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUvid
            // 
            this.btnUvid.BackColor = System.Drawing.Color.BurlyWood;
            this.btnUvid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUvid.Location = new System.Drawing.Point(278, 385);
            this.btnUvid.Margin = new System.Windows.Forms.Padding(2);
            this.btnUvid.Name = "btnUvid";
            this.btnUvid.Size = new System.Drawing.Size(116, 44);
            this.btnUvid.TabIndex = 27;
            this.btnUvid.Text = "Uvid u odgovore";
            this.btnUvid.UseVisualStyleBackColor = false;
            this.btnUvid.Click += new System.EventHandler(this.btnUvid_Click);
            // 
            // btnPonovno
            // 
            this.btnPonovno.BackColor = System.Drawing.Color.BurlyWood;
            this.btnPonovno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonovno.Location = new System.Drawing.Point(84, 384);
            this.btnPonovno.Margin = new System.Windows.Forms.Padding(2);
            this.btnPonovno.Name = "btnPonovno";
            this.btnPonovno.Size = new System.Drawing.Size(116, 44);
            this.btnPonovno.TabIndex = 28;
            this.btnPonovno.Text = "Igraj ponovno";
            this.btnPonovno.UseVisualStyleBackColor = false;
            this.btnPonovno.Click += new System.EventHandler(this.btnPonovno_Click);
            // 
            // Zavrsetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(721, 607);
            this.Controls.Add(this.btnPonovno);
            this.Controls.Add(this.btnUvid);
            this.Controls.Add(this.lblBodovi);
            this.Controls.Add(this.lblOstvariliSte);
            this.Name = "Zavrsetak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zavrsetak";
            this.Load += new System.EventHandler(this.Zavrsetak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOstvariliSte;
        private System.Windows.Forms.Label lblBodovi;
        private System.Windows.Forms.Button btnUvid;
        private System.Windows.Forms.Button btnPonovno;
    }
}