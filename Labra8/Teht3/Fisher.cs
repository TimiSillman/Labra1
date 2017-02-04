using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Fisher
    {
        public List<string> allfish = new List<string>();
        string nimi;
        string puhnum;
        public Fisher(string name, string phonenumber)
        {
            nimi = name;
            puhnum = phonenumber;
            Console.WriteLine("New fisher registered " + nimi + " " + puhnum);
        }
        public void lisaaKala(Fish fish, Place place)
        {
            Console.WriteLine("New fish registered");
            Console.WriteLine(fish.ToString());
            Console.WriteLine(place.ToString());
            allfish.Add(fish.ToString() + place.ToString());
        }
        public override string ToString()
        {
            return "Nimi: " + nimi + "Puhelinnumero: " + puhnum;
        }

    }
}
