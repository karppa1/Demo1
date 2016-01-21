using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiuasApplication
{
    class Kiuas
    {
        public string Power { get; set; }
        public int Temp { get; set; }
        public int Moist { get; set; }

        public void TurnOn()
        {
            Power = "Päällä";
        }

        public void TurnOff()
        {
            Power = "Off";
            Temp = 0;
            Moist = 0;
        }
        public void SetTemp()
        {
            Console.WriteLine("Säädä kiukaan lämpötila 0-130 astetta ");
            int adjustTemp = int.Parse(Console.ReadLine());

            Temp = adjustTemp;
        }

        public void SetMoist()
        {
            Console.WriteLine("Säädä kiukaan kosteus 0-100 % ");
            int adjustMoist = int.Parse(Console.ReadLine());

            Moist = adjustMoist;
        }

        public void PrintData()
        {
            Console.WriteLine("* Kiukaan tiedot *");
            Console.WriteLine("Kiukaan tila: " + Power);
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
