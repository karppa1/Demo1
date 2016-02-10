using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8Task2
{
    class Item
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return "Product: " + Name + ", " + Price + "e";
        }
    }
}
