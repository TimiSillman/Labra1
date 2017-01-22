using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht7
{
    class matkustaja : perus
    {
        public string henkilo { get; set; }
        public string arvo { get; set; }
        public matkustaja(string bus, string time, string person, string rank) : base(bus,time)
        {
            henkilo = person;
            arvo = rank;
        }
        public override string ToString()
        {
            return base.ToString() + " " + henkilo + " " + arvo;
        }
    }
}
