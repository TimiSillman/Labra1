using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6
{
    /// <summary>
    /// This class contains person properties
    /// </summary>
    class Henkilo
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Hetu { get; set; }
        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + Hetu;
        }
    }
    ///this class hold person information in a collection
    ///
    class Henkilot
    {
        private List<Henkilo> henkilot;
        public List<Henkilo> henkiloLista { get { return henkilot; } }
        public Henkilot()
        {
            henkilot = new List<Henkilo>();
        }

        public void Lisaahenkilo(Henkilo hlo)
        {
            henkilot.Add(hlo);
        }

        public Henkilo Haehenkilo(int index)
        {
            if (index < henkilot.Count)
            {
                return henkilot.ElementAt(index);
            }
            else return null;
        }

        public Henkilo HaehenkiloHetu(string hetu)
        {
            foreach (Henkilo hlo in henkilot)
            {
                if (hlo.Hetu == hetu)
                {
                    return hlo;
                }
            }
            return null;
        }
    }
}
