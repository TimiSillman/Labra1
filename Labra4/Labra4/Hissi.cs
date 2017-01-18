using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    class Hissi
    {
        private int max = 5;
        private int min = 1;
        private int current;
        public int floor {
            get { return current; }
            set {
                current = value;
                if (value < min) {floor = 1; } 
                if (value > max) { floor = 5; }
            }
        }

        public void floorselect()
        {
            while (true)
            {
                Console.Write("anna kerros: ");
                floor = int.Parse(Console.ReadLine());
                Console.WriteLine("kerros: " + floor);
            }
        }

    }
}
