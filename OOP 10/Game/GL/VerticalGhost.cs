using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GL
{
    class VerticalGhost : Ghost
    {
        public VerticalGhost(char character, GameCell startCell, GameDirection direction) : base(character)
        {
            CurrentCell = startCell;
            this.direction = direction;
        }

        public override GameCell move()
        {
            GameCell next = base.CurrentCell.nextCell(direction);

            if (next.CurrentGameObject.type == GameObjectType.WALL)
            {
                if (direction == GameDirection.Up)
                {
                    direction = GameDirection.Down;
                }

                else if (direction == GameDirection.Down)
                {
                    direction = GameDirection.Up;
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
