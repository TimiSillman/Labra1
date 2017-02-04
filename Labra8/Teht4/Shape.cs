using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    abstract class Shape
    {
        string nimi { get; set; }
        public abstract float Area();
        public abstract float Circumference();

    }
}
