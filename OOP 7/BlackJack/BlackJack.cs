using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class BlackJack : Hand
    {
        public int getJetBlackValue()
        {
            int val = 0;
            bool ace = false;

            foreach (Card card in cards)
            {
                if (card.getValue() == 11 || card.getValue() == 12 || card.getValue() == 13)
                {
                    val += 10;
                }

                else if (card.getValue() == 1 && ace == false)
                {
                    if (val <= 10)
                    {
                        val += 10;
                        ace = true;
                    }
                }

                else if (card.getValue() == 1 && ace == true)
                {
                    val += 1;
                }

                else
                {
                    val += card.getValue();
                }
            }
            return val;
        }
    }
}
