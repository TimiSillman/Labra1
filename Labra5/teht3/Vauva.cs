using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Vauva : Ihminen
    {
        public string Vaippa { get; set; }

        public Vauva(string vaippa, string nimi, float paino, float pituus, int ika) : base(nimi, paino, pituus, ika)
        {
            Vaippa = vaippa;
        }

        public override string Liiku()
        {
            return "konttaan";
        }
    }
}
