using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.PowerOn();
            radio.PrintData();

            do
            {
                Console.WriteLine("* Choose action *");
                Console.WriteLine("1. Adjust Volume ");
                Console.WriteLine("2. Adjust Frequency ");
                Console.WriteLine("3. Power off ");

                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        radio.AdjustVolume();
                        break;

                    case 2:
                        radio.AdjustFrequency();
                        break;

                    case 3:
                        radio.PowerOff();
                        break;

                    default:
                        Console.WriteLine("Error! ");
                        break;
                }

                radio.PrintData();               

            } while (radio.Power != false);

            Console.ReadLine();

        }
    }
}
