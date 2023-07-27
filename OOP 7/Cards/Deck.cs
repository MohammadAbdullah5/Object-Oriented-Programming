using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Deck
    {
        public List<Card> cards = new List<Card>(52);
        private int numberOfDeals;

        public Deck()
        {
            for(int i = 1; i < 5; i++)
            {
                for(int j = 1; j < 14; j++)
                {
                    Card card = new Card(j, i);
                    cards.Add(card);
                }
            }
        }

        public void shuffle()
        {
            Random random = new Random();
            int n = cards.Count;

            while (n > 1)
            {
                int k = random.Next(n);
                n--;
                Card temp = cards[k];
                cards[k] = cards[n];
                cards[n] = temp;
            }
        }

        public Card dealCard()
        {
            if (numberOfDeals < cards.Count)
            {
                Card card = cards[numberOfDeals];
                numberOfDeals++;
                return card;
            }
            else
            {
                return null;
            }
        }

        public int CardsRemaining()
        {
            return cards.Count() - numberOfDeals;
        }
    }
}
