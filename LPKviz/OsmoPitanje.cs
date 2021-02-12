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
    public partial class OsmoPitanje : Form
    {
        public OsmoPitanje()
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
                DevetoPitanje devetoPitanje = new DevetoPitanje();
                PomocUNavigaciji.IdiNaFormu(this, devetoPitanje);
            }
        }

        private void cbRita_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbRita.Checked = false;
            }
        }

        private void cbMonika_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbMonika.Checked = false;
            }
        }

        private void cbKarla_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbKarla.Checked = false;
            }
        }

        private void cbLuka_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbLuka.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbRita.Checked)
            {
                brojOznacenih++;
            }
            if (cbMonika.Checked)
            {
                brojOznacenih++;
            }
            if (cbKarla.Checked)
            {
                brojOznacenih++;
            }
            if (cbLuka.Checked)
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
            if (cbRita.Checked)
            {
                brojOznacenih++;
            }
            if (cbMonika.Checked)
            {
                brojOznacenih++;
            }
            if (cbKarla.Checked)
            {
                brojOznacenih++;
            }
            if (cbLuka.Checked)
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
            if (cbRita.Checked)
            {
                PohranaOdgovora.Osmo = "Rita";
            }
            if (cbMonika.Checked)
            {
                PohranaOdgovora.Osmo = "Monika";
            }
            if (cbKarla.Checked)
            {
                PohranaOdgovora.Osmo = "Karla";
            }
            if (cbLuka.Checked)
            {
                PohranaOdgovora.Osmo = "Luka";
            }
        }
    }
}
