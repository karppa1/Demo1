using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingMediaApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Media media1 = new Media();
            media1.Name = "Music vol.1";
            media1.Maker = "Somebody";
            media1.Duration = 50;
            media1.Position = "Living room";
            Console.WriteLine(media1.ToString());
            Console.WriteLine();

            Cd cd1 = new Cd();
            cd1.Name = "Heavy Metal vol.1";
            cd1.Maker = "Somebody else";
            cd1.Duration = 66;
            cd1.Position = "CD Player";
            cd1.Genre = "Metal";            
            Console.WriteLine(cd1.ToString());
            Console.WriteLine();

            Dvd dvd1 = new Dvd();
            dvd1.Name = "Movie 1";
            dvd1.Maker = "Movie Maker";
            dvd1.Duration = 120;
            dvd1.Position = "DVD Player";
            dvd1.DvdID = 12345;            
            Console.WriteLine(dvd1.ToString());

            Console.ReadLine();

        }
    }
}
