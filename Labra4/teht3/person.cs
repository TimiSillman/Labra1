using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class person
    {
        public string nimi { get; set; }
        public string työ { get; set; }
        public int palkka { get; set; }

        public person(string name, string profession, int salary)
        {
            nimi = name;
            työ = profession;
            palkka = salary;
        }
        public override string ToString()
        {
            return nimi + " " + työ + " " + palkka;
        }
    }
}
