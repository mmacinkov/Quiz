using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPKviz
{
    public partial class TrinaestoPitanje : Form
    {
        public TrinaestoPitanje()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForma = new Form1();
            PomocUNavigaciji.IdiNaFormu(this, pocetnaForma);
        }

        private void btnSljedece_Click(object sender, EventArgs e)
        {
            if (!ProvjeraDaJeOdabranTocnoJedanOdgovor())
            {
                UpozorenjeOdabratiOdgovor();
            }
            else
            {
                Pohrani();
                CetrnaestoPitanje cetrnaestoPitanje = new CetrnaestoPitanje();
                PomocUNavigaciji.IdiNaFormu(this, cetrnaestoPitanje);
            }
        }

        private void cbChrisNovoselich_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbChrisNovoselich.Checked = false;
            }
        }

        private void cbAntonyMaglica_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbAntonyMaglica.Checked = false;
            }
        }

        private void cbGaryGabelich_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbGaryGabelich.Checked = false;
            }
        }

        private void cbMikeGrgich_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbMikeGrgich.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbChrisNovoselich.Checked)
            {
                brojOznacenih++;
            }
            if (cbAntonyMaglica.Checked)
            {
                brojOznacenih++;
            }
            if (cbGaryGabelich.Checked)
            {
                brojOznacenih++;
            }
            if (cbMikeGrgich.Checked)
            {
                brojOznacenih++;
            }

            if (brojOznacenih <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void UpozorenjeSamoJedanOdgovor()
        {
            MessageBox.Show("Dozvoljeno je odabrati samo jedan odgovor!", "UPOZORENJE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpozorenjeOdabratiOdgovor()
        {
            MessageBox.Show("Niste odabrali niti jedan odgovor!", "UPOZORENJE",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ProvjeraDaJeOdabranTocnoJedanOdgovor()
        {
            int brojOznacenih = 0;
            if (cbChrisNovoselich.Checked)
            {
                brojOznacenih++;
            }
            if (cbAntonyMaglica.Checked)
            {
                brojOznacenih++;
            }
            if (cbGaryGabelich.Checked)
            {
                brojOznacenih++;
            }
            if (cbMikeGrgich.Checked)
            {
                brojOznacenih++;
            }

            if (brojOznacenih == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Pohrani()
        {
            if (cbChrisNovoselich.Checked)
            {
                PohranaOdgovora.Trinaesto = "Chris Novoselich";
            }
            if (cbAntonyMaglica.Checked)
            {
                PohranaOdgovora.Trinaesto = "Antony Maglica";
            }
            if (cbGaryGabelich.Checked)
            {
                PohranaOdgovora.Trinaesto = "Gary Gabelich";
            }
            if (cbMikeGrgich.Checked)
            {
                PohranaOdgovora.Trinaesto = "Mike Grgich";
            }
        }
    }
}
