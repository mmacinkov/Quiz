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
    public partial class DevetoPitanje : Form
    {
        public DevetoPitanje()
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
                DesetoPitanje desetoPitanje = new DesetoPitanje();
                PomocUNavigaciji.IdiNaFormu(this, desetoPitanje);
            }
        }

        private void cbKongo_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbKongo.Checked = false;
            }
        }

        private void cbNil_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbNil.Checked = false;
            }
        }

        private void cbZambezi_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbZambezi.Checked = false;
            }
        }

        private void cbNiger_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbNiger.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbKongo.Checked)
            {
                brojOznacenih++;
            }
            if (cbNil.Checked)
            {
                brojOznacenih++;
            }
            if (cbZambezi.Checked)
            {
                brojOznacenih++;
            }
            if (cbNiger.Checked)
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
            if (cbKongo.Checked)
            {
                brojOznacenih++;
            }
            if (cbNil.Checked)
            {
                brojOznacenih++;
            }
            if (cbZambezi.Checked)
            {
                brojOznacenih++;
            }
            if (cbNiger.Checked)
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
            if (cbKongo.Checked)
            {
                PohranaOdgovora.Deveto = "Kongo";
            }
            if (cbNil.Checked)
            {
                PohranaOdgovora.Deveto = "Nil";
            }
            if (cbZambezi.Checked)
            {
                PohranaOdgovora.Deveto = "Zambezi";
            }
            if (cbNiger.Checked)
            {
                PohranaOdgovora.Deveto = "Niger";
            }
        }
    }
}
