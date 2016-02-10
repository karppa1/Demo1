using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product products = new Product();

            products.AddProduct(new Item { Name = "Beer", Price = 0.99f });
            products.AddProduct(new Item { Name = "Milk", Price = 0.89f });
            products.AddProduct(new Item { Name = "Butter", Price = 1.89f });
            products.AddProduct(new Item { Name = "Cheese", Price = 1.59f });

            Console.WriteLine(" ** All products in collection: **");
            Console.WriteLine(products.ToString());

            Console.ReadLine();
        }
    }
}
