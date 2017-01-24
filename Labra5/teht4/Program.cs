using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Laitelista = new List<string>();
            tietokone kone = new tietokone();

            kone.LisääLaite(new lisalaite("Pro gaming mouse"));
            kone.LisääLaite(new lisalaite("Pro keyboard"));
            kone.LisääLaite(new lisalaite("Pro mousepad"));
            kone.LisääLaite(new lisalaite("eks dee screen"));

            for (int i = 0; i < kone.lista.Count; i++)
            {
                Console.WriteLine("Laite: " + kone.lista[i].Name);
            }
        }
    }
}
