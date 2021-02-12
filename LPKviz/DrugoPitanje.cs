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
    public partial class DrugoPitanje : Form
    {
        public DrugoPitanje()
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
                TrecePitanje trecePitanje = new TrecePitanje();
                PomocUNavigaciji.IdiNaFormu(this, trecePitanje);
            }
        }

        private void cbPetrologijom_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbPetrologijom.Checked = false;
            }
        }

        private void cbParapsihologijom_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbParapsihologijom.Checked = false;
            }
        }

        private void cbPapirologijom_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbPapirologijom.Checked = false;
            }
        }

        private void cbProtureformulogijom_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbProtureformulogijom.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbPetrologijom.Checked)
            {
                brojOznacenih++;
            }
            if (cbParapsihologijom.Checked)
            {
                brojOznacenih++;
            }
            if (cbPapirologijom.Checked)
            {
                brojOznacenih++;
            }
            if (cbProtureformulogijom.Checked)
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
            if (cbPetrologijom.Checked)
            {
                brojOznacenih++;
            }
            if (cbParapsihologijom.Checked)
            {
                brojOznacenih++;
            }
            if (cbPapirologijom.Checked)
            {
                brojOznacenih++;
            }
            if (cbProtureformulogijom.Checked)
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
            if (cbPetrologijom.Checked)
            {
                PohranaOdgovora.Drugo = "Petrologijom";
            }
            if (cbParapsihologijom.Checked)
            {
                PohranaOdgovora.Drugo = "Parapsihologijom";
            }
            if (cbPapirologijom.Checked)
            {
                PohranaOdgovora.Drugo = "Papirologijom";
            }
            if (cbProtureformulogijom.Checked)
            {
                PohranaOdgovora.Drugo = "Protureformulogijom";
            }
        }
    }
}
