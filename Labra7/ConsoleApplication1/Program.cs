using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string f;
            try
            {
                using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter("test.txt"))
                {
                    while (true)
                    {
                        f = Console.ReadLine();
                        if (f != "")
                        {
                            outputFile.WriteLine(f);
                        }
                        else break; ;
                    }

                    outputFile.Close();
                    string text = System.IO.File.ReadAllText("test.txt");
                    System.Console.WriteLine(text);
                    
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }

        }
    }
}
