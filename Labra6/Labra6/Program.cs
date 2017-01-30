using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6
{
    class Program
    {
        static void Main(string[] args)
        {
            Testaa();
        }

        static void Testaa()
        {
            //luodaan muutama testi henkilo
            Henkilot a = new Henkilot();
            Henkilo hlo = new Henkilo { Etunimi= "asd", Sukunimi= "lol", Hetu = "10"};
            Henkilo hlo1 = new Henkilo { Etunimi = "pertti", Sukunimi = "kakapyly", Hetu = "2222" };
            Henkilo hlo2 = new Henkilo { Etunimi = "eks", Sukunimi = "dee", Hetu = "420" };
            a.Lisaahenkilo(hlo);
            a.Lisaahenkilo(hlo1);
            a.Lisaahenkilo(hlo2);
            foreach (Henkilo h in a.henkiloLista)
            {
                Console.WriteLine(h.ToString());
            }
            Console.WriteLine("HAE HENKILO: ");
            Console.WriteLine("Tulkoset : \n" + a.HaehenkiloHetu(Console.ReadLine()));
        }
    }
}
