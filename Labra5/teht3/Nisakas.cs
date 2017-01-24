using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    abstract class Nisakas
    {
        public int Ika { get; set; }

        public Nisakas(int ika)
        {
            Ika = ika;
        }

        public abstract string Liiku();
    }
}
