using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Ihminen : Nisakas
    {
        public float Paino { get; set; }
        public float Pituus { get; set; }
        public string Nimi { get; set; }

        public Ihminen(string nimi, float paino, float pituus, int ika) : base(ika)
        {
            Paino = paino;
            Pituus = pituus;
            Nimi = nimi;
        }

        public override string Liiku()
        {
            return "liikun";
        }

        public void Kasva()
        {
            Ika++;
        }
    }
}
