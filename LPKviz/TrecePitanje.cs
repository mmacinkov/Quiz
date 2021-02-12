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
    public partial class TrecePitanje : Form
    {
        public TrecePitanje()
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
                CetvrtoPitanje cetvrtoPitanje = new CetvrtoPitanje();
                PomocUNavigaciji.IdiNaFormu(this, cetvrtoPitanje);
            }
        }

        private void cbOmastioKonopac_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbOmastioKonopac.Checked = false;
            }
        }

        private void cbDigaoNos_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbDigaoNos.Checked = false;
            }
        }

        private void cbOsvjetlaoObraz_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbOsvjetlaoObraz.Checked = false;
            }
        }

        private void cbOmastioBrk_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraOznacavanjaOdgovora())
            {
                UpozorenjeSamoJedanOdgovor();
                cbOmastioBrk.Checked = false;
            }
        }

        private bool ProvjeraOznacavanjaOdgovora()
        {
            int brojOznacenih = 0;
            if (cbOmastioKonopac.Checked)
            {
                brojOznacenih++;
            }
            if (cbDigaoNos.Checked)
            {
                brojOznacenih++;
            }
            if (cbOsvjetlaoObraz.Checked)
            {
                brojOznacenih++;
            }
            if (cbOmastioBrk.Checked)
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
            if (cbOmastioKonopac.Checked)
            {
                brojOznacenih++;
            }
            if (cbDigaoNos.Checked)
            {
                brojOznacenih++;
            }
            if (cbOsvjetlaoObraz.Checked)
            {
                brojOznacenih++;
            }
            if (cbOmastioBrk.Checked)
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
            if (cbOmastioKonopac.Checked)
            {
                PohranaOdgovora.Trece = "Omastio konopac";
            }
            if (cbDigaoNos.Checked)
            {
                PohranaOdgovora.Trece = "Digao nos";
            }
            if (cbOsvjetlaoObraz.Checked)
            {
                PohranaOdgovora.Trece = "Osvjetlao obraz";
            }
            if (cbOmastioBrk.Checked)
            {
                PohranaOdgovora.Trece = "Omastio brk";
            }
        }
    }
}
