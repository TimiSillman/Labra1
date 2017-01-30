using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Cd
    {
        public List<string> Songs = new List<string>();
        public string Name { get; set; }
        public Cd(string name)
        {
            Name = name;
        }
        public void addSongs(string song, string duration)
        {
            string s = song +  " " + duration;
            Songs.Add(s);
        }
        string printAll()
        {
            string g="";
            for (int i = 0; i < Songs.Count; i++)
            {
                g += Songs[i] + "\n";
            }
            return g;
        }
        public string data()
        {
            return "LEVY: " + Name +"\n\nBiisit: \n" + printAll();
        }


    }
}
