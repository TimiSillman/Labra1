using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            kirja book = new kirja(10, 1998, "potter", "petteri");
            cd levy = new cd(20, 2005, "eks dee", "yo");
            Console.WriteLine(book.ToString());
            Console.WriteLine(levy.ToString());
        }
    }
}