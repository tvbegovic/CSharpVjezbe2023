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

namespace ListeObjekata
{
    public partial class Glavna : Form
    {
        List<Igra> igre = new List<Igra>();
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            var naziv = txtNaziv.Text;
            var opis = txtOpis.Text;
            var vrsta = txtVrsta.Text;
            var izdavac = txtIzdavac.Text;
            var unos = txtDatum.Text;
            var ok = DateTime.TryParse(unos, out DateTime datum);
            if (!ok)
            {
                MessageBox.Show("Pogrešan format datuma");
                return;
            }
            unos = txtCijena.Text;
            ok = double.TryParse(unos, out double cijena);
            if (!ok)
            {
                MessageBox.Show("Pogrešan format broja");
                return;
            }
            var igra = new Igra();
            try
            {
                //igra.UnesiPodatke(naziv, opis, vrsta, izdavac, datum, cijena);
                igra.Naziv = naziv;
                igra.Opis = opis;
                igra.Vrsta = vrsta;
                igra.Izdavac = izdavac;
                igra.DatumIzdavanja = datum;
                igra.Cijena = cijena;
                igre.Add(igra);
                AzurirajGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dogodila se pogreška. Tekst: {ex.Message}");
            }
        }

        void AzurirajGrid()
        {
            dgvIgre.DataSource = null;
            dgvIgre.DataSource = igre;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var datoteka = new StreamWriter("igre.txt");
            foreach (var igra in igre)
            {
                datoteka.WriteLine("{0};{1};{2};{3};{4};{5}",igra.Naziv,igra.Opis,
                    igra.Vrsta,igra.DatumIzdavanja,igra.Cijena, igra.Izdavac);    
            }
            datoteka.Close();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            var redci = File.ReadAllLines("igre.txt");
            foreach (var red in redci)
            {
                var stupci = red.Split(';');
                var igra = new Igra();
                igra.Naziv = stupci[0];
                igra.Opis = stupci[1];
                igra.Vrsta = stupci[2];
                igra.Izdavac = stupci[5];
                var unos = stupci[3];
                var ok = DateTime.TryParse(unos, out DateTime datum);
                if(ok)
                    igra.DatumIzdavanja = datum;
                unos = stupci[4];
                ok = double.TryParse(unos, out double cijena);
                if (ok)
                    igra.Cijena = cijena;
                igre.Add(igra);
            }
            AzurirajGrid();
        }
    }
}
