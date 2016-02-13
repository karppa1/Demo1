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
            bool tila = true;
            int kokoluku;
            double liukuluku;
            List<int> kokonaiset = new List<int>();
            List<double> liukuvat = new List<double>();
            
            do
            {

                Console.WriteLine("Anna luku > ");
                string luku = Console.ReadLine();

                if (int.TryParse(luku, out kokoluku))
                {
                    Console.WriteLine("Kokonaisluku!");
                    Console.WriteLine("Luku oli: " + kokoluku);
                    Console.WriteLine();

                    kokonaiset.Add(kokoluku);

                    /*                System.IO.StreamWriter tallennusTiedosto = null;
                                    try
                                    {
                                        tallennusTiedosto = new System.IO.StreamWriter("Integers.txt");
                                        tallennusTiedosto.WriteLine(kokoluku);
                                    }
                                    finally
                                    {
                                        // check for null because OpenWrite might have failed
                                        if (tallennusTiedosto != null)
                                        {
                                            tallennusTiedosto.Close();
                                        }
                                    }
                                    */
                }
                else if (double.TryParse(luku, out liukuluku))
                {
                    Console.WriteLine("Liukuluku!");
                    Console.WriteLine("Luku oli: " + liukuluku);
                    Console.WriteLine();

                    liukuvat.Add(liukuluku);

                    /*                System.IO.StreamWriter tallennusTiedosto = null;
                                    try
                                    {
                                        tallennusTiedosto = new System.IO.StreamWriter("Doubles.txt");
                                        tallennusTiedosto.WriteLine(liukuluku);
                                    }
                                    finally
                                    {
                                        // check for null because OpenWrite might have failed
                                        if (tallennusTiedosto != null)
                                        {
                                            tallennusTiedosto.Close();
                                        }
                                    }
                                    */
                }
                else
                {
                    Console.WriteLine("Et antanut lukua!");
                    tila = false;
                }

            } while (tila == true);

            Console.WriteLine("\nKokonaiset: ");
            foreach (int kokotiedot in kokonaiset)
            {
                Console.WriteLine(kokotiedot);
            }

            Console.WriteLine("\nLiukuluvut: ");
            foreach (double liukutiedot in liukuvat)
            {
                Console.WriteLine(liukutiedot);
            }

            Console.ReadLine();
        }
    }
}
