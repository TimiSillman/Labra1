using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            bike pyora = new bike("a", "lol",1004,"puanne", false,"top kek");
            boat laiva = new boat("b", "eks dee", 14, "musta", 10, "hnngg");
            Console.WriteLine(pyora.ToString());
            Console.WriteLine(laiva.ToString());
        }
    }
}
