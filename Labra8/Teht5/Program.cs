using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            ArrayCalcs asd = new ArrayCalcs();
            Console.WriteLine(String.Format("{0:0.00}", asd.sum(array)));
            Console.WriteLine(String.Format("{0:0.00}", asd.ave(array)));
            Console.WriteLine(String.Format("{0:0.00}", asd.min(array)));
            Console.WriteLine(String.Format("{0:0.00}", asd.max(array)));
        }
    }
}
