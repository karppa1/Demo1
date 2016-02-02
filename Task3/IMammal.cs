using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract class IMammal
    {
        public int Age { get; set; }
        abstract public void Move(int amount);

    }
}
