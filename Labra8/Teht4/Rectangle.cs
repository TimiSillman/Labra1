using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Rectangle : Shape
    {
        public float heigth;
        public float width;
        public Rectangle(float Heigth, float Width)
        {
            heigth = Heigth;
            width = Width;
        }
        public override float Area()
        {
            return width*heigth;
        }
        public override float Circumference()
        {
            return 2*(width + heigth);
        }
        public override string ToString()
        {
            return "Rectangle heigth = " + heigth  + " Width = " + width + " Area = " + String.Format("{0:0.00}", Area()) + " Circumference = " + String.Format("{0:0.00}", Circumference());
        }
    }
}
