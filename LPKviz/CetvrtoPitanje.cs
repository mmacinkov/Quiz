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
    public partial class CetvrtoPitanje : Form
    {
        public CetvrtoPitanje()
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
                PetoPitanje petoPitanje = new PetoPitanje();
                PomocUNavigaciji.IdiNaFormu(this, petoPitanje);
            }
        }

        private void cbTlacilo_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbTlacilo.Checked = false;
            }
        }

        private void cbVratilo_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbVratilo.Checked = false;
            }
        }

        private void cbKvacilo_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbKvacilo.Checked = false;
            }
        }

        private void cbOsovinu_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbOsovinu.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbTlacilo.Checked)
            {
                brojOznacenih++;
            }
            if (cbVratilo.Checked)
            {
                brojOznacenih++;
            }
            if (cbKvacilo.Checked)
            {
                brojOznacenih++;
            }
            if (cbOsovinu.Checked)
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
            if (cbTlacilo.Checked)
            {
                brojOznacenih++;
            }
            if (cbVratilo.Checked)
            {
                brojOznacenih++;
            }
            if (cbKvacilo.Checked)
            {
                brojOznacenih++;
            }
            if (cbOsovinu.Checked)
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
            if (cbTlacilo.Checked)
            {
                PohranaOdgovora.Cetvrto = "Tlačilo";
            }
            if (cbVratilo.Checked)
            {
                PohranaOdgovora.Cetvrto = "Vratilo";
            }
            if (cbKvacilo.Checked)
            {
                PohranaOdgovora.Cetvrto = "Kvačilo";
            }
            if (cbOsovinu.Checked)
            {
                PohranaOdgovora.Cetvrto = "Osovinu";
            }
        }
    }
}
