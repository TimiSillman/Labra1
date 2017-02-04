using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8
{
    class Program
    {
        static void Main(string[] args)
        {
            Noppa noppa = new Noppa();
            Console.Write("Kuinka monta kertaa heitettää? ");
            int heittomäärä = int.Parse(Console.ReadLine());
            for (int i = 0; i < heittomäärä; i++)
            {
                noppa.noppaheitto();
            }

            Console.WriteLine(noppa.ToString());
        }
    }
}
