using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class boat : perus
    {
        public int tuoli { get; set; }
        public string tyyppi { get; set; }

        public boat(string name, string model, int year, string color, int seats, string type) : base(name,model,year,color)
        {
            tuoli = seats;
            tyyppi = type;
        }

        public override string ToString()
        {
            return base.ToString() + " " + tuoli + " " + tyyppi;
        }
    }
}
