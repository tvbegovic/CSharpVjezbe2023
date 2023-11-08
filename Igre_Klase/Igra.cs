using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igre_Klase
{
    internal class Igra
    {
        private string naziv, opis, vrsta, izdavac;
        private DateTime datumIzdavanja;
        private double cijena;

        public void UnesiPodatke(string naziv, string opis, string vrsta, string izdavac, DateTime datumIzdavanja, double cijena)
        {
            if (string.IsNullOrEmpty(naziv))
                throw new ArgumentException("Naziv mora biti upisan");

            this.naziv = naziv;
            this.opis = opis;
            this.vrsta = vrsta;
            this.izdavac = izdavac;
            this.datumIzdavanja = datumIzdavanja;
            this.cijena = cijena;
        }
    }
}
