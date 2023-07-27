using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Hand
    {
        protected List<Card> cards = new List<Card>();

        public Hand()
        {
            //Hello
        }

        public void clear()
        {
            cards.Clear();
        }

        public void addCard(Card card)
        {
            cards.Add(card);
        }

        public void removeCard(Card card)
        {
            cards.Remove(card);
        }

        public void removeCard(int card)
        {
            card--;
            cards.RemoveAt(card);
        }

        public int getCardsCount()
        {
            return cards.Count();
        }

        public void sortBySuit()
        {
            List<Card> tempList = new List<Card>();

            int count = 0;
            while(count < getCardsCount())
            {
                if(cards[count].getSuit() == 1)
                {
                    tempList.Add(cards[count]);
                }
            }

            count = 0;
            while (count < getCardsCount())
            {
                if (cards[count].getSuit() == 2)
                {
                    tempList.Add(cards[count]);
                }
            }

            count = 0;
            while (count < getCardsCount())
            {
                if (cards[count].getSuit() == 3)
                {
                    tempList.Add(cards[count]);
                }
            }

            count = 0;
            while (count < getCardsCount())
            {
                if (cards[count].getSuit() == 3)
                {
                    tempList.Add(cards[count]);
                }
            }

            cards = tempList;
        }

        public void sortByValue()
        {
            cards = cards.OrderBy(card => card.getValue()).ThenBy(card => card.getSuit()).ToList();
        }
    }
}
