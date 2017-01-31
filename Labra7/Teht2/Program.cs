using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = path + @"\nimet.txt";
            if (File.Exists(filePath))
            {
                List<string> nimet = new List<string>();
                string[] names = System.IO.File.ReadAllLines(filePath);
                foreach (string a in names)
                {
                    nimet.Add(a);
                }
                var tuplat = nimet.GroupBy(x => x)
                                      .ToDictionary(g => g.Key,
                                                    g => g.Count());
                foreach (var b in tuplat)
                {
                    Console.WriteLine(b);
                }
            }
            else Console.WriteLine("tiedostoa ei löydy");

        }
    }
}
