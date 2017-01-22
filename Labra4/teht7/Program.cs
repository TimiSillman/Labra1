using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht7
{
    class Program
    {
        static void Main(string[] args)
        {
            matkustaja a = new matkustaja("onnibus 100", "10:30", "pertti", "opsikelija");
            Console.WriteLine(a.ToString());
        }
    }
}
