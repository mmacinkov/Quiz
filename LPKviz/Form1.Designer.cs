namespace LPKviz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnZapocniRjesavanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZapocniRjesavanje
            // 
            this.btnZapocniRjesavanje.BackColor = System.Drawing.Color.Peru;
            this.btnZapocniRjesavanje.FlatAppearance.BorderSize = 2;
            this.btnZapocniRjesavanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZapocniRjesavanje.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapocniRjesavanje.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZapocniRjesavanje.Location = new System.Drawing.Point(266, 357);
            this.btnZapocniRjesavanje.Name = "btnZapocniRjesavanje";
            this.btnZapocniRjesavanje.Size = new System.Drawing.Size(152, 43);
            this.btnZapocniRjesavanje.TabIndex = 0;
            this.btnZapocniRjesavanje.Text = "ZAPOČNI RJEŠAVANJE";
            this.btnZapocniRjesavanje.UseVisualStyleBackColor = false;
            this.btnZapocniRjesavanje.Click += new System.EventHandler(this.btnZapocniRjesavanje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(674, 430);
            this.Controls.Add(this.btnZapocniRjesavanje);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZapocniRjesavanje;
    }
}

