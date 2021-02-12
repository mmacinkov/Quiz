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
    public partial class PrvoPitanje : Form
    {
        public PrvoPitanje()
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
                DrugoPitanje drugoPitanje = new DrugoPitanje();
                PomocUNavigaciji.IdiNaFormu(this, drugoPitanje);
            }
        }

        private void cbPare_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbPare.Checked = false;
            }
        }

        private void cbLjubavnicu_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbLjubavnicu.Checked = false;
            }
        }

        private void cbStan_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbStan.Checked = false;
            }
        }

        private void cbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbAuto.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbPare.Checked)
            {
                brojOznacenih++;
            }
            if (cbLjubavnicu.Checked)
            {
                brojOznacenih++;
            }
            if (cbStan.Checked)
            {
                brojOznacenih++;
            }
            if (cbAuto.Checked)
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
            if (cbPare.Checked)
            {
                brojOznacenih++;
            }
            if (cbLjubavnicu.Checked)
            {
                brojOznacenih++;
            }
            if (cbStan.Checked)
            {
                brojOznacenih++;
            }
            if (cbAuto.Checked)
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
            if (cbPare.Checked)
            {
                PohranaOdgovora.Prvo = "Pare";
            }
            if (cbLjubavnicu.Checked)
            {
                PohranaOdgovora.Prvo = "Ljubavnicu";
            }
            if (cbStan.Checked)
            {
                PohranaOdgovora.Prvo = "Stan";
            }
            if (cbAuto.Checked)
            {
                PohranaOdgovora.Prvo = "Auto";
            }
        }
    }
}
