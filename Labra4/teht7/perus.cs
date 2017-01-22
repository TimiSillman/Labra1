using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht7
{
    class perus
    {
        public string bussi { get; set; }
        public string aika { get; set; }
        public perus(string bus, string time)
        {
            bussi = bus;
            aika = time;
        }
        public override string ToString()
        {
            return bussi + " " + aika;
        }
    }
}
