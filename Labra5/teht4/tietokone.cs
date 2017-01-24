using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class tietokone
    {
        public List<lisalaite> lista = new List<lisalaite>();
        public tietokone()
        {
        }
        public void LisääLaite(lisalaite Lisalaite)
        {
                lista.Add(Lisalaite);
        }

        public List<lisalaite> TulostaLaitteet
        {
            get { return lista; }
        }
    }
}
