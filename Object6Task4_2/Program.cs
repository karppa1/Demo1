using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object6Task4_2
{

        class Program
        {
            static private Random rand;

            static string RandomString(int length)
            {
                string ret = "";
                for (int i = 0; i < length; i++)
                {
                    ret += (char)rand.Next('A', 'Z');
                }
                return ret;
            }

            static void Main(string[] args)
            {
                rand = new Random();

                List<Person> persons = new List<Person>();

                const int personCount = 10000;

                // start computing elapsed time
                Stopwatch watch = new Stopwatch();
                watch.Start();

                // add persons to list
                for (int i = 0; i < personCount; i++)
                {
                    Person p = new Person(RandomString(12),
                                            RandomString(4),
                                            RandomString(8),
                                            rand.Next(1, 100),
                                            rand.Next(30, 140),
                                            rand.Next(100, 220));
                    persons.Add(p);
                }

                watch.Stop();
                Console.WriteLine("Adding persons took " + watch.ElapsedMilliseconds + "ms");

                watch.Restart();

                for (int i = 0; i < 1000; i++)
                {
                    string nameToFind = RandomString(4);
                    Person p = persons.Find(x => x.FirstName == nameToFind);
                    if (p != null)
                    {
                        Console.WriteLine("Found person with firstname " + nameToFind + " : " + p.FirstName + " " + p.LastName);
                    }
                }

                watch.Stop();
                Console.WriteLine("Finding persons took " + watch.ElapsedMilliseconds + "ms");

                Console.ReadLine();
            }
        }
    }
