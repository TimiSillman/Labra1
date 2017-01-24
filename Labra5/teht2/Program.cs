using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Tuotelista = new List<string>();
            jaakaappi jääkaappi = new jaakaappi();

                jääkaappi.LisääTuote(new Tuote("Kalja", 200));
                jääkaappi.LisääTuote(new Tuote("Peruna", 2));
                jääkaappi.LisääTuote(new Tuote("Kurkku", 1));
                jääkaappi.LisääTuote(new Tuote("Kello", 100));
                jääkaappi.LisääTuote(new Tuote("Teline", 10));

            for (int i = 0; i < jääkaappi.lista.Count; i++)
            {
                Console.WriteLine("Tuote: " + jääkaappi.lista[i].Name + " " + jääkaappi.lista[i].Amount  + "kpl.");
            }
        }
    }
}
