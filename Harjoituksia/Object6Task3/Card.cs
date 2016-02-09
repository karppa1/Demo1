using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object6Task3
{
    class Card
    {
        private string CardNumber { get; set; }
        private string CardType { get; set; }

        public Card (string number,string type)
        {
            CardNumber = number;
            CardType = type;            
        }

        public override string ToString()
        {
            return CardNumber + " of " + CardType;
        }
    }
}
