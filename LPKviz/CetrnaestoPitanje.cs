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
    public partial class CetrnaestoPitanje : Form
    {
        public CetrnaestoPitanje()
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
                PetnaestoPitanje petnaestoPitanje = new PetnaestoPitanje();
                PomocUNavigaciji.IdiNaFormu(this, petnaestoPitanje);
            }
        }

        private void cbIstocno_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbIstocno.Checked = false;
            }
        }

        private void cbPlodovi_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbPlodovi.Checked = false;
            }
        }

        private void cbSlatki_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbSlatki.Checked = false;
            }
        }

        private void cbOMisevima_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbOMisevima.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbIstocno.Checked)
            {
                brojOznacenih++;
            }
            if (cbPlodovi.Checked)
            {
                brojOznacenih++;
            }
            if (cbSlatki.Checked)
            {
                brojOznacenih++;
            }
            if (cbOMisevima.Checked)
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
            if (cbIstocno.Checked)
            {
                brojOznacenih++;
            }
            if (cbPlodovi.Checked)
            {
                brojOznacenih++;
            }
            if (cbSlatki.Checked)
            {
                brojOznacenih++;
            }
            if (cbOMisevima.Checked)
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
            if (cbIstocno.Checked)
            {
                PohranaOdgovora.Cetrnaesto = "Istočno od raja";
            }
            if (cbPlodovi.Checked)
            {
                PohranaOdgovora.Cetrnaesto = "Plodovi gnjeva";
            }
            if (cbSlatki.Checked)
            {
                PohranaOdgovora.Cetrnaesto = "Slatki četvrtak";
            }
            if (cbOMisevima.Checked)
            {
                PohranaOdgovora.Cetrnaesto = "O miševima i ljudima";
            }
        }
    }
}
