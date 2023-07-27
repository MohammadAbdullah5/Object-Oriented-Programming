using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.BL;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "New Text Document.txt";
            Grid mazeGrid = new Grid(24, 71, path);

            Pacman player = new Pacman(13, 9, mazeGrid);

            Ghost ghost1 = new Ghost(39, 15, 'H', "Left", 0.1F, ' ', mazeGrid);
            Ghost ghost2 = new Ghost(57, 20, 'V', "Up", 0.2F, ' ', mazeGrid);
            Ghost ghost3 = new Ghost(26, 19, 'R', "Up", 0.1F, ' ', mazeGrid);
            Ghost ghost4 = new Ghost(21, 18, 'C', "Up", 0.5F, ' ', mazeGrid);

            List<Ghost> enemies = new List<Ghost>();
            enemies.Add(ghost1);
            enemies.Add(ghost2);
            enemies.Add(ghost3);
            enemies.Add(ghost4);

            mazeGrid.draw();
            player.draw();

            bool gameRunning = true;

            while (gameRunning == true)
            {
                Thread.Sleep(90);

                player.printScore();
                player.remove();
                player.move();
                player.draw();

                foreach (Ghost g in enemies)
                {
                    g.remove();
                    g.move();
                    g.draw();
                }

                if (mazeGrid.isStoppingCondition())
                {
                    gameRunning = false;
                }
            }
            Console.ReadKey();
        }
    }
}
