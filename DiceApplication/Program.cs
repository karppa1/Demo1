using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number;

            Console.WriteLine("How many times you want to throw a dice? > ");
            string line = Console.ReadLine();                       
            bool result = int.TryParse(line, out number);

            int sum = 0;

            if (result)
            {
                for (int i = 0; i < number; i++)
                {
                    int dice = rand.Next(1, 7);

                    //Console.WriteLine(dice);
                    sum = +(sum + dice);
                }
            }
            else {
                Console.WriteLine("Error!");
                number = 1;
            }

            double avg = 0.0f;
            avg = (sum / (double)number);

            Console.WriteLine("Average: " + avg);
            
            Console.ReadLine();
        }
    }
}
