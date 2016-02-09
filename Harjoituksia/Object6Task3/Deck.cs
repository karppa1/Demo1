using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object6Task3
{
    class Deck
    {
        private Card[] deck;
        private const int MaxCards = 52;
        private int currentCard = 0;
        private Random rand;

        public Deck()
        {
            string[] number = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] type = { "Spades", "Hearts", "Diamonds", "Clubs" };
            deck = new Card[MaxCards];
            rand = new Random();

            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card(number[i % 13], type[i / 13]);
            }
        }

        public void Shuffle()
        {
            for (int i = 0; i < deck.Length; i++)
            {
                int j = rand.Next(MaxCards);
                Card temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }            
        }

        public Card DealCard()
        {          
            if (currentCard < deck.Length)
                return deck[currentCard++];
            else
                return null;           
        }
    }
}
