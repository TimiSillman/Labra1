using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Circle : Shape
    {
        public float radius;
        public Circle(float Radius)
        {
            radius = Radius;
        }
        public override float Area()
        {
            return (float)Math.PI * (radius * radius);
        }
        public override float Circumference()
        {
            return 2 * (float)Math.PI * radius;
        }
        public override string ToString()
        {
            return "Circle Radius = " + radius + " Area = " + String.Format("{0:0.00}", Area()) + " Circumference = "+ String.Format("{0:0.00}", Circumference());
        }
    }
}
