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
    public partial class DvanaestoPitanje : Form
    {
        public DvanaestoPitanje()
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
                TrinaestoPitanje trinaestoPitanje = new TrinaestoPitanje();
                PomocUNavigaciji.IdiNaFormu(this, trinaestoPitanje);
            }
        }

        private void cbUrugvaj_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbUrugvaj.Checked = false;
            }
        }

        private void cbCile_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbCile.Checked = false;
            }
        }

        private void cbKolumbija_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbKolumbija.Checked = false;
            }
        }

        private void cbVenezuela_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbVenezuela.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbUrugvaj.Checked)
            {
                brojOznacenih++;
            }
            if (cbCile.Checked)
            {
                brojOznacenih++;
            }
            if (cbKolumbija.Checked)
            {
                brojOznacenih++;
            }
            if (cbVenezuela.Checked)
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
            if (cbUrugvaj.Checked)
            {
                brojOznacenih++;
            }
            if (cbCile.Checked)
            {
                brojOznacenih++;
            }
            if (cbKolumbija.Checked)
            {
                brojOznacenih++;
            }
            if (cbVenezuela.Checked)
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
            if (cbUrugvaj.Checked)
            {
                PohranaOdgovora.Dvanaesto = "Urugvaj";
            }
            if (cbCile.Checked)
            {
                PohranaOdgovora.Dvanaesto = "Cile";
            }
            if (cbKolumbija.Checked)
            {
                PohranaOdgovora.Dvanaesto = "Kolumbija";
            }
            if (cbVenezuela.Checked)
            {
                PohranaOdgovora.Dvanaesto = "Venezuela";
            }
        }
    }
}
