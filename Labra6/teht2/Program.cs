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
            Cd levy = new Cd("lol");
            levy.addSongs("asd","10:0");
            levy.addSongs("rr", "19:0");
            levy.addSongs("qwe", "10:2");
            levy.addSongs("uh", "11:0");
            Console.WriteLine(levy.data());
        }
    }
}
