using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class bike : perus
    {
        public bool vaihde { get; set; }
        public string vaihenimi { get; set; }

        public bike(string name, string model, int year, string color,bool gear, string gearname ) : base(name,model,year,color)
        {
            vaihde = gear;
            vaihenimi = gearname;
        }

        public override string ToString()
        {
            return base.ToString() + " " + vaihde + " " + vaihenimi;
        }
    }
}
