using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Wallet
    {
        private double money = 0.0;
        private Dictionary<string,Card> cards = new Dictionary<string, Card>();

        public Wallet()
        {

        }

        public void addMoney(double amount)
        {
            if (amount > 0)
            {
                money += amount;
            }            
        }

        public double takeMoney(double amount)
        {
            if (amount > money || amount < 0.0)
            {
                amount = 0;
            }
            else
            {
                money -= amount;
            }
            return amount;
        }

        public void addCard(Card card)
        {
            cards.Add(card.Name, card);
        }

        public void takeCard(string cardname)
        {
            cards.Remove(cardname);
        }

        public override string ToString()
        {            
            return string.Format("{0:F2} eur in wallet\n {1} cards in wallet\n", money, cards.Count);
        }
    }
}
