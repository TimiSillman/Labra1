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
            System.IO.StreamWriter integrer = new System.IO.StreamWriter("int.txt");
            System.IO.StreamWriter tupla = new System.IO.StreamWriter("double.txt");
            while (true)
            {


                string f = Console.ReadLine();
                double d;
                bool doubleTrue = double.TryParse(f, out d);
                if (doubleTrue == true)
                {
                    if (f.Contains(","))
                    {
                        tupla.WriteLine(f);
                    }
                    else
                    {
                        integrer.WriteLine(f);
                    }

                }
                else break;
            }
            tupla.Close();
            integrer.Close();
            string integrers = System.IO.File.ReadAllText("int.txt");
            System.Console.WriteLine(integrers);
            string doubles = System.IO.File.ReadAllText("double.txt");
            System.Console.WriteLine(doubles);

        }
    }
}
