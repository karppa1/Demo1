using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object6Task4
{
    class Program
    {
        static private Random rand = new Random();
        static string RandomString(int lenght)
        {
            string ret = "";
            for (int i = 0; i < lenght; i++)
            {
                ret += (char)rand.Next('A', 'Z');
            }

            return ret;
        }
        static void Main(string[] args)
        {
            Random r = new Random();

            List<Person> persons = new List<Person>();

            const int personCount = 10;

            

            for (int i = 0; i < personCount; i++)
            {
                Person p = new Person(RandomString(12), RandomString(4), RandomString(8), rand.Next(1, 100), rand.Next(30, 140), rand.Next(1, 220));
                persons.Add(p);
            }

            Stopwatch watch = new Stopwatch();
            watch.Start();

            foreach (Person somebody in persons)
            {
                Console.WriteLine(somebody.ToString());
            }

            watch.Stop();

            for (int i = 0; i < 1000; i++)
            {
                string nameToFind = RandomString(4);
                Person p = persons.Find(x => x.FirstName == nameToFind);
                if (p != null)
                {
                    Console.WriteLine("Found person with firstname: " + nameToFind + p.ToString());
                }
            }

            /*
            foreach(Person somebody in persons)
            {
                Console.WriteLine(somebody.ToString());
            }
            */
            Console.ReadLine();

        }
    }
}
