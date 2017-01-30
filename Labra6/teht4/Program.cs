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
            Joukkue a = new Joukkue();
            while (true)
            {
            Console.WriteLine("Valitse toiminto:");
            Console.WriteLine("1.Lisää pelaaja");
            Console.WriteLine("2.Poista pelaaja");
            Console.WriteLine("3.Listaa pelaajat");



                int f = int.Parse(Console.ReadLine());
                switch (f)
                {

                    case 1:
                        Console.WriteLine("Anna pelaajan tiedot järjestyksessää nimi, sukunimi, ika, numero: ");
                        a.LisaaPelaaja(new Pelaaja { Etunimi = Console.ReadLine(), Sukunimi = Console.ReadLine(), Ika = int.Parse(Console.ReadLine()), Numero = int.Parse(Console.ReadLine()) });
                        break;
                    case 2:
                        Console.WriteLine("Anna pelaaja numero jonka haluat poistaa: ");
                        int y = 0;
                        y = int.Parse( Console.ReadLine());
                        Pelaaja toDelete = a.pelaajat.Find(x => x.Numero == y);
                        a.PoistaPelaaja(toDelete);
                        break;
                    case 3:
                        Console.WriteLine("Pelaajat: ");
                        foreach (var g in a.pelaajat)
                        {
                            Console.WriteLine(g);
                        }
                        break;
                        
                }
                Console.WriteLine();
            }
        }
    }
}
