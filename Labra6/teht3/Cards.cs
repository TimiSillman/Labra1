using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Cards
    {
        public List<string> Kortit = new List<string>();
        public Cards()
        {
            for (int i = 1; i < 15; i++)
            {
                Kortit.Add("Hertta " + i);
            }
            for (int i = 1; i < 15; i++)
            {
                Kortit.Add("Pata " + i);
            }
            for (int i = 1; i < 15; i++)
            {
                Kortit.Add("Risti " + i);
            }
            for (int i = 1; i < 15; i++)
            {
                Kortit.Add("Ruutu " + i);
            }
        }
    }
}
