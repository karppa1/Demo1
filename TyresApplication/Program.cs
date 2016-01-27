using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyresApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Vehicle("Toyota", "Purkki");
            Console.WriteLine(car1.ToString());

            car1.RemoveTyres();
            Console.WriteLine(car1.ToString());
            Console.WriteLine();

            car1.AddTyre(new Tyre("Nokia", "Hakkaapäälle", "195/65R15"));
            car1.AddTyre(new Tyre("Nokia", "Hakkaapäälle", "195/65R15"));
            car1.AddTyre(new Tyre("Nokia", "Hakkaapäälle", "195/65R15"));
            car1.AddTyre(new Tyre("Nokia", "Hakkaapäälle", "195/65R15"));
            Console.WriteLine(car1.ToString());

            Console.ReadLine();
        }
    }
}
