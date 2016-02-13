using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Demo7Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tila = true;
            int kokoluku;
            double liukuluku;
            List<string> kokonaiset = new List<string>();
            List<string> liukuvat = new List<string>();
            
            do
            {

                Console.WriteLine("Anna luku > ");
                string luku = Console.ReadLine();

                if (int.TryParse(luku, out kokoluku))
                {
                    Console.WriteLine("Kokonaisluku!");
                    Console.WriteLine("Luku oli: " + kokoluku);
                    Console.WriteLine();

                    kokonaiset.Add(kokoluku.ToString());
                    
                }
                else if (double.TryParse(luku, out liukuluku))
                {
                    Console.WriteLine("Liukuluku!");
                    Console.WriteLine("Luku oli: " + liukuluku);
                    Console.WriteLine();

                    liukuvat.Add(liukuluku.ToString());
                                       
                }
                else
                {
                    Console.WriteLine("Et antanut lukua!");
                    tila = false;
                }

            } while (tila == true);

            // Tallennus tiedostoon
            File.WriteAllLines("Integers.txt", kokonaiset);
            File.WriteAllLines("Doubles.txt", liukuvat);

            // Kaikkien annettujen lukujen tulostus konsoliin
            Console.WriteLine("\nKokonaiset: ");
            foreach (string kokotiedot in kokonaiset)
            {
                Console.WriteLine(kokotiedot);
            }

            Console.WriteLine("\nLiukuluvut: ");
            foreach (string liukutiedot in liukuvat)
            {
                Console.WriteLine(liukutiedot);
            }

            Console.ReadLine();
        }
    }
}
