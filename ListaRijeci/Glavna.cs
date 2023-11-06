using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaRijeci
{
    public partial class Glavna : Form
    {
        List<string> rijeci = new List<string>();
        public Glavna()
        {
            InitializeComponent();
        }

        void AzurirajListBox()
        {
            lstRijeci.DataSource = null;
            lstRijeci.DataSource = rijeci;
        }

        private void btnDodajNaKraj_Click(object sender, EventArgs e)
        {
            var rijec = txtJednaRijec.Text;
            rijeci.Add(rijec);
            AzurirajListBox();
        }

        private void btnDodajNaPoziciju_Click(object sender, EventArgs e)
        {
            var unos = txtPozicija.Text;
            var ok = int.TryParse(unos, out int pozicija);
            if(!ok)
            {
                MessageBox.Show("Broj je u pogrešnom formatu");
                return;
            }
            if(pozicija < 0 || pozicija > rijeci.Count)
            {
                MessageBox.Show("Pozicija je izvan raspona");
                return;
            }
            var rijec = txtJednaRijec.Text;
            rijeci.Insert(pozicija, rijec);
            AzurirajListBox();
        }

        private void btnDodajVise_Click(object sender, EventArgs e)
        {
            var poljeRijeci = txtViseRijeci.Text.Split(' ');
            rijeci.AddRange(poljeRijeci);
            AzurirajListBox();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            var index = lstRijeci.SelectedIndex;
            if(index >= 0)
            {
                rijeci.RemoveAt(index);
                AzurirajListBox();
            }
        }

        private void btnIsprazni_Click(object sender, EventArgs e)
        {
            rijeci.Clear();
            AzurirajListBox();
        }
    }
}
