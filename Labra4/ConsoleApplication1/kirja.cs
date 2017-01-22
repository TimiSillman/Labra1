using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class kirja : perus
    {
        public string kirjaNimi { get; set; }
        public string kirjailija{ get; set; }
        public kirja(int age, int release, string bookName, string writer) : base(age,release)
        {
            kirjaNimi =bookName;
            kirjailija = writer;
        }
        public override string ToString()
        {
            return base.ToString() + " " + kirjaNimi + " " + kirjailija;
        }
    }
}
