using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoituksia
{
    class Program
    {
        static void Main(string[] args)
        {

            Harjoitus3();

            Console.ReadLine();

        }
        // ------------
        static void Harjoitus3()
        {
            int num1, num2, num3 = 0;

            Console.Write("Anna eka luku > ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Anna toka luku > ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Anna kolmas luku > ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lukujen summa on " + (num1 + num2 + num3));

            Console.WriteLine("Lukujen keskiarvo on " + (num1 + num2 + num3) / 3);

        }
        // ------------        
        static void Harjoitus4()
        {

            int age = 0;

            Console.WriteLine("Anna ikäsi > ");
            age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Alaikäinen");
            }

            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("Aikuinen");
            }

            else
            {
                Console.WriteLine("Seniori");
            }

        }
        // ------------
        static void Harjoitus5()
        {
            int sec = 0;
            int tunnit = 0;
            int min = 0;

            Console.WriteLine("Anna sekunnit > ");
            sec = int.Parse(Console.ReadLine());

            tunnit = sec / 3600;
            min = sec / 60 % 60;
            sec = sec % 60;

            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + tunnit + (" tunti ") + min + (" minuutti ") + sec + (" sekuntti"));
        }
        // ------------
        static void Harjoitus6()
        {
            int matka = 0;
            double totalkulu = 0;
            double totalhinta = 0;
            const double kulutus = 7.02;
            const double hinta = 1.595;

            Console.WriteLine("Anna matka > ");
            matka = int.Parse(Console.ReadLine());

            totalkulu = kulutus * matka / 100;
            totalhinta = totalkulu * hinta;

            Console.WriteLine("Kulutus on " + totalkulu + " litraa " + ", kustannus " + totalhinta + " euroa");
        }
        // ------------
        static void Harjoitus7()
        {
            int year = 0;

            Console.WriteLine("Anna vuosiluku > ");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 400 == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi! ");
            }

            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi! ");
            }
        }
        // ------------
        static void Harjoitus8()
        {
            const int numValues = 3;
            int[] table = new int[numValues];

            for (int i = 0; i < numValues; i++)
            {
                Console.WriteLine("Anna numero > ");
                table[i] = int.Parse(Console.ReadLine());
            }

            int number = 0;

            Array.Sort(table);
            number = table[2];

            Console.WriteLine("Suurin luku on " + number);
        }
        // ------------
        static void Harjoitus9()
        {
            int number = 0;
            int sum = 0;

            do
            {

                Console.WriteLine("Anna luku > ");
                number = int.Parse(Console.ReadLine());

                sum += number;

            } while (number != 0);

            Console.WriteLine("Lukujen summa on " + sum);
        }
        // ------------
        static void Harjoitus10()
        {
            const int numValues = 9;
            int[] taulukko = new int[numValues] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < numValues; i++)
            {
                if (taulukko[i] % 2 == 0)
                {
                    Console.WriteLine("HEP! numero: " + taulukko[i]);
                }
            }
        }
        // ------------
        static void Harjoitus11()
        {

            int number = 0;

            Console.WriteLine("Anna luku > ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        // ------------
        static void Harjoitus12()
        {
            const int numValues = 5;
            int[] taulukko = new int[numValues];

            for (int i = 0; i < numValues; i++)
            {
                Console.WriteLine("Anna luku > ");
                taulukko[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Luvut käänteisessä järjestyksessä ");

            for (int i = numValues - 1; i >= 0; i--)
            {
                Console.WriteLine(taulukko[i]);
            }
        }
        // ------------
        static void Harjoitus13()
        {
            const int numValues = 5;
            int[] taulukko = new int[numValues];

            for (int i = 0; i < numValues; i++)
            {
                Console.WriteLine("Anna luku > ");
                taulukko[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            Array.Sort(taulukko);   // Lajittelu suuruusjärjestykseen

            for (int i = 1; i < taulukko.Length - 1; i++)
            {
                sum += taulukko[i];
            }

            Console.WriteLine("Kokonaispisteet: " + sum);
        }
        // ------------
        static void Harjoitus16()
        {
            bool done = false;
            int randomNumber = new Random().Next(0, 100);

            do
            {

                Console.WriteLine("Arvaa luku > ");
                int number = int.Parse(Console.ReadLine());

                if (number == randomNumber)
                {
                    Console.WriteLine("Oikein!");
                    done = true;
                }

                else if (number > randomNumber)
                {
                    Console.WriteLine("Numero on pienempi!");
                }

                else if (number < randomNumber)
                {
                    Console.WriteLine("Numero on suurempi!");
                }

            } while (!done);
        }
        // ------------

    }
}

