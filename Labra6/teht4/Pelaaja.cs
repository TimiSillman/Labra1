using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Ika { get; set; }
        public int Numero { get; set; }
        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + Ika + " " + Numero;
        }
    }
}
