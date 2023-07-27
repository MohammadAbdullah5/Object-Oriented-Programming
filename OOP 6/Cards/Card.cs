using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Card
    {
        private int value;
        private int suit;

        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public int getSuit()
        {
            return this.suit;
        }

        public int getValue()
        {
            return this.value;
        }

        public string getSuitAsString()
        {
            string suit = "";
            if(this.suit == 1)
            {
                suit = "Club";
            }

            else if (this.suit == 2)
            {
                suit = "Diamond";
            }

            else if (this.suit == 3)
            {
                suit = "Spade";
            }

            else if (this.suit == 4)
            {
                suit = "Heart";
            }
            return suit;
        }

        public string getValueAsString()
        {
            string value = "";
            if (this.value == 1)
            {
                value = "Ace";
            }

            else if (this.value == 2)
            {
                value = "Two";
            }

            else if (this.value == 3)
            {
                value = "Three";
            }

            else if (this.value == 4)
            {
                value = "Four";
            }

            else if (this.value == 5)
            {
                value = "Five";
            }

            else if (this.value == 6)
            {
                value = "Six";
            }

            else if (this.value == 7)
            {
                value = "Seven";
            }

            else if (this.value == 8)
            {
                value = "Eight";
            }

            else if (this.value == 9)
            {
                value = "Nine";
            }

            else if (this.value == 10)
            {
                value = "Ten";
            }

            else if (this.value == 11)
            {
                value = "Jack";
            }

            else if (this.value == 12)
            {
                value = "Queen";
            }

            else if (this.value == 13)
            {
                value = "King";
            }
            return value;
        }

        public string toString()
        {
            string value = getValueAsString();
            string suit = getSuitAsString();
            string card = value + " Of " + suit;
            return card;
        }
    }
}
