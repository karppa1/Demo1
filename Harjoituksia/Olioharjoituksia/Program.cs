using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioharjoituksia
{
    class Kiuas
    {
        public string Model { get; set; }
        public int Temp { get; set; }
        public int Kosteus { get; set; }

        public void AdjustTemp()
        {
            Temp += 5;
        }
        public void PrintData()
        {
            Console.WriteLine(Temp);
            Console.WriteLine(Kosteus);            
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {

            Kiuas joku = new Kiuas();
            joku.Model = "Puu";
            joku.Temp = 80;
            joku.Kosteus = 70;

            joku.PrintData();

            joku.AdjustTemp();
            joku.PrintData();

            Console.ReadLine();

        }


    }
}
