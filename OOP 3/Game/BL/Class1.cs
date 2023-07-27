using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.BL
{
    class Player
    {
        public int posX;
        public int posY;
        public int health;

        public Player()
        {
            posX = 16;
            posY = 10;
            health = 300;
        }

        public void removeRambo()
        {
            // Erases Rambo
            int a = 9;

            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(posX, posY + i);
                for (int j = 0; j < a; j++)
                {
                    Console.Write(" ");
                }
            }
        }

        public void printRambo()
        {
            // Rambo Character
            char backslash = (char)92;
            char[,] ramboChar = new char[4, 9] { { '[', '=', '=', '=', '=', '=', '=', '=', backslash }, { '|', '=', '=', '=', '=', '=', '=', '=', '/' }, { '|', '|', ' ', '>', ' ', ' ', ' ', ' ', ' ' }, { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ' } };
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(posX, posY + i);
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(ramboChar[i, j]);
                }
            }

        }
            public void printRamboHealth()
            {
                // Prints Tank Health at the left side of maze
                char heart = (char)3;
                Console.SetCursorPosition(120, 8);
                Console.ForegroundColor = ConsoleColor.Blue;

                if (health <= 300 && health > 240)
                {
                    Console.Write("Rambo: {0}{0}{0}{0}{0}", heart);
                }
                Console.SetCursorPosition(120, 8);
                if (health <= 240 && health > 180)
                {
                    Console.Write("Rambo: {0}{0}{0}{0} ", heart);
                }
                Console.SetCursorPosition(120, 8);
                if (health <= 180 && health > 120)
                {
                    Console.Write("Rambo: {0}{0}{0}  ", heart);
                }
                Console.SetCursorPosition(120, 8);
                if (health <= 120 && health > 60)
                {
                    Console.Write("Rambo: {0}{0}   ", heart);
                }
                Console.SetCursorPosition(120, 8);
                if (health <= 60 && health > 0)
                {
                    Console.Write("Rambo: {0}    ", heart);
                }
                Console.SetCursorPosition(120, 8);
                if (health <= 0)
                {
                    Console.Write("Rambo:      ");
                    printRambo();
                }
            }
    }
}
