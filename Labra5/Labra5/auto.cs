using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5
{
    class auto
    {
        public string merkki { get; set; }
        private int rengasmaara = 4;
        private int rengaslkm = 0;
        public List<rengas> renkaat { get; }
        public auto()
        {
            renkaat = new List<rengas>();
        }

        public void addWheel(rengas Rengas)
        {
            if (rengaslkm < rengasmaara)
            {
                renkaat.Add(Rengas);
                rengaslkm++;
            }

        }
        public override string ToString()
        {
            string s = merkki + "\nrenkaat:";
            foreach (rengas r in renkaat)
            {
                if (r != null) s += "\n-" + r.ToString();
            }
            return s;
        }
    }
}
