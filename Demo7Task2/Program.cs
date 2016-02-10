using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Anna luku > ");
            string line = Console.ReadLine();

            try
            {
                int number = int.Parse(line);
                Console.WriteLine("Luku oli: " + number);

            } catch(FormatException)
            {
                Console.WriteLine("Error!");
            }

            Console.ReadLine();
        }
    }
}
