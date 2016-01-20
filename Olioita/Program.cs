using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioita
{
    struct Point    // Vaihtamalla struct -> class, näkyy ero
    {
        public int x;
        public int y;
    }

    
    class Program
    {
        static void Main(string[] args)
        {

            Point coordinate = new Point();
            coordinate.x = 100;
            coordinate.y = 50;

            ModifyPoint(coordinate);

            Console.WriteLine("Coordinate is: " + coordinate.x + "," + coordinate.y);
            Console.ReadLine();
        }

        static void ModifyPoint(Point p)
        {
            p.x += 500;
            p.y += 1500;
        }
    }
}
