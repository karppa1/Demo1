using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingMediaApplication
{
    class Media
    {
        public string Name { get; set; }
        public string Maker { get; set; }
        public int Duration { get; set; }
        public string Position { get; set; }

        public Media()
        {

        }

        public Media(string name, string maker, int duration, string position)
        {
            Name = name;
            Maker = maker;
            Duration = duration;
            Position = position;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Maker: " + Maker + ", Duration: " + Duration + " min" + ", Position: " + Position;
        }
    }
}
