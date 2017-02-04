using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Fish
    {
        string laji;
        float pituus;
        float paino;
        public Fish(string specie, float length, float weigth)
        {
            laji = specie;
            pituus = length;
            paino = weigth;
        }
        public Fish()
        {

        }
        public override string ToString()
        {
            return "Specie: " + laji+" " + "Length: " + pituus+ " " + "Weigth: " + paino + " ";
        }
    }
}
