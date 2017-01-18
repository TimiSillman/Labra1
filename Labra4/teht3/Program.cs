using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            person a = new person("petteri","Asd", 20 );
            boss b = new boss("matti", "kokki", 100,"mersu", 20);
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
        }
    }
}
