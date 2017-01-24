using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class lisalaite : tietokone
    {
        public string Name { get; set; }

        public lisalaite(string nimi)
        {
            Name = nimi;
        }

    }
}
