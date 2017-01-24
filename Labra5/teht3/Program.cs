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
            Ihminen Paavo = new Ihminen("Paavo", 100, 160, 20);
            Vauva Lol = new Vauva("Libero", "LOL", 10, 50, 1);
            Aikuinen Jonne = new Aikuinen("MERSU", "Jonne", 60, 180, 70);

            Console.WriteLine(Paavo.Nimi + " " + Paavo.Liiku());
            Console.WriteLine(Jonne.Nimi + " " + Jonne.Liiku());
            Console.WriteLine(Lol.Nimi + " " + Lol.Liiku());
            Console.WriteLine(Lol.Nimi + " " + Lol.Vaippa);
            Console.WriteLine(Jonne.Nimi + " " + Jonne.Auto);
            Console.WriteLine(Paavo.Nimi +  " " + Paavo.Paino);

        }
    }
}
