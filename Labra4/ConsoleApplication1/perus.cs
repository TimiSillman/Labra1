using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class perus
    {
        public int ika { get; set; }
        public int julakisu { get; set; }
        public perus(int age, int release )
        {
            ika = age;
            julakisu = release;
        }
                    public override string ToString()
        {
            return ika + " " + julakisu;
        }
    }
}
