using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Shapes
    {
        public List<Shape> shapes = new List<Shape>();
        public void addShape(Shape shape)
        {
            shapes.Add(shape);
        }
    }
}
