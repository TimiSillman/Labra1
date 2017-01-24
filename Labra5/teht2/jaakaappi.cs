using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class jaakaappi
    {
        public List<Tuote> lista = new List<Tuote>();
        public jaakaappi()
        {
        }
        public void LisääTuote(Tuote tuote)
        {
            if (tuote.Amount > 0)
            {
                lista.Add(tuote);
            }
        }

        public List<Tuote> TulostaTuotteet
        {
            get { return lista; }
        }
    }
}
