using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] taulukko = {  };
            double[] taulukko = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            Console.WriteLine("Summa: " + ArrayCalcs.Sum(taulukko));
            Console.WriteLine("Keskiarvo: {0:F2}", ArrayCalcs.Avg(taulukko));
            Console.WriteLine("Pienin luku: " + ArrayCalcs.Min(taulukko));
            Console.WriteLine("Suurin luku: " + ArrayCalcs.Max(taulukko));

            Console.ReadLine();
        }
    }
}
