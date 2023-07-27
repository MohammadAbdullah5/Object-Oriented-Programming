using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GL
{
    class SmartGhost : Ghost
    {
        public GamePacManPlayer pacman;
        public SmartGhost(char character, GameCell startCell, GamePacManPlayer pacman) : base(character)
        {
            CurrentCell = startCell;
            this.pacman = pacman;
        }

        public override GameCell move()
        {
            direction = getDirection();
            GameCell next = CurrentCell.nextCell(direction);

            if (next != null)
            {
                return next;
            }
            return null;
        }

        public GameDirection getDirection()
        {
            double[] distance = new double[4];
            distance = getDistances();
            if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
            {
                return GameDirection.Left;
            }

            else if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
            {
                return GameDirection.Right;
            }

            else if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
            {
                return GameDirection.Up;
            }

            else if(distance[3] <= distance[0] && distance[3] <= distance[1] && distance[3] <= distance[2])
            {
                return GameDirection.Down;
            }

            return GameDirection.Down;
        }

        public double[] getDistances()
        {
            double[] list = new double[4];
            list[0] = calculateDistance(CurrentCell.X - 1, CurrentCell.Y, pacman.CurrentCell.X, pacman.CurrentCell.Y);
            list[1] = calculateDistance(CurrentCell.X + 1, CurrentCell.Y, pacman.CurrentCell.X, pacman.CurrentCell.Y);
            list[2] = calculateDistance(CurrentCell.X, CurrentCell.Y - 1, pacman.CurrentCell.X, pacman.CurrentCell.Y);
            list[3] = calculateDistance(CurrentCell.X, CurrentCell.Y + 1, pacman.CurrentCell.X, pacman.CurrentCell.Y);
            return list;
        }

        static double calculateDistance(int X, int Y, int pX, int pY)
        {
            return Math.Sqrt(Math.Pow((pX - X), 2) + Math.Pow((pY - Y), 2));
        }

    }
}
