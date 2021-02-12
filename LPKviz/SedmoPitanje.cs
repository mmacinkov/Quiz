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
    public partial class SedmoPitanje : Form
    {
        public SedmoPitanje()
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
                OsmoPitanje osmoPitanje = new OsmoPitanje();
                PomocUNavigaciji.IdiNaFormu(this, osmoPitanje);
            }
        }

        private void cbSplitska_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbSplitska.Checked = false;
            }
        }

        private void cbRijecka_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbRijecka.Checked = false;
            }
        }

        private void cbDubrovacka_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbDubrovacka.Checked = false;
            }
        }

        private void cbZagrebacka_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbZagrebacka.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbSplitska.Checked)
            {
                brojOznacenih++;
            }
            if (cbRijecka.Checked)
            {
                brojOznacenih++;
            }
            if (cbDubrovacka.Checked)
            {
                brojOznacenih++;
            }
            if (cbZagrebacka.Checked)
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
            if (cbSplitska.Checked)
            {
                brojOznacenih++;
            }
            if (cbRijecka.Checked)
            {
                brojOznacenih++;
            }
            if (cbDubrovacka.Checked)
            {
                brojOznacenih++;
            }
            if (cbZagrebacka.Checked)
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
            if (cbSplitska.Checked)
            {
                PohranaOdgovora.Sedmo = "Splitska";
            }
            if (cbRijecka.Checked)
            {
                PohranaOdgovora.Sedmo = "Riječka";
            }
            if (cbDubrovacka.Checked)
            {
                PohranaOdgovora.Sedmo = "Dubrovačka";
            }
            if (cbZagrebacka.Checked)
            {
                PohranaOdgovora.Sedmo = "Zagrebačka";
            }
        }
    }
}
