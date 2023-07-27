using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game.GL
{
    public class GameGrid
    {
        public int Rows;
        public int Cols;
        public GameObject currentGameObject;
        public GameCell[,] gameCells;

        public GameGrid(string filename, int rows, int cols)
        {
            gameCells = new GameCell[cols, rows];
            this.Rows = rows;
            this.Cols = cols;
            loadGrid(filename);

        }

        public GameObject returnObject(char character)
        {
            if (character == 'p' || character == 'P')
            {
                return new GameObject(GameObjectType.PLAYER, character);
            }

            else if (character == 'g' || character == 'G')
            {
                return new GameObject(GameObjectType.ENEMY, character);
            }

            else if (character == '%' || character == '|' || character == '#')
            {
                return new GameObject(GameObjectType.WALL, character);
            }

            else if (character == '.')
            {
                return new GameObject(GameObjectType.REWARD, character);
            }

            else
            {
                return new GameObject(GameObjectType.NONE, character);
            }
        }

        private void loadGrid(string filename)
        {
            StreamReader file = new StreamReader(filename);
            string record;
            int y = 0;
            while ((record = file.ReadLine()) != null)
            {
                for (int x = 0; x < record.Count(); x++)
                {
                    GameCell cell = new GameCell(x, y);
                    gameCells[x, y] = cell;
                    gameCells[x, y].CurrentGameObject = returnObject(record[x]);
                }
                y++;
            }
            file.Close();
        }

        public GameCell getCell(int x, int y)
        {
            if (gameCells[x, y] != null)
            {
                return gameCells[x, y];
            }

            else
            {
                return null;
            }
        }
    }
}
