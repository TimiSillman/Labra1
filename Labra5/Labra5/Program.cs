using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5
{
    class Program
    {
        static void Main(string[] args)
        {
            rengas b = new rengas { valmistaja = "nokia" };
            auto a = new auto {merkki="nissan" };
            a.addWheel(b);
            a.addWheel(b);
            a.addWheel(b);
            a.addWheel(b);
            Console.WriteLine(a.ToString());
        }
    }
}
