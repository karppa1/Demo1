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
            ekakiuas.PrintData();
            Console.WriteLine();

            Console.WriteLine("Kytketäänkö kiukaaseen virta? K/E ");
            char option = char.Parse(Console.ReadLine());

                switch (option)
                {
                    case 'k':
                    case 'K': ekakiuas.TurnOn();
                        ekakiuas.SetTemp();
                        ekakiuas.SetMoist();

                        ekakiuas.PrintData();
                        Console.WriteLine();

                        break;

                    case 'e':
                    case 'E': Console.WriteLine("Kiuas ei ole päällä!");

                        break;
                }


            Console.WriteLine("Sammutetaanko kiuas? K/E ");
            option = char.Parse(Console.ReadLine());

            switch (option)
            {

                case 'k':
                case 'K':
                    ekakiuas.TurnOff();
                    Console.WriteLine("Kiuas ei ole päällä!");

                    break;

                case 'e':
                case 'E':
                    ekakiuas.TurnOn();
                    ekakiuas.SetTemp();
                    ekakiuas.SetMoist();

                    break;
            }

            ekakiuas.PrintData();

            Console.ReadLine();
        }
    }
}
