using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiuasApplication
{
    class Kiuas
    {
        public int Temp { get; set; }
        public int Moist { get; set; }

        public void SetTemp()
        {
            Temp += 15;
        }

        public void SetMoist()
        {
            Moist += 25;
        }

        public void PrintData()
        {
            Console.WriteLine("* Kiukaan tiedot *");
            Console.WriteLine("Lämpötila: " + Temp + " astetta");
            Console.WriteLine("Kosteus:" + Moist + " %");
            Console.WriteLine();
        }

        ~Kiuas()
        {
            Console.WriteLine("Kiuas poistettu!");
        }
    }
}
