using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            TVohjelma ohjelma = new TVohjelma("Rallit", "Disney channel", "Tälläset lasten rallit", "10:30", "10:00" );
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = path + @"\ohjelmat.txt";
            StreamWriter outputFile = new StreamWriter(filePath);
            outputFile.WriteLine(ohjelma.ToString());
            outputFile.Close();
            string tiedosto = File.ReadAllText(filePath);
            Console.WriteLine(tiedosto);
        }
    }
}
