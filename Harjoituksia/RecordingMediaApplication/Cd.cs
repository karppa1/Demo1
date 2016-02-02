using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingMediaApplication
{
    class Cd : Media
    {
        public string Genre { get; set; }

        public Cd()
        {

        }

        public Cd(string name, string maker, int duration, string position, string genre)
            :base(name,maker,duration,position)
        {
            Genre = genre;
        }

        public override string ToString()
        {
            return base.ToString() + ", Genre: " + Genre;
        }
    }
}
