using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak2
{
    public partial class Glavna : Form
    {
        List<Polaznik> polaznici = new List<Polaznik>();
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var ime = txtIme.Text;
            var prezime = txtPrezime.Text;
            var oib = txtOib.Text;
            var unos = txtDatumUpisa.Text;
            var ok = DateTime.TryParse(unos, out DateTime datumUpisa);
            if (!ok)
            {
                MessageBox.Show("Pogrešan format datuma");
                return;
            }
            unos = txtDug.Text;
            ok = double.TryParse(unos, out double dug);
            if (!ok)
            {
                MessageBox.Show("Pogrešan format broja");
                return;
            }
            var polaznik = new Polaznik();
            polaznik.Ime = ime;
            polaznik.Prezime = prezime;
            polaznik.Oib = oib;
            polaznik.DatumUpisa = datumUpisa;
            polaznik.Dug = dug;
            polaznici.Add(polaznik);
            AzurirajGrid();
        }

        void AzurirajGrid()
        {
            dgvPolaznici.DataSource = null;
            dgvPolaznici.DataSource = polaznici;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var datoteka = new StreamWriter("polaznici.txt");
            foreach (var polaznik in polaznici)
            {
                datoteka.WriteLine("{0};{1};{2};{3};{4}",polaznik.Ime, polaznik.Prezime,
                    polaznik.Oib, polaznik.DatumUpisa, polaznik.Dug);
            }
            datoteka.Close();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            polaznici.Clear();
            var redci = File.ReadAllLines("polaznici.txt");
            foreach (var red in redci)
            {
                var stupci = red.Split(';');
                var polaznik = new Polaznik();
                polaznik.Ime = stupci[0];
                polaznik.Prezime = stupci[1];
                polaznik.Oib = stupci[2];                
                var unos = stupci[3];
                var ok = DateTime.TryParse(unos, out DateTime datum);
                if (ok)
                    polaznik.DatumUpisa = datum;
                unos = stupci[4];
                ok = double.TryParse(unos, out double dug);
                if (ok)
                    polaznik.Dug = dug;
                polaznici.Add(polaznik);
            }
            AzurirajGrid();
        }
    }
}
