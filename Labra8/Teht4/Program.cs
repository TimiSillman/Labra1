using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes asd = new Shapes();
            asd.addShape(new Circle(1));
            asd.addShape(new Circle(2));
            asd.addShape(new Circle(3));
            asd.addShape(new Rectangle(10, 20));
            asd.addShape(new Rectangle(20, 30));
            asd.addShape(new Rectangle(40, 50));
            foreach (var k in asd.shapes)
            {
                Console.WriteLine(k);
            }
        }
    }
}
