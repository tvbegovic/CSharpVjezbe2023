using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortiranjeRijeci
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            var rijeci = txtRijeci.Text;
            var poljeRijeci = rijeci.Split(' ');
            Array.Sort(poljeRijeci);
            lstSortirano.DataSource = poljeRijeci;
        }

        private void btnSortirajOrder_Click(object sender, EventArgs e)
        {
            var rijeci = txtRijeci.Text;
            var poljeRijeci = rijeci.Split(' ');
            var sortiranoPolje = poljeRijeci.OrderBy(r => r);
            lstSortirano.DataSource = sortiranoPolje.ToArray();
        }

        private void btnSortirajSilazno_Click(object sender, EventArgs e)
        {
            var rijeci = txtRijeci.Text;
            var poljeRijeci = rijeci.Split(' ');
            var sortiranoPolje = poljeRijeci.OrderByDescending(r => r);
            lstSortirano.DataSource = sortiranoPolje.ToArray();
        }
    }
}
