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
    public partial class SestoPitanje : Form
    {
        public SestoPitanje()
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
                SedmoPitanje sedmoPitanje = new SedmoPitanje();
                PomocUNavigaciji.IdiNaFormu(this, sedmoPitanje);
            }
        }

        private void cbTijelovo_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbTijelovo.Checked = false;
            }
        }

        private void cbBogojavljanje_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbBogojavljanje.Checked = false;
            }
        }

        private void cbDuhovi_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbDuhovi.Checked = false;
            }
        }

        private void cbPepelnica_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbPepelnica.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbTijelovo.Checked)
            {
                brojOznacenih++;
            }
            if (cbBogojavljanje.Checked)
            {
                brojOznacenih++;
            }
            if (cbDuhovi.Checked)
            {
                brojOznacenih++;
            }
            if (cbPepelnica.Checked)
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
            if (cbTijelovo.Checked)
            {
                brojOznacenih++;
            }
            if (cbBogojavljanje.Checked)
            {
                brojOznacenih++;
            }
            if (cbDuhovi.Checked)
            {
                brojOznacenih++;
            }
            if (cbPepelnica.Checked)
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
            if (cbTijelovo.Checked)
            {
                PohranaOdgovora.Sesto = "Tijelovo";
            }
            if (cbBogojavljanje.Checked)
            {
                PohranaOdgovora.Sesto = "Bogojavljanje";
            }
            if (cbDuhovi.Checked)
            {
                PohranaOdgovora.Sesto = "Duhovi";
            }
            if (cbPepelnica.Checked)
            {
                PohranaOdgovora.Sesto = "Pepelnica";
            }
        }
    }
}
