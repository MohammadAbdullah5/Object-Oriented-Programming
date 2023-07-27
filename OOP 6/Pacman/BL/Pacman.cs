using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;

namespace ConsoleApp1.BL
{
    class Pacman
    {
        public int x;
        public int y;
        public int score;
        public Grid mazeGrid;

        public Pacman(int x, int y, Grid mazeGrid)
        {
            this.x = x;
            this.y = y;
            this.score = 0;
            this.mazeGrid = mazeGrid;
            mazeGrid.maze[x, y].value = 'P';
        }

        public void remove()
        {
            mazeGrid.maze[x, y].value = ' ';
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

        public void printScore()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("Score: " + score);
        }

        public void moveLeft(Cell current, Cell next)
        {
            if(next.value == ' ')
            {
                mazeGrid.maze[current.x, current.y].value = ' ';
                mazeGrid.maze[next.x, next.y].value = 'P';
                x--;
            }
        }

        public void moveRight(Cell current, Cell next)
        {
            if (next.value == ' ')
            {
                mazeGrid.maze[current.x, current.y].value = ' ';
                mazeGrid.maze[next.x, next.y].value = 'P';
                x++;
            }
        }

        public void moveUp(Cell current, Cell next)
        {
            if (next.value == ' ')
            {
                mazeGrid.maze[current.x, current.y].value = ' ';
                mazeGrid.maze[next.x, next.y].value = 'P';
                y--;
            }
        }

        public void moveDown(Cell current, Cell next)
        {
            if (next.value == ' ')
            {
                mazeGrid.maze[current.x, current.y].value = ' ';
                mazeGrid.maze[next.x, next.y].value = 'P';
                y++;
            }
        }

        public void move()
        {
            if(Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                x--;
            }

            else if(Keyboard.IsKeyPressed(Key.RightArrow))
            {
                x++;
            }

            else if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                y--;
            }

            else if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                y++;
            }
        }

        public void draw()
        {
            if (mazeGrid.maze[x, y] != null)
            {
                mazeGrid.maze[x, y].value = 'P';
                Console.SetCursorPosition(x, y);
                Console.Write("P");
            }
        }
    }
}
