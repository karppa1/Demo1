using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object6Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("12345-6789", "Aku", "Ankka", 50, 40, 70));
            persons.Add(new Person("94875-6723", "Aku1", "Ankka3", 23, 41, 71));
            persons.Add(new Person("98643-6756", "Aku2", "Ankka2", 45, 42, 72));
            persons.Add(new Person("12231-2352", "Aku3", "Ankka6", 67, 43, 73));
            persons.Add(new Person("12353-2353", "Aku4", "Ankka4", 89, 44, 74));
            persons.Add(new Person("12222-6352", "Aku5", "Ankka9", 21, 45, 75));
            persons.Add(new Person("98375-9887", "Aku6", "Ankka0", 64, 46, 76));
            persons.Add(new Person("23523-2665", "Aku7", "Ankka5", 39, 47, 77));

            /*
            foreach (Person somebody in persons)
            {
                Console.WriteLine(somebody.ToString());
            }
            */

            // sorting by age...

            persons.Sort((x, y) => x.Age.CompareTo(y.Age));

            foreach (Person somebody in persons)
            {
                Console.WriteLine(somebody.ToString());
            }

            // try to find a person...

            string SSN = "12222-6352";

            Person found = persons.Find(x => x.SSN == SSN);

            if (found != null)
            {
                Console.WriteLine("Person with SSN " + SSN + " FOUND!");
            }
            else
            {
                Console.WriteLine("Person not found!");
            }

            // try to find person with age...

            Person found2 = persons.Find(x => x.Age == 67);

            if (found != null)
            {
                Console.WriteLine("Person FOUND!");
            }
            else
            {
                Console.WriteLine("Person not found!");
            }

            /*
            foreach (Person somebody in persons)
            {
                if (somebody.SSN == SSN)
                {
                    Console.WriteLine("Person with SSN " + SSN + " FOUND!");
                    break;
                }
            }
            */

            Console.ReadLine();

        }

    }
}
