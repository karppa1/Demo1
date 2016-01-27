using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    class Elevator
    {
        public int Floor
        {
            get { return floor; }
            set {

                if (value < 1)
                {
                    floor = 1;
                    Console.WriteLine("Floor is too small! ");
                }
                else if (value > 5)
                {
                    floor = 5;
                    Console.WriteLine("Floor is too big! ");
                }
                else floor = value;

            }
        }

        public void AskNumber()
        {
            Console.WriteLine("Give a new floor number (1-5) > ");
        }

        public void PrintData()
        {
            Console.WriteLine("Elevator is now in floor : " + floor);
        }

        private int floor = 1;
        
    }
}
