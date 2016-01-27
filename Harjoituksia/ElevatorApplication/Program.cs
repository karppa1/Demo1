using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            elevator.PrintData();
            
                for (int i = 0; i < 5; i++)
                {

                elevator.AskNumber();
                string line = Console.ReadLine();
                int number;
                bool result = int.TryParse(line, out number);
                if (result)
                {
                    elevator.Floor = number;
                }

                elevator.PrintData();
                }
            
            Console.ReadLine();
        }
    }
}
