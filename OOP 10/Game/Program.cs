using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;
using Game.GL;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ghost> ghosts = new List<Ghost>();
            GameGrid grid = new GameGrid("maze.txt", 24, 70);
            GameCell start = new GameCell(12, 22, grid);
            GameCell startEnemy = new GameCell(5, 7, grid);
            GameCell startEnemy1 = new GameCell(5, 8, grid);
            GameCell startEnemy2 = new GameCell(10, 8, grid);
            GameCell startEnemy3 = new GameCell(15, 15, grid);
            GamePacManPlayer pacman = new GamePacManPlayer('p', start);
            VerticalGhost v = new VerticalGhost('G', startEnemy, GameDirection.Down);
            HorizontalGhost h = new HorizontalGhost('G', startEnemy1, GameDirection.Left);
            RandomGhost r = new RandomGhost('G', startEnemy2); 
            SmartGhost s = new SmartGhost('G', startEnemy3, pacman);
            ghosts.Add(v);
            ghosts.Add(h);
            ghosts.Add(r);
            ghosts.Add(s);
            printMaze(grid);
            printGameObject(pacman);


            bool gameRunning = true;
            while (gameRunning)
            {
                Thread.Sleep(90);
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    moveGameObject(pacman, GameDirection.Up);
                }

                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    moveGameObject(pacman, GameDirection.Down);
                }

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveGameObject(pacman, GameDirection.Right);
                }

                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    moveGameObject(pacman, GameDirection.Left);
                }

                move(ghosts);
            }
        }

        static void clearGameCellContent(GameCell gameCell, GameObject newGameObject)
        {
            gameCell.CurrentGameObject = newGameObject;
            Console.SetCursorPosition(gameCell.X, gameCell.Y);
            Console.Write(newGameObject.DisplayCharacter);
        }

        static void printGameObject(GameObject gameObject)
        {
            Console.SetCursorPosition(gameObject.CurrentCell.X, gameObject.CurrentCell.Y);
            Console.Write(gameObject.DisplayCharacter);

        }

        static void moveGameObject(GameObject gameObject, GameDirection direction)
        {
            GameCell nextCell = gameObject.CurrentCell.nextCell(direction);
            if (nextCell != null && nextCell.CurrentGameObject.type != GameObjectType.WALL)
            {
                nextCell.gameGrid = gameObject.CurrentCell.gameGrid;
                GameObject newGO = new GameObject(GameObjectType.NONE, ' ');
                GameCell currentCell = gameObject.CurrentCell;
                clearGameCellContent(currentCell, newGO);
                gameObject.CurrentCell = nextCell;
                printGameObject(gameObject);
            }
        }

        static void moveEnemyObject(Ghost gameObject)
        {
            GameCell nextCell = gameObject.move();
            if (nextCell != null && nextCell.CurrentGameObject.type != GameObjectType.WALL)
            {
                nextCell.gameGrid = gameObject.CurrentCell.gameGrid;
                GameObject newGO = null;
                if (nextCell.CurrentGameObject.type == GameObjectType.NONE)
                {
                    newGO = new GameObject(GameObjectType.NONE, ' ');
                }

                else if (nextCell.CurrentGameObject.type == GameObjectType.REWARD)
                {
                    newGO = new GameObject(GameObjectType.REWARD, '.');
                }
                GameCell currentCell = gameObject.CurrentCell;
                clearGameCellContent(currentCell, newGO);
                gameObject.CurrentCell = nextCell;
                printGameObject(gameObject);
            }

        }

        static void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                int abc = 0;
                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(y, x);
                    printCell(cell);
                }
            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.X, cell.Y);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }

        public static void move(List<Ghost> ghosts)
        {
            foreach (var ghost in ghosts)
            {
                moveEnemyObject(ghost);
            }
        }
    }
}