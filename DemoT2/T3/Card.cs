using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Card
    {
        private string name = "";
        private string owner = "";
        private string serialcode = "";

        public string Name { get { return name; } }

        public Card(string name, string owner, string serialcode)
        {
            this.name = name;
            this.owner = owner;
            this.serialcode = serialcode;
        }

        public override string ToString()
        {
            return name + " , " + owner + " , " + serialcode;
        }
    }
}
