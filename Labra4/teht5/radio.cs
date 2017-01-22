using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class radio
    {
        private float minFreq = 2000F;
        private float maxFreq = 2600F;
        private int minVol = 0;
        private int maxVol = 10;
        private int currentVol;
        private float currentFreq;
        public int volume
        {
            get { return currentVol; }
            set
            {
                currentVol = value;
                if (value < minVol) { volume = 0; }
                if (value > maxVol) { volume = 10; }
            }
        }
        public float freq
        {
            get { return currentFreq; }
            set
            {
                currentFreq = value;
                if (value < minFreq) { freq = 2000F; }
                if (value > maxFreq) { freq = 2600F; }
            }
        }

        public radio(int vol, float taajuus)
        {
            volume = vol;
            freq = taajuus;
        }

    }
}
