using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Framework.GL
{
    class VerticalEnemy : Enemy
    {
        public VerticalEnemy(Image character, GameCell startCell, GameDirection direction, ProgressBar health) : base(character, health)
        {
            this.CurrentCell = startCell;
            this.direction = direction;
        }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = CurrentCell.nextCell(direction);
            this.CurrentCell = nextCell;
            if (nextCell == currentCell)
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

            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());

            }
            return nextCell;
        }

        public override Image getBulletImage()
        {
            return Properties.Resources.fire_cyan;
        }

        public override bool addBullet()
        {
            if(fireTime == 20)
            {
                fireTime = 0;
                return true;
            }

            else
            {
                fireTime++;
                return false;
            }
        }
    }
}
