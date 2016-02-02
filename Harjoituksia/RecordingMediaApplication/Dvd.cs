using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingMediaApplication
{
    class Dvd : Media
    {
        public int DvdID { get; set; }

        public Dvd()
        {

        }

        public Dvd(string name, string maker, int duration, string position, int dvdID)
            :base(name,maker,duration,position)
        {
            DvdID = dvdID;
        }

        public override string ToString()
        {
            return base.ToString() + ", DvdID: " + DvdID;
        }
    }
}
