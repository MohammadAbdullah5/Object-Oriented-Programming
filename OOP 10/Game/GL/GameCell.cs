using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GL
{
    public class GameCell
    {
        public int X;
        public int Y;
        public GameGrid gameGrid;
        public GameObject CurrentGameObject;

        public GameCell(int x, int y, GameGrid grid)
        {
            this.X = x;
            this.Y = y;
            gameGrid = grid;
        }

        public GameCell(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public GameCell nextCell(GameDirection direction)
        {
            if(direction == GameDirection.Up)
            {
                return gameGrid.getCell(X, Y - 1);
            }

            else if(direction == GameDirection.Right)
            {
                return gameGrid.getCell(X + 1, Y);
            }

            else if (direction == GameDirection.Left)
            {
                return gameGrid.getCell(X - 1, Y);
            }

            else if (direction == GameDirection.Down)
            {
                return gameGrid.getCell(X, Y + 1);
            }

            else
            {
                return null;
            }
        }
    }


    public enum GameDirection
    {
        Left,

        Right,

        Up,

        Down
    }
}
