using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiuasApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas ekakiuas = new Kiuas();
            ekakiuas.Temp = 60;
            ekakiuas.Moist = 62;
            ekakiuas.PrintData();

            Console.WriteLine();

            ekakiuas.SetTemp();
            ekakiuas.SetMoist();
            ekakiuas.PrintData();

            Console.ReadLine();
        }
    }
}
