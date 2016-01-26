using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine();
            Console.WriteLine("* Auton tiedot *");            
            Console.WriteLine("Nimi: " + Name);
            Console.WriteLine("Nopeus:" + Speed);
            Console.WriteLine("Renkaat: " + Tyres);
            Console.WriteLine();
        }
    }
}
