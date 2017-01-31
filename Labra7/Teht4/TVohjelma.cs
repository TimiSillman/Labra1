using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class TVohjelma
    {
        string nimi{get; set;}
        string kanava {get; set;}
        string tiedot {get; set;}
        string loppuu{get; set;}
        string alkaa { get; set; }
        public TVohjelma(string name, string channel, string info, string end, string start)
        {
            nimi = name;
            kanava = channel;
            tiedot = info;
            loppuu = end;
            alkaa = start;
        }
        public override string ToString()
        {
            return  "Ohjelman nimi: "+nimi+"\r\nKanava: "+kanava+"\r\nInfo: "+tiedot+"\r\nAlkaa: "+alkaa+"\r\nLoppuu: "+loppuu;
        }
    }
}
