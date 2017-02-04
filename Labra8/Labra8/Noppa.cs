using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8
{
    class Noppa
    {
        public int määrä = 0;
        int arvottu;
        int summa;
        
        Random rnd = new Random();
        public List<int> numerot = new List<int>();

        public void noppaheitto()
        {
            arvottu = rnd.Next(1, 7);
            summa += arvottu;
            numerot.Add(arvottu);
            määrä++;
        }
        public float keskiarvo()
        {
            return (float)summa/määrä;
        }

        public override string ToString()
        {
            return "heitit noppaa: "+määrä +" kertaa ja keskiarvo on: " + keskiarvo();
        }
    }
}
