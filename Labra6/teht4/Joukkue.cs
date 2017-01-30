using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Joukkue
    {
        public string joukkue = "JYP";
        public string Kotikaupunki = "Jyväskylä";
        public List<Pelaaja> pelaajat;
        public Joukkue()
        {
            pelaajat = new List<Pelaaja>();
        }
        public void LisaaPelaaja(Pelaaja pl)
        {
            pelaajat.Add(pl);
        }

        public void PoistaPelaaja(Pelaaja pl)
        {
            
            pelaajat.Remove(pl);
        }
        public override string ToString()
        {
            return joukkue + " " + Kotikaupunki;
        }


    }
}
