using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class boss : person
    {
        public string auto { get; set; }
        public int bonus { get; set; }

        public boss(string name, string profession, int salary, string car, int bonari) : base(name, profession, salary)
        {
            auto = car;
            bonus = bonari;
        }
        public override string ToString()
        {
            return base.ToString() + " " + auto + " " +bonus;
        }
    }
}
