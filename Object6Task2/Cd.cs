using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object6Task2
{
    class CD
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public List<Track> Tracks;
        
        public CD()
        {
            Tracks = new List<Track>();
        }
        public void NewTrack(Track track)
        {           
            Tracks.Add(track);            
        }

        public override string ToString()
        {
            string data = " ** CD **";
            data += "\nArtist: " + Artist + "\nName: " + Name;
            data += "\n\nTracks:";

            foreach (Track track in Tracks)
            {
                if (track != null) data += "\n" + track.ToString();                
            }
            return data;
        }
    }
}
