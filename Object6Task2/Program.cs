using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object6Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            CD cd1 = new CD();
            cd1.Artist = "Lost Society";
            cd1.Name = "Fast Loud Death";
            cd1.NewTrack(new Track { Name = "N.W.L.", Duration = "2.22" });
            cd1.NewTrack(new Track { Name = "Trash All Over You", Duration = "3.41" });
            cd1.NewTrack(new Track { Name = "E.A.G.", Duration = "2.20" });
            cd1.NewTrack(new Track { Name = "Kill (Those Who Oppose Me)", Duration = "2.17" });
            cd1.NewTrack(new Track { Name = "Bitch, Out' My Way", Duration = "4.02" });
            cd1.NewTrack(new Track { Name = "Fast Loud Death", Duration = "3.26" });
            cd1.NewTrack(new Track { Name = "Lead Through the Head", Duration = "3.14" });
            cd1.NewTrack(new Track { Name = "Diary of a Thrashman", Duration = "2.42" });
            cd1.NewTrack(new Track { Name = "Toxic Avenger", Duration = "1.08" });
            cd1.NewTrack(new Track { Name = "This Is Me", Duration = "2.43" });
            cd1.NewTrack(new Track { Name = "Braindead Metalhead", Duration = "3.27" });
            cd1.NewTrack(new Track { Name = "Piss Out My Ass", Duration = "2.00" });
            cd1.NewTrack(new Track { Name = "Fatal Anoxia", Duration = "2.27" });
            cd1.NewTrack(new Track { Name = "Escape from Delirium", Duration = "4.08" });
            cd1.NewTrack(new Track { Name = "I Stole Your Love (KISS-cover)", Duration = "3.23" });

            Console.WriteLine(cd1.ToString());
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

