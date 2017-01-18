using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class perus
    {
        public string nimi;
        public string malli;
        public int vuosi;
        public string vari;

        public perus(string name, string model, int year, string color)
        {
            nimi = name;
            malli = model;
            vuosi = year;
            vari = color;
        }
        public override string ToString()
        {
            return nimi + " " + malli + " " + vuosi + " " + vari;
        }
    }
}
