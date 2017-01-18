using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{


    class Program
    {
        static void Main(string[] args)
        {
            TestaaKiuas();
        }

        static void TestaaKiuas()
        {
            Kiuas kiuas = new Kiuas();
            kiuas.OnkoPaalla = true;
            kiuas.Lampotila = 90;
            kiuas.Kosteus = 50;
            Console.WriteLine("Kiuas on päällä {0}", kiuas.OnkoPaalla);
            Console.WriteLine("Lämpötila {0}", kiuas.Lampotila);
            Console.WriteLine("Kosteus {0}", kiuas.Kosteus);
            kiuas.Kosteus = 101;
            Console.WriteLine("Kosteus {0}", kiuas.Kosteus);
        }
    }
}
