using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class GameObject
    {
        public char[,] shape;
        public Point startingPoint;
        public Boundary premises;
        public string direction;
        public string patrolDirection;
        public int moving;

        public GameObject()
        {
            this.shape = new char[,] { { ' ', '#', '#', '#', '#', ' ', ' ', ' ', ' ', ' ' }, { '#', '#', '#', '#', '#', '#', ' ', ' ', '#', ' ' }, { '#', '#', '#', '#', '#', '#', ' ', '#', '#', '#' }, { '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ' } };
            this.startingPoint = new Point();
            this.premises = new Boundary();
            this.direction = "LeftToRight";
        }

        public GameObject(Point point, Boundary boundary, char[,] shape, string direction)
        {
            this.shape = shape;
            this.startingPoint = point;
            this.premises = boundary;
            this.direction = direction;
            patrolDirection = "Left";
            moving = 0;
        }

        public void erase()
        {
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(startingPoint.getX(), startingPoint.getY() + i);
                for (int j = 0; j < shape.GetLength(1); j++)
                {
                    Console.Write(' ');
                }
            }
        }

        public void draw()
        {
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(startingPoint.getX(), startingPoint.getY() + i);
                for (int j = 0; j < shape.GetLength(1); j++)
                {
                    Console.Write(shape[i, j]);
                }
            }
        }

        public void move()
        {
            if (direction == "LeftToRight" && startingPoint.x < premises.TopRight.x && startingPoint.y < premises.BottomRight.y)
            {
                startingPoint.x++;
            }

            else if (direction == "RightToLeft" && startingPoint.x > premises.TopLeft.x && startingPoint.y < premises.BottomLeft.y)
            {
                startingPoint.x--;
            }

            else if (direction == "Projectile")
            {
                if (startingPoint.y <= premises.BottomRight.y && startingPoint.y >= premises.TopRight.y)
                {
                    if (moving < 5)
                    {
                        startingPoint.y--;
                    }

                    else if (moving > 9 && moving < 14)
                    {
                        startingPoint.y++;
                    }
                    startingPoint.x++;
                    moving++;
                }
            }

            else if (direction == "Patrol")
            {
                if (startingPoint.x <= premises.TopRight.x && patrolDirection == "Right")
                {
                    if (startingPoint.x == premises.TopRight.x - 1)
                    {
                        patrolDirection = "Left";
                    }
                    startingPoint.x++;
                }

                else if (startingPoint.x >= premises.TopLeft.x && patrolDirection == "Left")
                {
                    if (startingPoint.x > 0)
                    {
                        startingPoint.x--;
                    }
                    if (startingPoint.x == premises.TopLeft.x + 1)
                    {
                        patrolDirection = "Right";
                    }
                }
            }

            else if (direction == "Diagonal")
            {
                if (startingPoint.x < premises.BottomRight.x && startingPoint.y < premises.BottomRight.y)
                {
                    double right = calculateDistance(startingPoint.x + 1, startingPoint.y, premises.BottomRight.x, premises.BottomRight.y);
                    double down = calculateDistance(startingPoint.x, startingPoint.y + 1, premises.BottomRight.x, premises.BottomRight.y);
                    startingPoint.x++;
                    startingPoint.y++;
                }
            }
        }

        public double calculateDistance(int X, int Y, int pX, int pY)
        {
            return Math.Sqrt(Math.Pow((pX - X), 2) + Math.Pow((pY - Y), 2));
        }
    }
}
