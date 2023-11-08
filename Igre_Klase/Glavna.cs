using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igre_Klase
{
    public partial class Glavna : Form
    {
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
            if(!ok)
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
                igra.UnesiPodatke(naziv, opis, vrsta, izdavac, datum, cijena);
                MessageBox.Show("Podaci su uspješno uneseni");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dogodila se pogreška. Tekst: {ex.Message}");
            }
        }
    }
}
