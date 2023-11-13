using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeObjekata
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

        public string Naziv 
        {
            get => naziv;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Naziv mora biti upisan");
                naziv = value;
            }
        }

        
        public string Opis { get => opis; set => opis = value; }
        public string Vrsta
        {
            get => vrsta;
            set
            {
                string[] vrste = { "Akcijska", "RPG", "Avantura", "Simulacija", "Sport", "Strategija" };
                if (!vrste.Contains(value))
                    throw new ArgumentException("Nedozvoljena vrsta");
                vrsta = value;
            }
        }
        public string Izdavac { get => izdavac; set => izdavac = value; }
        public DateTime DatumIzdavanja { get => datumIzdavanja; set => datumIzdavanja = value; }
        public double Cijena
        {
            get => cijena;
            set
            {
                if (value < 0 || value > 1000)
                    throw new ArgumentOutOfRangeException("Cijena je izvan raspona");
                cijena = value;
            }
        }
    }
}
