using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class cd :perus
    {
        public string artisti { get; set; }
        public string levyNimi { get; set; }
        public cd(int age, int release, string artist, string cdName) : base(age,release)
        {
            artisti = artist;
            levyNimi = cdName;
        }
        public override string ToString()
        {
            return base.ToString() + " " + artisti + " " + levyNimi;
        }
    }
}
