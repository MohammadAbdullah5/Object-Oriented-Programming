using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Framework.GL
{
    class HorizontalEnemy : Enemy
    {
        public HorizontalEnemy(Image img, GameCell startCell, GameDirection direction, ProgressBar health) : base(img, health)
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
                if (direction == GameDirection.Left)
                {
                    direction = GameDirection.Right;
                }

                else if (direction == GameDirection.Right)
                {
                    direction = GameDirection.Left;
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
            return Properties.Resources.fire_purple;
        }

        public override bool addBullet()
        {
            if (fireTime == 15)
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
