using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Aikuinen : Ihminen
    {
        public string Auto { get; set; }

        public Aikuinen(string auto, string nimi, float paino, float pituus, int ika) : base(nimi, paino, pituus, ika)
        {
            Auto = auto;
        }

        public override string Liiku()
        {
            return "kävelen";
        }
    }
}
