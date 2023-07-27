using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Framework.GL
{
    class SmartEnemy : Enemy
    {
        public Player player;
        int timer = 0;
        public SmartEnemy(Image character, GameCell startCell, Player player, ProgressBar health) : base(character, health)
        {
            this.CurrentCell = startCell;
            this.player = player;
        }

        public override GameCell move()
        {
            if (timer == 5)
            {
                direction = getDirection();
                GameCell currentCell = this.CurrentCell;
                GameCell nextCell = CurrentCell.nextCell(direction);
                this.CurrentCell = nextCell;

                if (currentCell != nextCell)
                {
                    currentCell.setGameObject(Game.getBlankGameObject());

                }
                timer = 0;
                return nextCell;
            }

            else
            {
                direction = getDirectionForRandom();
                GameCell currentCell = this.CurrentCell;
                GameCell nextCell = CurrentCell.nextCell(direction);
                this.CurrentCell = nextCell;

                if (currentCell != nextCell)
                {
                    currentCell.setGameObject(Game.getBlankGameObject());

                }
                timer++;
                return nextCell;
            }
        }

        public GameDirection getDirection()
        {
            double[] distance = new double[4];
            distance = getDistances();
            if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
            {
                return GameDirection.Up;
            }

            else if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
            {
                return GameDirection.Down;
            }

            else if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
            {
                return GameDirection.Left;
            }

            else if(distance[3] <= distance[0] && distance[3] <= distance[1] && distance[3] <= distance[2])
            {
                return GameDirection.Right;
            }

            return GameDirection.Down;
        }

        public double[] getDistances()
        {
            double[] list = new double[4];
            list[0] = calculateDistance(CurrentCell.X - 1, CurrentCell.Y, player.CurrentCell.X, player.CurrentCell.Y); // Up 
            list[1] = calculateDistance(CurrentCell.X + 1, CurrentCell.Y, player.CurrentCell.X, player.CurrentCell.Y); // Down
            list[2] = calculateDistance(CurrentCell.X, CurrentCell.Y - 1, player.CurrentCell.X, player.CurrentCell.Y); // Left
            list[3] = calculateDistance(CurrentCell.X, CurrentCell.Y + 1, player.CurrentCell.X, player.CurrentCell.Y); // Right
            return list;
        }

        static double calculateDistance(int X, int Y, int pX, int pY)
        {
            return Math.Sqrt(Math.Pow((pX - X), 2) + Math.Pow((pY - Y), 2));
        }

        public int getRandom()
        {
            Random r = new Random();
            int value = r.Next(4);
            return value;
        }

        public GameDirection getDirectionForRandom()
        {
            int value = getRandom();
            if (value == 0)
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
            return Properties.Resources.fire_red;
        }

        public override bool addBullet()
        {
            if (fireTime == 5)
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
