using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Tuote : jaakaappi
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public Tuote(string nimi, int määrä)
        {
            Name = nimi;
            Amount = määrä;
        }

    }
}
