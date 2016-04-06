using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kosti kosti = new Kosti();

            Console.WriteLine("Kosti is initialized...");

            bool running = true;
            do
            {
                int value = 0;
                running = int.TryParse(Console.ReadLine(), out value);

                if (running)
                {
                    if (value == 0)
                    {
                        kosti.Reset();
                        Console.WriteLine("Kosti is reset");
                    }
                    else
                    {
                        kosti.addValue(value);
                        Console.WriteLine("Value " + value + " is added to Kosti");
                        Console.WriteLine("Min value is " + kosti.Min + " and max value is " + kosti.Max);
                        Console.WriteLine("Average of values is {0:F2} ", kosti.Avg);
                    }
                }
            } while (running);

            Console.WriteLine("Non-number entered, exiting...");

            Console.ReadLine();
        }
    }
}
