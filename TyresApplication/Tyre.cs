using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyresApplication
{
    class Tyre
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }

        public Tyre(string brand, string model, string size)
        {
            Brand = brand;
            Model = model;
            Size = size;
        }

        public override string ToString()
        {
            return "Tyre: " + Brand + ", " + Model + ", " + Size;
        }
    }
}
