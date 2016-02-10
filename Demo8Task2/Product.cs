using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8Task2
{
    class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public List<Item> ShoppingCart;
        
        public Product()
        {
            ShoppingCart = new List<Item>();
        }

        public void AddProduct(Item item)
        {
            ShoppingCart.Add(item);
        }

        public override string ToString()
        {
            string data = "";            
            foreach (Item item in ShoppingCart)
            {
                if (item != null) data += "\n" + item.ToString();
            }
            return data;
        }
    }
}
