using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Place
    {
        string nimi;
        string paikka;
        public Place(string name, string place)
        {
            nimi = name;
            paikka = place;
        }
        public Place()
        {

        }
        public override string ToString()
        {
            return "Location: " + nimi + " " + "Place: " + paikka + "\r\n";
        }
    }
}
