using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class vahvistin
    {
        private int max = 100;
        private int min = 0;
        private int current;
        public int volume
        {
            get { return current; }
            set
            {
                current = value;
                if (value < min) { volume = 0; }
                if (value > max) { volume = 100;}
            }
        }

        public void vola()
        {
            while (true)
            {
                Console.Write("anna völyymi: ");
                volume = int.Parse(Console.ReadLine());
                Console.WriteLine("völyymi: " + volume);
            }
        }

    }
}

