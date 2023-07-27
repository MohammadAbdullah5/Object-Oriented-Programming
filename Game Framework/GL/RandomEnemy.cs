using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Framework.GL
{
    class RandomEnemy : Enemy
    {
        public RandomEnemy(Image character, GameCell startCell, ProgressBar health) : base(character, health)
        {
            this.CurrentCell = startCell;
        }

        public override GameCell move()
        {
            direction = getDirection();
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = CurrentCell.nextCell(direction);
            this.CurrentCell = nextCell;

            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());

            }
            return nextCell;
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

        public override Image getBulletImage()
        {
            return Properties.Resources.fire_yellow;
        }

        public override bool addBullet()
        {
            if (fireTime == 10)
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
