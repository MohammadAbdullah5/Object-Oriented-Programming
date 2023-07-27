using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GL
{
    class HorizontalGhost : Ghost
    {
        public HorizontalGhost(char character, GameCell startCell, GameDirection direction) : base(character)
        {
            this.CurrentCell = startCell;
            this.direction = direction;
        }

        public override GameCell move()
        {
            GameCell next = base.CurrentCell.nextCell(direction);

            if (next.CurrentGameObject.type == GameObjectType.WALL)
            {
                if (direction == GameDirection.Left)
                {
                    direction = GameDirection.Right;
                }

                else if (direction == GameDirection.Right)
                {
                    direction = GameDirection.Left;
                }
            }

            if (next != null)
            {
                return next;
            }
            return null;
        }

    }
    
}
