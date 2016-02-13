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
            int kokoluku;
            double liukuluku;

            Console.WriteLine("Anna luku > ");
            string luku = Console.ReadLine();
            
            if (int.TryParse(luku, out kokoluku))
            {
                Console.WriteLine("Kokonaisluku!");
                Console.WriteLine("Luku oli: " + kokoluku);
            }
            else if (double.TryParse(luku, out liukuluku))
            {
                Console.WriteLine("Liukuluku!");
                Console.WriteLine("Luku oli: " + liukuluku);
            }         
            else
            {
                Console.WriteLine("Et antanut lukua!");
            }

            
            Console.ReadLine();
        }
    }
}
