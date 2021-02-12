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
    public partial class DesetoPitanje : Form
    {
        public DesetoPitanje()
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
                JedanaestoPitanje jedanaestoPitanje = new JedanaestoPitanje();
                PomocUNavigaciji.IdiNaFormu(this, jedanaestoPitanje);
            }
        }

        private void cbRijecnih_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbRijecnih.Checked = false;
            }
        }

        private void cbBjeloglavih_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbBjeloglavih.Checked = false;
            }
        }

        private void cbRoda_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbRoda.Checked = false;
            }
        }

        private void cbOrlova_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbOrlova.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbRijecnih.Checked)
            {
                brojOznacenih++;
            }
            if (cbBjeloglavih.Checked)
            {
                brojOznacenih++;
            }
            if (cbRoda.Checked)
            {
                brojOznacenih++;
            }
            if (cbOrlova.Checked)
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
            if (cbRijecnih.Checked)
            {
                brojOznacenih++;
            }
            if (cbBjeloglavih.Checked)
            {
                brojOznacenih++;
            }
            if (cbRoda.Checked)
            {
                brojOznacenih++;
            }
            if (cbOrlova.Checked)
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
            if (cbRijecnih.Checked)
            {
                PohranaOdgovora.Deseto = "Riječnih galebova";
            }
            if (cbBjeloglavih.Checked)
            {
                PohranaOdgovora.Deseto = "Bjeloglavih supova";
            }
            if (cbRoda.Checked)
            {
                PohranaOdgovora.Deseto = "Roda";
            }
            if (cbOrlova.Checked)
            {
                PohranaOdgovora.Deseto = "Orlova";
            }
        }
    }
}
