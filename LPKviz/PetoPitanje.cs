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
    public partial class PetoPitanje : Form
    {
        public PetoPitanje()
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
                SestoPitanje sestoPitanje = new SestoPitanje();
                PomocUNavigaciji.IdiNaFormu(this, sestoPitanje);
            }
        }

        private void cbAlkemicar_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbAlkemicar.Checked = false;
            }
        }

        private void cbHigijenicar_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbHigijenicar.Checked = false;
            }
        }

        private void cbBotanicar_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbBotanicar.Checked = false;
            }
        }

        private void cbPanicar_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbPanicar.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbAlkemicar.Checked)
            {
                brojOznacenih++;
            }
            if (cbHigijenicar.Checked)
            {
                brojOznacenih++;
            }
            if (cbBotanicar.Checked)
            {
                brojOznacenih++;
            }
            if (cbPanicar.Checked)
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
            if (cbAlkemicar.Checked)
            {
                brojOznacenih++;
            }
            if (cbHigijenicar.Checked)
            {
                brojOznacenih++;
            }
            if (cbBotanicar.Checked)
            {
                brojOznacenih++;
            }
            if (cbPanicar.Checked)
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
            if (cbAlkemicar.Checked)
            {
                PohranaOdgovora.Peto = "Alkemičar";
            }
            if (cbHigijenicar.Checked)
            {
                PohranaOdgovora.Peto = "Higijeničar";
            }
            if (cbBotanicar.Checked)
            {
                PohranaOdgovora.Peto = "Botaničar";
            }
            if (cbPanicar.Checked)
            {
                PohranaOdgovora.Peto = "Paničar";
            }
        }
    }
}
