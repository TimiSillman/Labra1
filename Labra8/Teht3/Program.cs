using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fisher krista = new Fisher("Krista", "12345678");
            Place jyvaskyla = new Place("Jyväskylä", "lake");
            Fish monni = new Fish("Monni", (float)10.1, (float)100);
            Fisher pasi = new Fisher("Pasi", "0987765");
            Fish kuha = new Fish("Kuha", (float)2.5, (float)50);
            krista.lisaaKala(monni, jyvaskyla);
            krista.lisaaKala(new Fish("Kenkä", (float)90, (float)40), jyvaskyla);
            pasi.lisaaKala(kuha, jyvaskyla);
            Console.WriteLine("Kristas fish");
            foreach(var k in krista.allfish)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Pasis fish");
            foreach (var k in pasi.allfish)
            {
                Console.WriteLine(k);
            }
        }
    }
}
