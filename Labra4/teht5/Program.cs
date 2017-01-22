using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            radio ratio = new radio(0, 2000);
            while (true)
            {
                Console.WriteLine("radio freq: " + ratio.freq);
                Console.WriteLine("radio volume: " + ratio.volume);
                Console.Write("volume? ");
                ratio.volume = int.Parse(Console.ReadLine());
                Console.Write("freq? ");
                ratio.freq = float.Parse(Console.ReadLine());
            }
        }
    }
}
