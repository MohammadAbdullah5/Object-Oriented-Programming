using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GL
{
    class RandomGhost : Ghost
    {
        public RandomGhost(char character, GameCell startCell) : base(character)
        {
            this.CurrentCell = startCell;
        }

        public override GameCell move()
        {
            direction = getDirection();
            GameCell next = base.CurrentCell.nextCell(direction);

            if (next != null)
            {
                return next;
            }
            return null;
        }

        public int getRandom()
        {
            Random r = new Random();
            int value = r.Next(4);
            return value;
        }

        public GameDirection getDirection()
        {
            int value = getRandom();   
            if(value == 0)
            {
                return GameDirection.Left;
            }

            else if (value == 1)
            {
                return GameDirection.Right;
            }

            else if (value == 2)
            {
                return GameDirection.Up;
            }

            else
            {
                return GameDirection.Down;
            }
        }
    }
}
