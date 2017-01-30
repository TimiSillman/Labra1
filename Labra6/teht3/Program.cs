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
            Cards kortit = new Cards();
            List<string> arvotut = new List<string>();
            Random rnd = new Random();
            for (int i = 52; i > 0; i --)
             {
                int f = rnd.Next(0, 52);
                
                if (arvotut.Contains(kortit.Kortit[f])) {
                    i++;
                }
                else arvotut.Add(kortit.Kortit[f]);

             }
            foreach  (string a in arvotut)
           {
               Console.WriteLine(a);
           }
            Console.WriteLine(arvotut.Count);
        }
    }
}
