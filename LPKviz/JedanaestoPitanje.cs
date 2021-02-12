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
    public partial class JedanaestoPitanje : Form
    {
        public JedanaestoPitanje()
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
                DvanaestoPitanje dvanaestoPitanje = new DvanaestoPitanje();
                PomocUNavigaciji.IdiNaFormu(this, dvanaestoPitanje);
            }
        }

        private void cbLjepota_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbLjepota.Checked = false;
            }
        }

        private void cbNada_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbNada.Checked = false;
            }
        }

        private void cbLjubav_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbLjepota.Checked = false;
            }
        }

        private void cbMudrost_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbMudrost.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbLjepota.Checked)
            {
                brojOznacenih++;
            }
            if (cbNada.Checked)
            {
                brojOznacenih++;
            }
            if (cbLjubav.Checked)
            {
                brojOznacenih++;
            }
            if (cbMudrost.Checked)
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
            if (cbLjepota.Checked)
            {
                brojOznacenih++;
            }
            if (cbNada.Checked)
            {
                brojOznacenih++;
            }
            if (cbLjubav.Checked)
            {
                brojOznacenih++;
            }
            if (cbMudrost.Checked)
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
            if (cbLjepota.Checked)
            {
                PohranaOdgovora.Jedanaesto = "Ljepota";
            }
            if (cbNada.Checked)
            {
                PohranaOdgovora.Jedanaesto = "Nada";
            }
            if (cbLjubav.Checked)
            {
                PohranaOdgovora.Jedanaesto = "Ljubav";
            }
            if (cbMudrost.Checked)
            {
                PohranaOdgovora.Jedanaesto = "Mudrost";
            }
        }
    }
}
