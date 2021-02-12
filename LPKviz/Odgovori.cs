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
    public partial class Odgovori : Form
    {
        public Odgovori()
        {
            InitializeComponent();
        }

        private void Odgovori_Load(object sender, EventArgs e)
        {
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
                    button1.BackColor = Color.DarkGreen;
                }
                else
                {
                    button1.BackColor = Color.DarkRed;
                }
            }

            PlQuery drugoPitanje = new PlQuery("drugo(Odgovor)");
            foreach (PlQueryVariables variable in drugoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Drugo)
                {
                    button2.BackColor = Color.DarkGreen;
                }
                else
                {
                    button2.BackColor = Color.DarkRed;
                }
            }

            PlQuery trecePitanje = new PlQuery("trece(Odgovor)");
            foreach (PlQueryVariables variable in trecePitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Trece)
                {
                    button3.BackColor = Color.DarkGreen;
                }
                else
                {
                    button3.BackColor = Color.DarkRed;
                }
            }

            PlQuery cetvrtoPitanje = new PlQuery("cetvrto(Odgovor)");
            foreach (PlQueryVariables variable in cetvrtoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Cetvrto)
                {
                    button4.BackColor = Color.DarkGreen;
                }
                else
                {
                    button4.BackColor = Color.DarkRed;
                }
            }

            PlQuery petoPitanje = new PlQuery("peto(Odgovor)");
            foreach (PlQueryVariables variable in petoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Peto)
                {
                    button5.BackColor = Color.DarkGreen;
                }
                else
                {
                    button5.BackColor = Color.DarkRed;
                }
            }

            PlQuery sestoPitanje = new PlQuery("sesto(Odgovor)");
            foreach (PlQueryVariables variable in sestoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Sesto)
                {
                    button6.BackColor = Color.DarkGreen;
                }
                else
                {
                    button6.BackColor = Color.DarkRed;
                }
            }

            PlQuery sedmooPitanje = new PlQuery("sedmo(Odgovor)");
            foreach (PlQueryVariables variable in sedmooPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Sedmo)
                {
                    button7.BackColor = Color.DarkGreen;
                }
                else
                {
                    button7.BackColor = Color.DarkRed;
                }
            }

            PlQuery osmoPitanje = new PlQuery("osmo(Odgovor)");
            foreach (PlQueryVariables variable in osmoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Osmo)
                {
                    button8.BackColor = Color.DarkGreen;
                }
                else
                {
                    button8.BackColor = Color.DarkRed;
                }
            }

            PlQuery devetoPitanje = new PlQuery("deveto(Odgovor)");
            foreach (PlQueryVariables variable in devetoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Deveto)
                {
                    button9.BackColor = Color.DarkGreen;
                }
                else
                {
                    button9.BackColor = Color.DarkRed;
                }
            }

            PlQuery desetoPitanje = new PlQuery("deseto(Odgovor)");
            foreach (PlQueryVariables variable in desetoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Deseto)
                {
                    button10.BackColor = Color.DarkGreen;
                }
                else
                {
                    button10.BackColor = Color.DarkRed;
                }
            }

            PlQuery jedanaestoPitanje = new PlQuery("jedanaesto(Odgovor)");
            foreach (PlQueryVariables variable in jedanaestoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Jedanaesto)
                {
                    button11.BackColor = Color.DarkGreen;
                }
                else
                {
                    button11.BackColor = Color.DarkRed;
                }
            }

            PlQuery dvanaestoPitanje = new PlQuery("dvanaesto(Odgovor)");
            foreach (PlQueryVariables variable in dvanaestoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Dvanaesto)
                {
                    button12.BackColor = Color.DarkGreen;
                }
                else
                {
                    button12.BackColor = Color.DarkRed;
                }
            }

            PlQuery trinaestoPitanje = new PlQuery("trinaesto(Odgovor)");
            foreach (PlQueryVariables variable in trinaestoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Trinaesto)
                {
                    button13.BackColor = Color.DarkGreen;
                }
                else
                {
                    button13.BackColor = Color.DarkRed;
                }
            }

            PlQuery cetrnaestoPitanje = new PlQuery("cetrnaesto(Odgovor)");
            foreach (PlQueryVariables variable in cetrnaestoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Cetrnaesto)
                {
                    button14.BackColor = Color.DarkGreen;
                }
                else
                {
                    button14.BackColor = Color.DarkRed;
                }
            }

            PlQuery petnaestoPitanje = new PlQuery("petnaesto(Odgovor)");
            foreach (PlQueryVariables variable in petnaestoPitanje.SolutionVariables)
            {
                if (variable["Odgovor"].ToString() == PohranaOdgovora.Petnaesto)
                {
                    button15.BackColor = Color.DarkGreen;
                }
                else
                {
                    button15.BackColor = Color.DarkRed;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.DarkRed)
            {
                PlQuery prvoPitanje = new PlQuery("prvo(Odgovor)");
                foreach (PlQueryVariables variable in prvoPitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Prvo + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button1.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.DarkRed)
            {
                PlQuery drugoPitanje = new PlQuery("drugo(Odgovor)");
                foreach (PlQueryVariables variable in drugoPitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Drugo + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button2.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.DarkRed)
            {
                PlQuery trecePitanje = new PlQuery("trece(Odgovor)");
                foreach (PlQueryVariables variable in trecePitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Trece + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button3.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.DarkRed)
            {
                PlQuery cetvrtoPitanje = new PlQuery("cetvrto(Odgovor)");
                foreach (PlQueryVariables variable in cetvrtoPitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Cetvrto + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button4.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.DarkRed)
            {
                PlQuery petoPitanje = new PlQuery("peto(Odgovor)");
                foreach (PlQueryVariables variable in petoPitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Peto + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button5.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.DarkRed)
            {
                PlQuery sestoPitanje = new PlQuery("sesto(Odgovor)");
                foreach (PlQueryVariables variable in sestoPitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Sesto + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button6.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.DarkRed)
            {
                PlQuery sedmoPitanje = new PlQuery("sedmo(Odgovor)");
                foreach (PlQueryVariables variable in sedmoPitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Sedmo + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button7.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.DarkRed)
            {
                PlQuery osmoPitanje = new PlQuery("osmo(Odgovor)");
                foreach (PlQueryVariables variable in osmoPitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Osmo + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button8.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.DarkRed)
            {
                PlQuery devetoPitanje = new PlQuery("deveto(Odgovor)");
                foreach (PlQueryVariables variable in devetoPitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Deveto + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button9.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.DarkRed)
            {
                PlQuery desetoPitanje = new PlQuery("deseto(Odgovor)");
                foreach (PlQueryVariables variable in desetoPitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Deseto + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button10.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.DarkRed)
            {
                PlQuery jedanaestoPitanje = new PlQuery("jedanaesto(Odgovor)");
                foreach (PlQueryVariables variable in jedanaestoPitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Jedanaesto + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button11.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.DarkRed)
            {
                PlQuery dvanaestoPitanje = new PlQuery("dvanaesto(Odgovor)");
                foreach (PlQueryVariables variable in dvanaestoPitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Dvanaesto + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button12.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.DarkRed)
            {
                PlQuery trinaestoPitanje = new PlQuery("trinaesto(Odgovor)");
                foreach (PlQueryVariables variable in trinaestoPitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Trinaesto + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button13.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.DarkRed)
            {
                PlQuery cetrnaestoPitanje = new PlQuery("cetrnaesto(Odgovor)");
                foreach (PlQueryVariables variable in cetrnaestoPitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Cetrnaesto + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button14.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.DarkRed)
            {
                PlQuery petnaestoPitanje = new PlQuery("petnaesto(Odgovor)");
                foreach (PlQueryVariables variable in petnaestoPitanje.SolutionVariables)
                {
                    MessageBox.Show("Vaš odgovor:" + " " + PohranaOdgovora.Petnaesto + "\n" + "Točan odgovor:" +
                        " " + variable["Odgovor"].ToString());
                }
            }
            else if (button15.BackColor == Color.DarkGreen)
            {
                TocanOdgovor();
            }
        }

        private void TocanOdgovor()
        {
            MessageBox.Show("Vaš odgovor je točan!", "ČESTITKE",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPonovno_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForma = new Form1();
            PomocUNavigaciji.IdiNaFormu(this, pocetnaForma);
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
