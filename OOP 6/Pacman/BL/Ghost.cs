using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BL
{
    class Ghost
    {
        public int x;
        public int y;
        public string ghostDirection;
        public char ghostCharacter;
        public float speed;
        public char previous;
        public float changeDelta;
        Grid mazeGrid;

        public Ghost(int x, int y, char ghostCharacter, string ghostDirection, float speed, char previous, Grid mazeGrid)
        {
            this.x = x;
            this.y = y;
            this.ghostCharacter = ghostCharacter;
            this.ghostDirection = ghostDirection;
            this.speed = speed;
            this.previous = previous;
            this.mazeGrid = mazeGrid;
            mazeGrid.maze[x, y].value = ghostCharacter;
        }

        public void setDirection(string direction)
        {
            this.ghostDirection = direction;
        }

        public string getDirection()
        {
            return ghostDirection;
        }

        public void remove()
        {
            mazeGrid.maze[x, y].value = ' ';
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }

        public void changeDeltaSpeed()
        {
            changeDelta = changeDelta + speed;
        }

        public float getDelta()
        {
            return changeDelta;
        }

        public void setDeltaToZero()
        {
            changeDelta = 0;
        }

        public void move()
        {
            changeDeltaSpeed();

            if (Math.Floor(getDelta()) == 1)
            {
                if (ghostCharacter == 'H')
                {
                    moveHorizontal();
                }

                else if (ghostCharacter == 'V')
                {
                    moveVertical();
                }

                else if (ghostCharacter == 'R')
                {
                    moveSmart();
                }

                else if (ghostCharacter == 'C')
                {
                    moveRandom();
                }
                setDeltaToZero();
            }
        }

        public void moveHorizontal()
        {
            if (getDirection() == "Right")
            {
                if (mazeGrid.maze[x + 1, y].value == ' ')
                {
                    mazeGrid.maze[x + 1, y].value = ghostCharacter;
                    x++;
                }

                else
                {
                    ghostDirection = "Left";
                }
            }

            if (getDirection() == "Left")
            {
                if (mazeGrid.maze[x - 1, y].value == ' ')
                {
                    mazeGrid.maze[x - 1, y].value = ghostCharacter;
                    x--;
                }

                else
                {
                    ghostDirection = "Right";
                }
            }
        }

        public void draw()
        {
            mazeGrid.maze[x, y].value = ghostCharacter;
            Console.SetCursorPosition(x, y);
            Console.Write(ghostCharacter);
        }

        public void moveVertical()
        {
            if (getDirection() == "Up")
            {
                if (mazeGrid.maze[x, y - 1].value == ' ')
                {
                    y -= 1;
                }

                else
                {
                    ghostDirection = "Down";
                }
            }

            if (getDirection() == "Down")
            {
                if (mazeGrid.maze[x, y + 1].value == ' ')
                {
                    y += 1;
                }

                else
                {
                    ghostDirection = "Up";
                }
            }
        }

        public void moveSmart()
        {
            Cell pacmanLocation = mazeGrid.findPacman();
            Cell current = new Cell(ghostCharacter, x, y);
            int pacmanLocation1 = pacmanLocation.x;
            int pacmanLocation2 = pacmanLocation.y;
            pacmanLocation1 += 1;
            Cell cell1 = new Cell(' ', pacmanLocation1, pacmanLocation2);
            double right = calculateDistance(current, cell1);
            pacmanLocation1 -= 2;
            Cell cell2 = new Cell(' ', pacmanLocation1, pacmanLocation2);
            double left = calculateDistance(current, cell2);
            pacmanLocation1 += 1;
            pacmanLocation2 -= 1;
            Cell cell3 = new Cell(' ', pacmanLocation1, pacmanLocation2);
            double up = calculateDistance(current, cell3);
            pacmanLocation2 += 2;
            Cell cell4 = new Cell(' ', pacmanLocation1, pacmanLocation2);
            double down = calculateDistance(current, cell4);

            if (right <= down && right <= up && right <= left)
            {
                if (mazeGrid.maze[x + 1, y].value == ' ')
                {
                    x++;
                }
            }

            else if (left <= down && left <= up && left <= right)
            {
                if (mazeGrid.maze[x + 1, y].value == ' ')
                {
                    x--;
                }
            }

            else if (up <= down && up <= left && up <= right)
            {
                if (mazeGrid.maze[x + 1, y].value == ' ')
                {
                    y--;
                }
            }

            if (down <= right && down <= up && down <= left)
            {
                if (mazeGrid.maze[x + 1, y].value == ' ')
                {
                    y++;
                }
            }

        }

        public void moveRandom()
        {
            int random = getRandom();
            if (random % 4 == 0)
            {
                if (mazeGrid.maze[x + 1, y].value == ' ')
                {
                    x += 1;
                }
            }

            else if (random % 4 == 1)
            {
                if (mazeGrid.maze[x - 1, y].value == ' ')
                {
                    x--;
                }
            }

            else if (random % 4 == 2)
            {
                if (mazeGrid.maze[x, y + 1].value == ' ')
                {
                    y++;
                }
            }

            else if (random % 4 == 3)
            {
                if (mazeGrid.maze[x, y - 1].value == ' ')
                {
                    y--;
                }
            }
        }

        public char getCharacter()
        {
            return ghostCharacter;
        }

        public int getRandom()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next();
            return randomNumber;
        }

        public double calculateDistance(Cell current, Cell pacmanLocation)
        {
            return Math.Sqrt(Math.Pow((pacmanLocation.x - current.x), 2) + Math.Pow((pacmanLocation.y - current.y), 2));
        }
    }
}
