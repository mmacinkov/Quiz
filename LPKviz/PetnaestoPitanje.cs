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
    public partial class PetnaestoPitanje : Form
    {
        public PetnaestoPitanje()
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
                Zavrsetak zavrsetak = new Zavrsetak();
                PomocUNavigaciji.IdiNaFormu(this, zavrsetak);
            }
        }

        private void cbJagoda_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbJagoda.Checked = false;
            }
        }

        private void cbNives_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbNives.Checked = false;
            }
        }

        private void cbDubravka_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbDubravka.Checked = false;
            }
        }

        private void cbDragica_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbDragica.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbJagoda.Checked)
            {
                brojOznacenih++;
            }
            if (cbNives.Checked)
            {
                brojOznacenih++;
            }
            if (cbDubravka.Checked)
            {
                brojOznacenih++;
            }
            if (cbDragica.Checked)
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
            if (cbJagoda.Checked)
            {
                brojOznacenih++;
            }
            if (cbNives.Checked)
            {
                brojOznacenih++;
            }
            if (cbDubravka.Checked)
            {
                brojOznacenih++;
            }
            if (cbDragica.Checked)
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
            if (cbJagoda.Checked)
            {
                PohranaOdgovora.Petnaesto = "Jagoda Burić";
            }
            if (cbNives.Checked)
            {
                PohranaOdgovora.Petnaesto = "Nives Kaburić-Kurtović";
            }
            if (cbDubravka.Checked)
            {
                PohranaOdgovora.Petnaesto = "Dubravka Babić";
            }
            if (cbDragica.Checked)
            {
                PohranaOdgovora.Petnaesto = "Dragica Cvek-Jordan";
            }
        }
    }
}
