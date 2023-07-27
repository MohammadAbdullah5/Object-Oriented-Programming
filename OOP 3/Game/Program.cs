using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using EZInput;

namespace ConsoleApp2.BL
{
    class Program
    {

        static void Main(string[] args)
        {
            string option = "7";
            bool file = true;
            Console.Clear();
            welcome();
            while (file == true)
            {
                Console.Clear();
                header();
                option = mainMenu();
                // Takes user to the game
                if (option == "1")
                {
                    gameInterface();
                }
                // Shows options to the user
                if (option == "2")
                {
                    optionsInterface();
                }
                // Shows Credits
                if (option == "3")
                {
                    creditsInterface();
                }
                // Terminates Program
                if (option == "4")
                {
                    file = false;
                }
            }
        }

        static void header()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("                       ########   ########   ##         ##   ########   ########  ");
            Console.WriteLine("                       #  ##  #   ##    ##   ##         ##   ##         ##    ##  ");
            Console.WriteLine("                          ##      ##    ##   ##         ##   ########   ########  ");
            Console.WriteLine("                          ##      ##    ##   ##    #    ##   ##         ##   ##   ");
            Console.WriteLine("                          ##      ##    ##   ##   ###   ##   ##         ##    ##  ");
            Console.WriteLine("                          ##      ########    ###########    ########   ##     ## ");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("                         ##        ##        ####         ########   ########");
            Console.WriteLine("                         ##        ##       ##  ##        ##    ##   ##      ");
            Console.WriteLine("                         ##        ##      ##    ##       ##    ##   ##      ");
            Console.WriteLine("                         ##        ##     ##      ##      ########   ########");
            Console.WriteLine("                         ##    #   ##    ############     ##  ##           ##");
            Console.WriteLine("                          ##  ### ##    ##          ##    ##   ##          ##");
            Console.WriteLine("                           ########    ##            ##   ##    ##   ########");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        static void welcome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("                   __      __         .__                                    ");
            Console.WriteLine("                  /  \\    /  \\  ____  |  |    ____    ____    _____    ____  ");
            Console.WriteLine("                  \\   \\/\\/   /_/ __ \\ |  |  _/ ___\\  /  _ \\  /     \\ _/ __ \\");
            Console.WriteLine("                   \\        / \\  ___/ |  |__\\  \\___ (  <_> )|  Y Y  \\\\  ___/ ");
            Console.WriteLine("                    \\__/\\  /   \\___  >|____/ \\___  > \\____/ |__|_|  / \\___  >");
            Console.WriteLine("                         \\/        \\/            \\/               \\/      \\/");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine("                                      -|             |-                                 ");
            Console.WriteLine("                  -|                  [-_-_-_-_-_-_-_-]                  |-             ");
            Console.WriteLine("                  [-_-_-_-_-]          |             |          [-_-_-_-_-]             ");
            Console.WriteLine("                   | o   o |           [  0   0   0  ]           | o   o |              ");
            Console.WriteLine("                    |     |    -|       |           |       |-    |     |               ");
            Console.WriteLine("                    |     |_-___-___-___-|         |-___-___-___-_|     |               ");
            Console.WriteLine("                    |  o  ]              [    0    ]              [  o  |               ");
            Console.WriteLine("                    |     ]   o   o   o  [ _______ ]  o   o   o   [     | ----__________");
            Console.WriteLine("         _____----- |     ]              [ ||||||| ]              [     |               ");
            Console.WriteLine("                    |     ]              [ ||||||| ]              [     |               ");
            Console.WriteLine("                _-_-|_____]--------------[_|||||||_]--------------[_____|-_-_           ");
            Console.WriteLine("               ( (__________------------_____________-------------_________) )          ");

            string a;
            Console.Write("Press any key to continue...");
            a = Console.ReadLine();
        }

        static string mainMenu()
        {
            // Prints Main Menu

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("         MENU      ");
            Console.WriteLine("         ----------");
            Console.WriteLine("         1. Start  ");
            Console.WriteLine("         2. Options");
            Console.WriteLine("         3. Credits");
            Console.WriteLine("         4. Exit   ");
            string option;
            Console.Write("         Enter your option: ");
            option = Console.ReadLine(); // Takes an option from user
            return option;
        }

        static string optionSubMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;

            // Prints Options Menu
            Console.WriteLine("         OPTIONS        ");
            Console.WriteLine("         ----------     ");
            Console.WriteLine("         1. Keys        ");
            Console.WriteLine("         2. Instructions");
            Console.WriteLine("         3. Exit        ");
            string option;
            Console.Write("         Enter your option: ");
            option = Console.ReadLine(); // Takes an option from user
            return option;
        }

        static void optionsInterface()
        {
            string option = "1";
            while (option != "3")
            {
                Console.Clear();
                header();                 // Prints header
                option = optionSubMenu(); // Takes option from the user
                                          // Shows keys for the game
                if (option == "1")
                {
                    showKeys();
                }

                // Instructions for the user
                if (option == "2")
                {
                    showInstructions();
                }
            }
        }

        static void creditsInterface()
        {
            Console.Clear();
            header();
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(20, 19);
            Thread.Sleep(90);
            Console.WriteLine("1. Graphics: Mohammad Abdullah");
            Console.SetCursorPosition(20, 20);
            Thread.Sleep(90);
            Console.WriteLine("2. Sound: Mr. Mohammad Abdullah ");
            Console.SetCursorPosition(20, 21);
            Thread.Sleep(90);
            Console.WriteLine("3. Game Development: Dr. Mohammad Abdullah");
            Console.SetCursorPosition(20, 22);
            Thread.Sleep(90);
            Console.WriteLine("4. Produced by: Sir Mohammad Abdullah");
            Console.SetCursorPosition(20, 23);
            Thread.Sleep(90);
            Console.WriteLine("5. Sponsored by: Mohammad Abdullah Group of Companies.");
            Console.SetCursorPosition(20, 24);
            Thread.Sleep(90);
            Console.Write("Press any key to continue...");
            // Any string to continue the game later
            Console.ReadLine();
        }

        static void showInstructions()
        {
            Console.Clear();
            header();
            // Shows Instructions
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("         1. The player can move in all the directions.          ");
            Console.WriteLine("         2. The player will have to kill all the enemies to win.");
            Console.WriteLine("         Press any key to exit...                               ");
            // Any string to continue the game later
            Console.ReadLine();
        }

        static void showKeys()
        {
            Console.Clear();
            header();
            Console.ForegroundColor = ConsoleColor.White;
            // Shows Keys
            Console.WriteLine("   Up        Key Up    ");
            Console.WriteLine("  Down       Key Down  ");
            Console.WriteLine("  Left       Key Left  ");
            Console.WriteLine("  Right      Key Right ");
            Console.WriteLine("  Fire       Key Space ");
            Console.WriteLine("  Exit       Key Escape");
            Console.WriteLine("Enter any key to exit...");
            // Any string to continue the game later
            Console.ReadLine();
        }

        static void readMaze(char[,] maze)
        {
            int idx = 0;
            int x;
            string path = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Game\\Maze.txt";
            StreamReader file = new StreamReader(path, Encoding.UTF8);
            string line;
            while (idx < 30)
            {
                x = 0;
                line = file.ReadLine();
                while (line[x] != ',')
                {
                    char c = line[x];
                    maze[idx, x] = c;
                    x++;
                }
                idx++;
            }
            file.Close();
        }

        static void printMaze(char[,] maze)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            for (int x = 0; x < 30; x++)
            {
                for (int y = 0; y < 117; y++)
                {
                    Console.Write(maze[x, y]);
                }
                Console.WriteLine();
            }
        }

        static void printTank(int tankX, int tankY)
        {
            // Tank Characters
            char box = (char)219;
            char fire = (char)170;
            char[,] tank = new char[3, 5] { { '<', '-', '-', '-', fire }, { box, box, box, box, box }, { 'O', 'O', 'O', 'O', 'O' } };
            // Prints Tank
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(tankX, tankY + i); // Goes below to print next line
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(tank[i, j]);
                }
            }
        }

        static void eraseTank(int tankX, int tankY)
        {
            // Erase the tank
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(tankX, tankY + i); // Goes below to print next line
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(" ");
                }
            }
        }

        static void printJetPlane(int jetPlaneX, int jetPlaneY)
        {
            char backslash = (char)92;
            char[,] jetPlane = new char[5, 6] { { ' ', ' ', ' ', ' ', '/', '|' }, { ' ', '/', backslash, '/', ' ', '|' }, { '<', '[', ' ', ' ', ' ', '|' }, { ' ', backslash, '/', backslash, ' ', '|' }, { ' ', ' ', ' ', ' ', backslash, '|' } };
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(jetPlaneX, jetPlaneY + i);
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(jetPlane[i, j]);
                }
            }
        }

        static void eraseJetPlane(int jetPlaneX, int jetPlaneY)
        {
            // Erases Jet Plane
            int a = 6;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(jetPlaneX, jetPlaneY + i);
                for (int j = 0; j < a; j++)
                {
                    Console.Write(" ");
                }
            }

        }

        static void printInfantry(int infantryX, int infantryY)
        {
            // Infantry Character
            char backslash = (char)92;
            char box = (char)219;
            char fire = (char)170;
            char[,] infantry = new char[3, 11]{
                { ' ', ' ', ' ', ' ', ' ', '(', '-', ' ', '-', ')', ' '},
                            { '<', '-', '-', fire, backslash, box, box, box, box, box, '/'},
                            { ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' '}
            };
            Console.ForegroundColor = ConsoleColor.Red;


            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(infantryX, infantryY + i);
                for (int j = 0; j < 11; j++)
                {
                    Console.Write(infantry[i, j]);
                }
            }
        }

        static void eraseInfantry(int infantryX, int infantryY)
        {
            int a = 11;

            // Erasing Functionality for infantry
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(infantryX, infantryY + i);
                for (int j = 0; j < a; j++)
                {
                    Console.Write(" ");
                }
            }
        }

        static void printBala(int balaX, int balaY)
        {
            // Bala Characters
            char backslash = (char)92;
            char[,] bala = new char[4, 9]  {
                { '/', '=', '=', '=', '=', '=', '=', '=', ']'},
                { backslash, '=', '=', '=', '=', '=', '=', '=', '|'},
                { ' ', ' ', ' ', ' ', ' ', '<', ' ', '|', '|'},
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '|'}
                };

            Console.ForegroundColor = ConsoleColor.DarkRed;

            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(balaX, balaY + i); // Goes to next y-coordinate to print next row
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(bala[i, j]);
                }
            }
        }


        static void addBalaToMaze(int balaX, int balaY, char[,] maze)
        {
            // Bala Characters
            char backslash = (char)92;
            char[,] bala = new char[4, 9]  {
                { '/', '=', '=', '=', '=', '=', '=', '=', ']'},
                { backslash, '=', '=', '=', '=', '=', '=', '=', '|'},
                { ' ', ' ', ' ', ' ', ' ', '<', ' ', '|', '|'},
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '|'}
                };
            int cols;
            int rows = balaY;
            for (int i = 0; i < 4; i++)
            {
                cols = balaX;
                for (int j = 0; j < 9; j++)
                {
                    maze[rows, cols] = bala[i, j];
                    cols++;
                }
                rows++;
            }
        }

        static void removeBalaFromMaze(int balaX, int balaY, char[,] maze)
        {
            int cols;
            int rows = balaY;
            for (int i = 0; i < 4; i++)
            {
                cols = balaX;
                for (int j = 0; j < 9; j++)
                {
                    maze[rows, cols] = ' ';
                    cols++;
                }
                rows++;
            }
        }

        static void eraseBala(int balaX, int balaY)
        {
            int a = 9;
            // Erases Bala
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(balaX, balaY + i); // Goes to next y-coordinate to print next row
                for (int j = 0; j < a; j++)
                {
                    Console.Write(" ");
                }
            }
        }

        static void gameOver()
        {
            // Game Over is printed
            Console.Clear();
            Console.SetCursorPosition(40, 10);
            Console.Write("       *********      ***      **    **  *********       ");
            Console.SetCursorPosition(40, 11);
            Console.Write("       *             ** **     * *  * *  *               ");
            Console.SetCursorPosition(40, 12);
            Console.Write("       *    ****    *******    *  **  *  ******          ");
            Console.SetCursorPosition(40, 13);
            Console.Write("       *       *   **     **   *      *  *               ");
            Console.SetCursorPosition(40, 14);
            Console.Write("       *********  **       **  *      *  *********       ");
            Console.SetCursorPosition(40, 15);
            Console.Write("       *********  **       **  *********  *******        ");
            Console.SetCursorPosition(40, 16);
            Console.Write("       *       *   **     **   *         *       *       ");
            Console.SetCursorPosition(40, 17);
            Console.Write("       *       *    **   **    ******    ********        ");
            Console.SetCursorPosition(40, 18);
            Console.Write("       *       *     ** **     *         *  **           ");
            Console.SetCursorPosition(40, 19);
            Console.Write("       *********      **       ********* *     **        ");
            Console.SetCursorPosition(40, 20);
            Console.WriteLine("       Enter any key to exit.");
            Console.ReadLine();
        }

        static void youWon()
        {
            // Prints Congrats
            Console.Clear();
            Console.SetCursorPosition(40, 10);
            Console.Write("       *********  *********   ***     *  *********   *******       ***      **********  ********* ");
            Console.SetCursorPosition(40, 11);
            Console.Write("       *          *       *   *  *    *  *          *       *     ** **         **      **        ");
            Console.SetCursorPosition(40, 12);
            Console.Write("       *          *       *   *   *   *  *   *****  *********    *******        **      ********* ");
            Console.SetCursorPosition(40, 13);
            Console.Write("       *          *       *   *    *  *  *       *  *  **       **     **       **             ** ");
            Console.SetCursorPosition(40, 14);
            Console.Write("       *********  *********   *     ***  *********  *     **   **       **      **      ********* ");
            Console.SetCursorPosition(40, 16);
            Console.WriteLine("       Enter 0 to exit.");
            Console.ReadLine();
        }

        static void nextLevel(char[,] maze)
        {
            // Prints NExt Level
            Console.Clear();
            //gotoxy(0, 5);
            Console.WriteLine("                 ###     ##  ########  ##    ##  ########         ");
            Console.WriteLine("                 ## ##   ##  ##         ##  ##      ##            ");
            Console.WriteLine("                 ##  ##  ##  #####        ##        ##            ");
            Console.WriteLine("                 ##   ## ##  ##         ##  ##      ##            ");
            Console.WriteLine("                 ##     ###  ########  ##    ##     ##            ");
            Console.WriteLine("                                                                  ");
            Console.WriteLine("          ##          ########  ##       ##  ########  ##         ");
            Console.WriteLine("          ##          ##         ##     ##   ##        ##         ");
            Console.WriteLine("          ##          #####       ##   ##    #####     ##         ");
            Console.WriteLine("          ##          ##           ## ##     ##        ##         ");
            Console.WriteLine("          ##########  ########      ###      ########  ########## ");
            Console.WriteLine("          Enter any key to exit....");
            string anykey;
            anykey = Console.ReadLine();
            Console.Clear();
            printMaze(maze);
        }

        static void gameInterface()
        {
            // Reinitiate all the valuse so the game could run the same way it started

            int healthTimer = 0;
            int smartTimer = 0;
            int level = 1;

            Player rambo = new Player();

            Enemy infantry = new Enemy(60, 15, 5, "Right");

            Enemy tank = new Enemy(90, 7, 10, "Up");

            Enemy jetPlane = new Enemy(90, 7, 15, "Up");

            Enemy bala = new Enemy(60, 15, 20, "Up");

            int enemy = 4;
            int enemyFireDamage = 1;
            int slow = 0;

            List<Bullets> playerBullets = new List<Bullets>();
            List<Bullets> enemyBullets = new List<Bullets>();

            int score = 0;
            int timer = 0;
            int pillX = 70;
            int pillY = 20;
            // boolean values to check collision
            bool gameRunning = true;
            Console.Clear();

            char[,] maze = new char[30, 150];
            readMaze(maze);
            printMaze(maze);
            rambo.printRambo();
            printInfantry(infantry.posX, infantry.posY);
            rambo.printRamboHealth(); // Prints Rambos Health
            while (gameRunning == true)
            {
                if (rambo.health > 0 && bala.health >= 0)
                {
                    if (Keyboard.IsKeyPressed(Key.LeftArrow))
                    {
                        moveRamboLeft(maze, rambo); // Moves Player to the Left
                    }

                    if (Keyboard.IsKeyPressed(Key.RightArrow))
                    {
                        moveRamboRight(maze, rambo); // Moves Player to the Right
                    }

                    if (Keyboard.IsKeyPressed(Key.UpArrow))
                    {
                        moveRamboUp(maze, rambo); // Moves Player to the Up
                    }

                    if (Keyboard.IsKeyPressed(Key.DownArrow))
                    {
                        moveRamboDown(maze, rambo); // Moves Player to the Down
                    }

                    if (Keyboard.IsKeyPressed(Key.Space))
                    {
                        generateBullet(rambo.posX, rambo.posY, maze, playerBullets); // Fires
                    }

                    if (Keyboard.IsKeyPressed(Key.Escape))
                    {
                        gameRunning = false; // Quits the game
                    }

                    if (enemy > 0)
                    {
                        if (enemy == 4) // Infantry
                        {
                            enemyFireDamage = 1;
                            if (slow == 2)
                            {
                                moveInfantry(infantry, maze);
                                slow = 0;
                            }
                            slow++;
                            printInfantryHealth(infantry, maze);
                            bulletCollisionWithInfantry(infantry, ref score, maze, playerBullets);
                            if (timer == 16)
                            {
                                generateEnemyBullet(infantry.posX, infantry.posY + 1, maze, enemyBullets);
                                timer = 0;
                            }
                            timer++;

                            if (infantry.health <= 0)
                            {
                                eraseInfantry(infantry.posX, infantry.posY);
                                removeInfantryFromMaze(maze, infantry.posX, infantry.posY);
                                enemy--;
                                timer = 0;
                            }
                        }

                        if (enemy == 3) // Tanks
                        {
                            enemyFireDamage = 2;
                            printTank(tank.posX, tank.posY);
                            moveTank(tank, maze);
                            bulletCollisionWithTank(tank, ref score, playerBullets);
                            printTankHealth(tank, maze);
                            if (timer == 12)
                            {
                                generateEnemyBullet(tank.posX, tank.posY, maze, enemyBullets);
                                timer = 0;
                            }

                            timer++;
                            if (tank.health <= 0)
                            {
                                enemy--;
                                timer = 0;
                                eraseTank(tank.posX, tank.posY);
                                removeTankFromMaze(maze, tank.posX, tank.posY);
                            }
                        }

                        if (enemy == 2) // Jet Plane
                        {
                            enemyFireDamage = 3;
                            moveJetPlane(jetPlane, maze);
                            bulletCollisionWithJetPlane(playerBullets, jetPlane, ref score);
                            printJetPlaneHealth(jetPlane, maze);
                            if (timer == 8)
                            {
                                generateEnemyBullet(jetPlane.posX - 1, jetPlane.posY + 2, maze, enemyBullets);
                                timer = 0;
                            }

                            timer++;
                            if (jetPlane.health <= 0)
                            {
                                enemy--;
                                timer = 0;
                                eraseJetPlane(jetPlane.posX, jetPlane.posY);
                                removeJetPlaneFromMaze(maze, jetPlane.posX, jetPlane.posY);
                            }
                        }
                        if (enemy == 1) // Final Enemy
                        {
                            if (level == 1)
                            {
                                nextLevel(maze);
                                level = 0;
                            }
                            enemyFireDamage = 4;
                            moveBalaRandom(maze, bala);
                            bulletCollisionWithBala(bala, ref score, playerBullets);
                            printBalaHealth(bala, maze);
                            if (smartTimer == 0)
                            {
                                moveBalaSmart(bala, rambo, maze);
                                smartTimer = 0;
                            }
                            smartTimer++;
                            if (timer == 4)
                            {
                                generateEnemyBullet(bala.posX - 1, bala.posY, maze, enemyBullets);
                                timer = 0;
                            }
                            timer++;
                            if (bala.health <= 0)
                            {
                                enemy--;
                                removeBalaFromMaze(bala.posX, bala.posY, maze);
                                timer = 0;
                            }
                        }
                    }
                    // Health Pill Comes into the game
                    if (healthTimer == 50)
                    {
                        healthPill(rambo, pillX, pillY);
                        healthTimer = 0;
                    }
                    bulletCollisionWithTower(maze, rambo, enemyFireDamage, enemyBullets);
                    moveBullet(maze, playerBullets);
                    moveEnemyBullet(maze, enemyBullets);
                    printScore(score);
                    rambo.printRamboHealth();
                    // Checking Collisions
                    bool collisionPlayerRight = playerCollisionWithEnemyRight(maze, rambo.posX, rambo.posY);
                    bool collisionPlayerLeft = playerCollisionWithEnemyLeft(maze, rambo.posX, rambo.posY);
                    bool collisionPlayerUp = playerCollisionWithEnemyUp(maze, rambo.posX, rambo.posY);
                    bool collisionPlayerDown = playerCollisionWithEnemyDown(maze, rambo.posX, rambo.posY);
                    if ((collisionPlayerLeft == true) || (collisionPlayerRight == true) || (collisionPlayerUp == true) || (collisionPlayerDown == true))
                    {
                        gameOver();
                        gameRunning = false;
                    }

                    // Checking if the player has lost
                    if (rambo.health <= 0)
                    {
                        gameOver();
                        gameRunning = false;
                    }
                    // Checking if the player has Won
                    if (bala.health <= 0)
                    {
                        youWon();
                        gameRunning = false;
                    }

                    // Timer for Increasing health system
                    healthTimer++;
                    Thread.Sleep(30);

                }
            }
        }

        static void printScore(int score)
        {
            Console.SetCursorPosition(120, 13);
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Score: " + score);
        }

        static void moveRamboLeft(char[,] maze, Player rambo)
        {
            const char heart = (char)3;
            if (maze[rambo.posY, rambo.posX - 1] == ' ' || maze[rambo.posY, rambo.posX - 1] == heart)
            {
                rambo.removeRambo();
                removeRamboFromMaze(maze, rambo.posX, rambo.posY);
                rambo.posX--;
                rambo.printRambo();
                addRambotoMaze(maze, rambo.posX, rambo.posY);
            }
        }

        static void moveRamboRight(char[,] maze, Player rambo)
        {
            const char heart = (char)3;
            if (maze[rambo.posY, rambo.posX + 10] == ' ' || maze[rambo.posY, rambo.posX + 10] == heart)
            {
                rambo.removeRambo();
                removeRamboFromMaze(maze, rambo.posX, rambo.posY);
                rambo.posX++;
                rambo.printRambo();
                addRambotoMaze(maze, rambo.posX, rambo.posY);
            }
        }

        static void moveRamboUp(char[,] maze, Player rambo)
        {
            char heart = (char)3;
            if (maze[rambo.posY - 1, rambo.posX] == ' ' || maze[rambo.posY - 1, rambo.posX] == heart)
            {
                rambo.removeRambo();
                removeRamboFromMaze(maze, rambo.posX, rambo.posY);
                rambo.posY--;
                rambo.printRambo();
                addRambotoMaze(maze, rambo.posX, rambo.posY);
            }
        }

        static void moveRamboDown(char[,] maze, Player rambo)
        {
            char heart = (char)3;
            if (maze[rambo.posY + 4, rambo.posX] == ' ' || maze[rambo.posY + 4, rambo.posX] == heart)
            {
                rambo.removeRambo();
                removeRamboFromMaze(maze, rambo.posX, rambo.posY);
                rambo.posY++;
                rambo.printRambo();
                addRambotoMaze(maze, rambo.posX, rambo.posY);
            }
        }

        static void generateBullet(int ramboX, int ramboY, char[,] maze, List<Bullets> PlayerBullets)
        {
            // Generates Player's Bullet
            Bullets playerBullet = new Bullets();
            playerBullet.posX = ramboX + 10;
            playerBullet.posY = ramboY;
            playerBullet.isActive = true;
            Console.SetCursorPosition(ramboX + 10, ramboY);
            Console.Write(".");
            maze[ramboY, ramboX + 10] = '.';
            PlayerBullets.Add(playerBullet);
        }

        static void generateEnemyBullet(int x, int y, char[,] maze, List<Bullets> enemyBullets)
        {
            // Generates Bullet for Enemies
            Bullets bullet = new Bullets();
            bullet.posX = x - 1;
            bullet.posY = y;
            bullet.isActive = true;
            Console.SetCursorPosition(x - 1, y);
            Console.Write("~");
            maze[y, x - 1] = '~';
            enemyBullets.Add(bullet);
        }

        static void moveInfantry(Enemy infantry, char[,] maze)
        {
            // Infantry Moving Functionality
            if (infantry.direction == "Right")
            {
                char next = maze[infantry.posY, infantry.posX + 14];
                if (next == ' ')
                {
                    eraseInfantry(infantry.posX, infantry.posY);
                    removeInfantryFromMaze(maze, infantry.posX, infantry.posY);
                    infantry.posX++;
                    printInfantry(infantry.posX, infantry.posY);
                    addInfantryToMaze(maze, infantry.posX, infantry.posY);
                }
                if (next == '*')
                {
                    infantry.direction = "Left";
                }
            }

            if (infantry.direction == "Left")
            {
                char next = maze[infantry.posY, infantry.posX - 1];
                if (next == ' ')
                {
                    eraseInfantry(infantry.posX, infantry.posY);
                    removeInfantryFromMaze(maze, infantry.posX, infantry.posY);
                    infantry.posX--;
                    printInfantry(infantry.posX, infantry.posY);
                    addInfantryToMaze(maze, infantry.posX, infantry.posY);
                }
                if (next == '!')
                {
                    infantry.direction = "Right";
                }
            }
        }

        static void printInfantryHealth(Enemy infantry, char[,] maze)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            // Prints Tank Heealth at the left side of maze
            char heart = (char)3;
            Console.SetCursorPosition(120, 3);
            if (infantry.health == 5)
            {
                Console.Write("Infantry: {0}{0}{0}{0}{0}", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (infantry.health == 4)
            {
                Console.Write("Infantry: {0}{0}{0}{0} ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (infantry.health == 3)
            {
                Console.Write("Infantry: {0}{0}{0}  ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (infantry.health == 2)
            {
                Console.Write("Infantry: {0}{0}   ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (infantry.health == 1)
            {
                Console.Write("Infantry: {0}    ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (infantry.health <= 0)
            {
                Console.Write("Infantry:      ");
                Console.SetCursorPosition(infantry.posX, infantry.posY);
                eraseInfantry(infantry.posX, infantry.posY);
                removeInfantryFromMaze(maze, infantry.posX, infantry.posY);
            }
        }

        static void moveEnemyBullet(char[,] maze, List<Bullets> bullets)
        {
            // Moves Active Bullets of Enemies
            for (int i = 0; i < bullets.Count; i++)
            {
                if (bullets[i].isActive == true)
                {
                    char next = maze[bullets[i].posY, bullets[i].posX - 1];

                    if (next == ' ')
                    {
                        eraseEnemyBullet(bullets[i].posX, bullets[i].posY, maze);
                        bullets[i].posX = bullets[i].posX - 1;
                        printEnemyBullet(bullets[i].posX, bullets[i].posY, maze);
                    }
                    else if (next != ' ')
                    {
                        eraseEnemyBullet(bullets[i].posX, bullets[i].posY, maze);
                        makeEnemyBulletInactive(i, bullets);
                    }
                }
            }
        }

        static void makeEnemyBulletInactive(int idx, List<Bullets> bullets)
        {
            // Makes Enemy Bullet Inactive
            bullets[idx].isActive = false;
            bullets.RemoveAt(idx);
        }

        static void eraseEnemyBullet(int x, int y, char[,] maze)
        {
            // Erases Bullet
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            maze[y, x] = ' ';
        }

        static void printEnemyBullet(int x, int y, char[,] maze)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.Write("~");
            maze[y, x] = '~';
        }

        static void moveBullet(char[,] maze, List<Bullets> bullets)
        {
            // Moving functionality for Player's Bullet
            for (int i = 0; i < bullets.Count; i++)
            {
                if (bullets[i].isActive == true)
                {
                    char next = maze[bullets[i].posY, bullets[i].posX + 1];
                    if (next != ' ')
                    {
                        eraseBullet(bullets[i].posX, bullets[i].posY, maze);
                        makeBulletInactive(i, bullets);
                    }

                    else
                    {
                        eraseBullet(bullets[i].posX, bullets[i].posY, maze);
                        bullets[i].posX = bullets[i].posX + 1;
                        printBullet(bullets[i].posX, bullets[i].posY, maze);
                    }
                }
            }
        }

        static void makeBulletInactive(int idx, List<Bullets> bullets)
        {
            // Makes Enemy Bullet Inactive
            bullets[idx].isActive = false;
        }

        static void eraseBullet(int x, int y, char[,] maze)
        {
            // Erases Bullet
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            maze[y, x] = ' ';
        }

        static void printBullet(int x, int y, char[,] maze)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(".");
            maze[y, x] = '.';
        }

        static void printRamboHealth(Player Rambo)
        {
            // Prints Tank Heealth at the left side of maze
            char heart = (char)3;
            Console.SetCursorPosition(120, 8);
            Console.ForegroundColor = ConsoleColor.Blue;

            if (Rambo.health <= 300 && Rambo.health > 240)
            {
                Console.Write("Rambo: {0}{0}{0}{0}{0}", heart);
            }
            Console.SetCursorPosition(120, 8);
            if (Rambo.health <= 240 && Rambo.health > 180)
            {
                Console.Write("Rambo: {0}{0}{0}{0} ", heart);
            }
            Console.SetCursorPosition(120, 8);
            if (Rambo.health <= 180 && Rambo.health > 120)
            {
                Console.Write("Rambo: {0}{0}{0}  ", heart);
            }
            Console.SetCursorPosition(120, 8);
            if (Rambo.health <= 120 && Rambo.health > 60)
            {
                Console.Write("Rambo: {0}{0}   ", heart);
            }
            Console.SetCursorPosition(120, 8);
            if (Rambo.health <= 60 && Rambo.health > 0)
            {
                Console.Write("Rambo: {0}    ", heart);
            }
            Console.SetCursorPosition(120, 8);
            if (Rambo.health <= 0)
            {
                Console.Write("Rambo:      ");
                Rambo.printRambo();

            }
        }

        static void bulletCollisionWithTower(char[,] maze, Player rambo, int enemyFireDamage, List<Bullets> enemyBullet)
        {
            // Detects Bullet Collision With Tower and reduces Health
            for (int x = 0; x < enemyBullet.Count; x++)
            {
                if (enemyBullet[x].isActive == true)
                {
                    char next = maze[enemyBullet[x].posY, enemyBullet[x].posX - 1];
                    if (next == '!')
                    {
                        rambo.health -= enemyFireDamage;
                    }
                }
            }
        }

        static void bulletCollisionWithInfantry(Enemy infantry, ref int score, char[,] maze, List<Bullets> bullets)
        {
            for (int x = 0; x < bullets.Count; x++)
            {
                if (bullets[x].isActive == true)
                {
                    if ((bullets[x].posX == infantry.posX + 4) && (infantry.posY == bullets[x].posY) || (bullets[x].posX == infantry.posX + 5) && (infantry.posY == bullets[x].posY) || (bullets[x].posX == infantry.posX + 6) && (infantry.posY == bullets[x].posY) || (bullets[x].posX == infantry.posX + 7) && (infantry.posY == bullets[x].posY) || (bullets[x].posX == infantry.posX + 8) && (infantry.posY == bullets[x].posY) || (bullets[x].posX == infantry.posX + 9) && (infantry.posY == bullets[x].posY))
                    {
                        addScore(ref score);
                        infantry.health--;
                    }

                    else if ((bullets[x].posX == infantry.posX - 3) && (infantry.posY + 1 == bullets[x].posY) || (bullets[x].posX == infantry.posX - 2) && (infantry.posY + 1 == bullets[x].posY) || (bullets[x].posX == infantry.posX - 1) && (infantry.posY + 1 == bullets[x].posY) || (bullets[x].posX == infantry.posX - 1) && (infantry.posY + 1 == bullets[x].posY)
                            || (bullets[x].posX == infantry.posX + 1) && (infantry.posY + 1 == bullets[x].posY) || (bullets[x].posX == infantry.posX + 2) && (infantry.posY + 1 == bullets[x].posY)
                            || (bullets[x].posX == infantry.posX + 3) && (infantry.posY + 1 == bullets[x].posY) || (bullets[x].posX == infantry.posX + 4) && (infantry.posY + 1 == bullets[x].posY)
                            || (bullets[x].posX == infantry.posX + 5) && (infantry.posY + 1 == bullets[x].posY) || (bullets[x].posX == infantry.posX + 6) && (infantry.posY + 1 == bullets[x].posY)
                            || (bullets[x].posX == infantry.posX + 7) && (infantry.posY + 1 == bullets[x].posY) || (bullets[x].posX == infantry.posX + 8) && (infantry.posY + 1 == bullets[x].posY)
                            || (bullets[x].posX == infantry.posX + 9) && (infantry.posY + 1 == bullets[x].posY))
                    {
                        addScore(ref score);
                        infantry.health--;
                    }

                    else if ((bullets[x].posX == infantry.posX + 4) && (infantry.posY + 2 == bullets[x].posY) || (bullets[x].posX == infantry.posX + 7) && (infantry.posY + 2 == bullets[x].posY) || (bullets[x].posX == infantry.posX + 8) && (infantry.posY + 2 == bullets[x].posY))
                    {
                        addScore(ref score);
                        infantry.health--;
                    }
                }
            }
        }

        static void addScore(ref int score)
        {
            score++;
        }

        static void removeRamboFromMaze(char[,] maze, int ramboX, int ramboY)
        {
            int cols;
            int rows = ramboY;
            for (int i = 0; i < 4; i++)
            {
                cols = ramboX;
                for (int j = 0; j < 9; j++)
                {
                    maze[rows, cols] = ' ';
                    cols++;
                }
                rows++;
            }
        }

        static void addRambotoMaze(char[,] maze, int ramboX, int ramboY)
        {
            // Rambo Character
            char backslash = (char)92;
            char[,] ramboChar = new char[4, 9] { { '[', '=', '=', '=', '=', '=', '=', '=', backslash }, { '|', '=', '=', '=', '=', '=', '=', '=', '/' }, { '|', '|', ' ', '>', ' ', ' ', ' ', ' ', ' ' }, { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ' } };
            int cols;
            int rows = ramboY;
            for (int i = 0; i < 4; i++)
            {
                cols = ramboX;
                for (int j = 0; j < 9; j++)
                {
                    maze[rows, cols] = ramboChar[i, j];
                    cols++;
                }
                rows++;
            }
        }

        static void addInfantryToMaze(char[,] maze, int infantryX, int infantryY)
        {
            char backslash = (char)92;
            char box = (char)219;
            char fire = (char)170;
            char[,] infantry = new char[3, 11]{
                { ' ', ' ', ' ', ' ', ' ', '(', '-', ' ', '-', ')', ' '},
                            { '<', '-', '-', fire, backslash, box, box, box, box, box, '/'},
                            { ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' '}
            };
            int cols;
            int rows = infantryY;
            for (int i = 0; i < 3; i++)
            {
                cols = infantryX;
                for (int j = 0; j < 11; j++)
                {
                    maze[rows, cols] = infantry[i, j];
                    cols++;
                }
                rows++;
            }
        }

        static void removeInfantryFromMaze(char[,] maze, int infantryX, int infantryY)
        {
            int cols;
            int rows = infantryY;
            for (int i = 0; i < 3; i++)
            {
                cols = infantryX;
                for (int j = 0; j < 11; j++)
                {
                    maze[rows, cols] = ' ';
                    cols++;
                }
                rows++;
            }
        }

        static void moveTank(Enemy tank, char[,] maze)
        {
            // Tank Moving Functionality
            if (tank.direction == "Down")
            {
                char next = maze[tank.posY + 4, tank.posX];
                if (next == ' ')
                {
                    eraseTank(tank.posX, tank.posY);
                    removeTankFromMaze(maze, tank.posX, tank.posY);
                    tank.posY++;
                    printTank(tank.posX, tank.posY);
                    addTankToMaze(maze, tank.posX, tank.posY);
                }
                if (next == '*')
                {
                    tank.direction = "Up";
                }
            }

            if (tank.direction == "Up")
            {
                char next = maze[tank.posY - 1, tank.posX];
                if (next == ' ')
                {
                    eraseTank(tank.posX, tank.posY);
                    removeTankFromMaze(maze, tank.posX, tank.posY);
                    tank.posY--;
                    printTank(tank.posX, tank.posY);
                    addTankToMaze(maze, tank.posX, tank.posY);
                }
                if (next == '*')
                {
                    tank.direction = "Down";
                }
            }
        }

        static void removeTankFromMaze(char[,] maze, int tankX, int tankY)
        {
            int cols;
            int rows = tankY;
            for (int i = 0; i < 3; i++)
            {
                cols = tankX;
                for (int j = 0; j < 5; j++)
                {
                    maze[rows, cols] = ' ';
                    cols++;
                }
                rows++;
            }
        }

        static void addTankToMaze(char[,] maze, int tankX, int tankY)
        {
            // Tank Characters
            char box = (char)219;
            char fire = (char)170;
            char[,] tank = new char[3, 5] { { '<', '-', '-', '-', fire }, { box, box, box, box, box }, { 'O', 'O', 'O', 'O', 'O' } };
            int cols;
            int rows = tankY;
            for (int i = 0; i < 3; i++)
            {
                cols = tankX;
                for (int j = 0; j < 5; j++)
                {
                    maze[rows, cols] = tank[i, j];
                    cols++;
                }
                rows++;
            }
        }

        static void printTankHealth(Enemy tank, char[,] maze)
        {
            // Prints Tank Heealth at the left side of maze
            char heart = (char)3;
            Console.SetCursorPosition(120, 3);
            if (tank.health <= 10 && tank.health > 8)
            {
                Console.Write("Tank: {0}{0}{0}{0}{0}", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (tank.health <= 8 && tank.health > 6)
            {
                Console.Write("Tank: {0}{0}{0}{0} ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (tank.health <= 6 && tank.health > 4)
            {
                Console.Write("Tank: {0}{0}{0}  ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (tank.health <= 4 && tank.health > 2)
            {
                Console.Write("Tank: {0}{0}   ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (tank.health <= 2 && tank.health > 0)
            {
                Console.Write("Tank: {0}    ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (tank.health <= 0)
            {
                Console.Write("Tank:      ");
                Console.SetCursorPosition(tank.posX, tank.posY);
                eraseTank(tank.posX, tank.posY);
                removeTankFromMaze(maze, tank.posX, tank.posY);
            }
        }

        static void bulletCollisionWithTank(Enemy tank, ref int score, List<Bullets> bullet)
        {
            for (int x = 0; x < bullet.Count; x++)
            {
                if (bullet[x].isActive == true)
                {
                    if (bullet[x].posX + 1 == tank.posX && (bullet[x].posY == tank.posY || bullet[x].posY == tank.posY + 1 || bullet[x].posY == tank.posY + 2))
                    {
                        addScore(ref score);
                        tank.health--;
                    }
                    else if (tank.posX - 1 == bullet[x].posX && tank.posY + 1 == bullet[x].posY)
                    {
                        addScore(ref score);
                        tank.health--;
                    }
                }
            }
        }

        static void moveJetPlane(Enemy jetPlane, char[,] maze)
        {
            // Tank Moving Functionality
            if (jetPlane.direction == "Down")
            {
                char next = maze[jetPlane.posY + 5, jetPlane.posX];
                if (next == ' ')
                {
                    eraseJetPlane(jetPlane.posX, jetPlane.posY);
                    removeJetPlaneFromMaze(maze, jetPlane.posX, jetPlane.posY);
                    jetPlane.posY++;
                    printJetPlane(jetPlane.posX, jetPlane.posY);
                    addJetPlaneToMaze(maze, jetPlane.posX, jetPlane.posY);
                }
                if (next == '*')
                {
                    jetPlane.direction = "Up";
                }
            }

            if (jetPlane.direction == "Up")
            {
                char next = maze[jetPlane.posY - 1, jetPlane.posX];
                if (next == ' ')
                {
                    eraseJetPlane(jetPlane.posX, jetPlane.posY);
                    removeJetPlaneFromMaze(maze, jetPlane.posX, jetPlane.posY);
                    jetPlane.posY--;
                    printJetPlane(jetPlane.posX, jetPlane.posY);
                    addJetPlaneToMaze(maze, jetPlane.posX, jetPlane.posY);
                }
                if (next == '*')
                {
                    jetPlane.direction = "Down";
                }
            }
        }

        static void removeJetPlaneFromMaze(char[,] maze, int jetPlaneX, int jetPlaneY)
        {
            int cols;
            int rows = jetPlaneY;
            for (int i = 0; i < 5; i++)
            {
                cols = jetPlaneX;
                Console.SetCursorPosition(jetPlaneX, jetPlaneY + i);
                for (int j = 0; j < 6; j++)
                {
                    maze[rows, cols] = ' ';
                    cols++;
                }
                rows++;
            }
        }

        static void addJetPlaneToMaze(char[,] maze, int jetPlaneX, int jetPlaneY)
        {
            // JetPlane Characters

            char backslash = (char)92;
            char[,] jetPlane = new char[5, 6] { { ' ', ' ', ' ', ' ', '/', '|' }, { ' ', '/', backslash, '/', ' ', '|' }, { '<', '[', ' ', ' ', ' ', '|' }, { ' ', backslash, '/', backslash, ' ', '|' }, { ' ', ' ', ' ', ' ', backslash, '|' } };
            int cols;
            int rows = jetPlaneY;
            for (int i = 0; i < 5; i++)
            {
                cols = jetPlaneX;
                Console.SetCursorPosition(jetPlaneX, jetPlaneY + i);
                for (int j = 0; j < 6; j++)
                {
                    maze[rows, cols] = jetPlane[i, j];
                    cols++;
                }
                rows++;
            }
        }

        static void bulletCollisionWithJetPlane(List<Bullets> bullet, Enemy jetPlane, ref int score)
        {
            // Detects Collision and if true reduces Health
            for (int x = 0; x < bullet.Count; x++)
            {
                if (bullet[x].isActive == true)
                {
                    if (bullet[x].posX + 1 == jetPlane.posX && (bullet[x].posY == jetPlane.posY + 2))
                    {
                        addScore(ref score);
                        jetPlane.health--;
                    }
                    else if ((bullet[x].posX == jetPlane.posX) && (bullet[x].posY == jetPlane.posY + 1 || bullet[x].posY == jetPlane.posY + 3))
                    {
                        addScore(ref score);
                        jetPlane.health--;
                    }
                    else if ((bullet[x].posX - 3 == jetPlane.posX) && (bullet[x].posY == jetPlane.posY || bullet[x].posY == jetPlane.posY + 4))
                    {
                        addScore(ref score);
                        jetPlane.health--;
                    }
                }
            }

        }

        static void printJetPlaneHealth(Enemy jetPlane, char[,] maze)
        {
            // Prints Tank Heealth at the left side of maze
            char heart = (char)3;
            Console.SetCursorPosition(120, 3);
            if (jetPlane.health <= 15 && jetPlane.health > 12)
            {
                Console.Write("Jet Plane: {0}{0}{0}{0}{0}", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (jetPlane.health <= 12 && jetPlane.health > 9)
            {
                Console.Write("Jet Plane: {0}{0}{0}{0} ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (jetPlane.health <= 9 && jetPlane.health > 6)
            {
                Console.Write("Jet Plane: {0}{0}{0}  ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (jetPlane.health <= 6 && jetPlane.health > 3)
            {
                Console.Write("Jet Plane: {0}{0}   ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (jetPlane.health <= 3 && jetPlane.health > 0)
            {
                Console.Write("Jet Plane: {0}    ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (jetPlane.health <= 0)
            {
                Console.Write("Jet Plane:      ");
                Console.SetCursorPosition(jetPlane.posX, jetPlane.posY);
                eraseJetPlane(jetPlane.posX, jetPlane.posY);
                removeJetPlaneFromMaze(maze, jetPlane.posX, jetPlane.posY);
            }
        }

        static double calculateDistance(int X, int Y, int pX, int pY)
        {
            return Math.Sqrt(Math.Pow((pX - X), 2) + Math.Pow((pY - Y), 2));
        }

        static int Direction()
        {
            Random r = new Random();
            int value = r.Next(4);
            return value;
        }

        static void moveBalaRandom(char[,] maze, Enemy bala)
        {
            int value = Direction();

            if (value == 0)   //Moving Left
            {
                char next = maze[bala.posY, bala.posX - 1];
                if (next == ' ' || next == '.')
                {
                    eraseBala(bala.posX, bala.posY);
                    removeBalaFromMaze(bala.posX, bala.posY, maze);
                    bala.posX--;
                    printBala(bala.posX, bala.posY);
                    addBalaToMaze(bala.posX, bala.posY, maze);
                }
            }

            if (value == 1)   //Moving Right
            {
                char next = maze[bala.posY, bala.posX + 9];
                if (next == ' ' || next == '.')
                {
                    eraseBala(bala.posX, bala.posY);
                    removeBalaFromMaze(bala.posX, bala.posY, maze);
                    bala.posX++;
                    printBala(bala.posX, bala.posY);
                    addBalaToMaze(bala.posX, bala.posY, maze);
                }
            }

            if (value == 2)   //Moving Up
            {
                char next = maze[bala.posY - 1, bala.posX];
                if (next == ' ' || next == '.')
                {
                    eraseBala(bala.posX, bala.posY);
                    removeBalaFromMaze(bala.posX, bala.posY, maze);
                    bala.posY--;
                    printBala(bala.posX, bala.posY);
                    addBalaToMaze(bala.posX, bala.posY, maze);
                }
            }

            if (value == 3)   //Moving Down
            {
                char next = maze[bala.posY + 5, bala.posX];
                if (next == ' ' || next == '.')
                {
                    eraseBala(bala.posX, bala.posY);
                    removeBalaFromMaze(bala.posX, bala.posY, maze);
                    bala.posY++;
                    printBala(bala.posX, bala.posY);
                    addBalaToMaze(bala.posX, bala.posY, maze);
                }
            }
        }

        static void moveBalaSmart(Enemy bala, Player rambo, char[,] maze)
        {
            // Distance Formula to check distance of Bala to Rambo
            double left = calculateDistance(bala.posX - 1, bala.posY, rambo.posX, rambo.posY);
            double right = calculateDistance(bala.posX + 1, bala.posY, rambo.posX, rambo.posY);
            double up = calculateDistance(bala.posX, bala.posY - 1, rambo.posX, rambo.posY);
            double down = calculateDistance(bala.posX, bala.posY + 1, rambo.posX, rambo.posY);
            // The Player will move to the shortest distance
            if (left <= down && left <= right && left <= up) // Move Left if true
            {
                char next = maze[bala.posY, bala.posX - 1];
                if (next == ' ' || next == '.')
                {
                    eraseBala(bala.posX, bala.posY);
                    bala.posX--;
                    printBala(bala.posX, bala.posY);
                }
            }
            else if (right <= down && right <= left && right <= up) // Move Right if true
            {
                char next = maze[bala.posY, bala.posX + 9];
                if (next == ' ' || next == '.')
                {
                    eraseBala(bala.posX, bala.posY);
                    bala.posX++;
                    printBala(bala.posX, bala.posY);
                }
            }
            else if (down <= left && down <= right && down <= up) // Move Down if true
            {
                char next = maze[bala.posY + 5, bala.posX];
                if (next == ' ' || next == '.')
                {
                    eraseBala(bala.posX, bala.posY);
                    bala.posY++;
                    printBala(bala.posX, bala.posY);
                }
            }
            else // Move Up if true
            {
                char next = maze[bala.posY - 1, bala.posX];
                if (next == ' ' || next == '.')
                {
                    eraseBala(bala.posX, bala.posY);
                    bala.posY--;
                    printBala(bala.posX, bala.posY);
                }
            }
        }

        static void bulletCollisionWithBala(Enemy bala, ref int score, List<Bullets> bullet)
        {
            // Detects Collision And Reduces Health of Bala
            for (int x = 0; x < bullet.Count; x++)
            {
                if (bullet[x].isActive == true)
                {
                    if (bullet[x].posX + 1 == bala.posX && (bullet[x].posY == bala.posY || bullet[x].posY == bala.posY + 1))
                    {
                        addScore(ref score);
                        bala.health--;
                    }
                    else if (bala.posX - 1 == bullet[x].posX && bala.posY + 1 == bullet[x].posY)
                    {
                        addScore(ref score);
                        bala.health--;
                    }
                    else if (bullet[x].posX - 4 == bala.posX && (bullet[x].posY == bala.posY + 2))
                    {
                        addScore(ref score);
                        bala.health--;
                    }
                    else if (bullet[x].posX - 6 == bala.posX && (bullet[x].posY == bala.posY + 3))
                    {
                        addScore(ref score);
                        bala.health--;
                    }
                }
            }
        }

        static void printBalaHealth(Enemy bala, char[,] maze)
        {
            // Prints Tank Heealth at the left side of maze
            char heart = (char)3;
            Console.SetCursorPosition(120, 3);
            if (bala.health <= 20 && bala.health > 16)
            {
                Console.Write("Bala: {0}{0}{0}{0}{0}", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (bala.health <= 16 && bala.health > 12)
            {
                Console.Write("Bala: {0}{0}{0}{0} ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (bala.health <= 12 && bala.health > 8)
            {
                Console.Write("Bala: {0}{0}{0}  ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (bala.health <= 8 && bala.health > 4)
            {
                Console.Write("Bala: {0}{0}   ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (bala.health <= 4 && bala.health > 0)
            {
                Console.Write("Bala: {0}    ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (bala.health <= 0)
            {
                Console.Write("Bala:      ", heart);
                Console.SetCursorPosition(bala.posX, bala.posY);
                eraseBala(bala.posX, bala.posY);
                removeBalaFromMaze(bala.posX, bala.posY, maze);
            }
        }

        static void printHealthPill()
        {
            // Prints Health Pill
            char heart = (char)3;
            Console.SetCursorPosition(70, 20);
            Console.Write(heart);
        }

        static void removeHealthPill()
        {
            // Removes Health Pill
            Console.SetCursorPosition(70, 20);
            Console.Write(" ");
        }

        static void healthPill(Player rambo, int pillX, int pillY)
        {
            // Health Pill Functionality
            printHealthPill();
            if (((rambo.posX + 8 == pillX) && (rambo.posY == pillY)) || ((rambo.posX + 8 == pillX) && (rambo.posY + 1 == pillY)) || ((rambo.posX + 4 == pillX) && (rambo.posY + 2 == pillY)) || ((rambo.posX + 2 == pillX) && (rambo.posY + 3 == pillY)))
            {
                rambo.health = rambo.health + 10;
                removeHealthPill();
            }
            else if (((rambo.posX == pillX) || (rambo.posX + 1 == pillX) || (rambo.posX + 2 == pillX) || (rambo.posX + 3 == pillX) || (rambo.posX + 4 == pillX) || (rambo.posX + 5 == pillX) || (rambo.posX + 6 == pillX) || (rambo.posX + 7 == pillX)) && (rambo.posY == pillY))
            {
                rambo.health = rambo.health + 10;
                removeHealthPill();
            }
            else if (((rambo.posX == pillX) || (rambo.posX + 1 == pillX) || (rambo.posX + 2 == pillX) || (rambo.posX + 3 == pillX) || (rambo.posX + 4 == pillX) || (rambo.posX + 5 == pillX) || (rambo.posX + 6 == pillX) || (rambo.posX + 7 == pillX)) && (rambo.posY + 3 == pillY))
            {
                rambo.health = rambo.health + 10;
                removeHealthPill();
            }
        }

        static bool playerCollisionWithEnemyRight(char[,] maze, int ramboX, int ramboY)
        {
            bool collision = false;
            char heart = (char)3;
            // Takes Characters around rambo right
            char isEnemy1 = maze[ramboY, ramboX + 9];
            char isEnemy2 = maze[ramboY + 1, ramboX + 9];
            char isEnemy3 = maze[ramboY + 2, ramboX + 4];
            char isEnemy4 = maze[ramboY + 3, ramboX + 2];
            if ((isEnemy1 == '~') || (isEnemy2 == '~') || (isEnemy3 == '~') || (isEnemy4 == '~'))
            {
                return false;
            }
            if ((isEnemy1 == heart) || (isEnemy2 == heart) || (isEnemy3 == heart) || (isEnemy4 == heart))
            {
                return false;
            }
            if ((isEnemy1 != ' ') || (isEnemy2 != ' ') || (isEnemy3 != ' ') || (isEnemy4 != ' '))
            {
                collision = true;
            }
            if ((isEnemy1 == '!') || (isEnemy2 == '!') || (isEnemy3 == '!') || (isEnemy4 == '!'))
            {
                collision = false;
            }
            if ((isEnemy1 == '*') || (isEnemy2 == '*') || (isEnemy3 == '*') || (isEnemy4 == '*'))
            {
                collision = false;
            }

            return collision;
        }

        static bool playerCollisionWithEnemyLeft(char[,] maze, int ramboX, int ramboY)
        {
            bool collision = false;
            char heart = (char)3;
            // Takes Characters around rambo left
            char isEnemy1 = maze[ramboY, ramboX - 1];
            char isEnemy2 = maze[ramboY + 1, ramboX - 1];
            char isEnemy3 = maze[ramboY + 2, ramboX - 1];
            char isEnemy4 = maze[ramboY + 3, ramboX - 1];
            if ((isEnemy1 == '~') || (isEnemy2 == '~') || (isEnemy3 == '~') || (isEnemy4 == '~'))
            {
                return false;
            }
            if ((isEnemy1 == heart) || (isEnemy2 == heart) || (isEnemy3 == heart) || (isEnemy4 == heart))
            {
                return false;
            }
            if ((isEnemy1 != ' ') || (isEnemy2 != ' ') || (isEnemy3 != ' ') || (isEnemy4 != ' '))
            {
                collision = true;
            }
            if ((isEnemy1 == '!') || (isEnemy2 == '!') || (isEnemy3 == '!') || (isEnemy4 == '!'))
            {
                collision = false;
            }
            if ((isEnemy1 == '*') || (isEnemy2 == '*') || (isEnemy3 == '*') || (isEnemy4 == '*'))
            {
                collision = false;
            }

            return collision;
        }

        static bool playerCollisionWithEnemyUp(char[,] maze, int ramboX, int ramboY)
        {
            // Takes Characters around rambo Up
            bool collision = false;
            char heart = (char)3;
            char isEnemy1 = maze[ramboY + 4, ramboX];
            char isEnemy2 = maze[ramboY + 4, ramboX + 1];
            char isEnemy3 = maze[ramboY + 3, ramboX + 3];
            char isEnemy4 = maze[ramboY + 2, ramboX + 4];
            char isEnemy5 = maze[ramboY + 2, ramboX + 5];
            char isEnemy6 = maze[ramboY + 2, ramboX + 6];
            char isEnemy7 = maze[ramboY + 2, ramboX + 4];

            if ((isEnemy1 == '~') || (isEnemy2 == '~') || (isEnemy3 == '~') || (isEnemy4 == '~') || (isEnemy5 == '~') || (isEnemy6 == '~') || (isEnemy7 == '~'))
            {
                return false;
            }
            if ((isEnemy1 == heart) || (isEnemy2 == heart) || (isEnemy3 == heart) || (isEnemy4 == heart) || (isEnemy5 == heart) || (isEnemy6 == heart) || (isEnemy7 == heart))
            {
                return false;
            }
            if ((isEnemy1 != ' ') || (isEnemy2 != ' ') || (isEnemy3 != ' ') || (isEnemy4 != ' ') || (isEnemy5 != ' ') || (isEnemy6 != ' ') || (isEnemy7 != ' '))
            {
                collision = true;
            }
            if ((isEnemy1 == '!') || (isEnemy2 == '!') || (isEnemy3 == '!') || (isEnemy4 == '!') || (isEnemy5 == '!') || (isEnemy6 == '!') || (isEnemy7 == '!'))
            {
                collision = false;
            }
            if ((isEnemy1 == '*') || (isEnemy2 == '*') || (isEnemy3 == '*') || (isEnemy4 == '*') || (isEnemy5 == '*') || (isEnemy6 == '*') || (isEnemy7 == '*'))
            {
                collision = false;
            }

            return collision;
        }

        static bool playerCollisionWithEnemyDown(char[,] maze, int ramboX, int ramboY)
        {
            bool collision = false;
            char heart = (char)3;
            // Takes Characters around rambo Down
            char isEnemy1 = maze[ramboY - 1, ramboX];
            char isEnemy2 = maze[ramboY - 1, ramboX + 1];
            char isEnemy3 = maze[ramboY - 1, ramboX + 2];
            char isEnemy4 = maze[ramboY - 1, ramboX + 3];
            char isEnemy5 = maze[ramboY - 1, ramboX + 4];
            char isEnemy6 = maze[ramboY - 1, ramboX + 5];
            char isEnemy7 = maze[ramboY - 1, ramboX + 6];
            char isEnemy8 = maze[ramboY - 1, ramboX + 7];
            char isEnemy9 = maze[ramboY - 1, ramboX + 8];

            if ((isEnemy1 == '~') || (isEnemy2 == '~') || (isEnemy3 == '~') || (isEnemy4 == '~') || (isEnemy5 == '~') || (isEnemy6 == '~') || (isEnemy7 == '~') || (isEnemy8 == '~') || (isEnemy9 == '~'))
            {
                return false;
            }
            if ((isEnemy1 == heart) || (isEnemy2 == heart) || (isEnemy3 == heart) || (isEnemy4 == heart) || (isEnemy5 == heart) || (isEnemy6 == heart) || (isEnemy7 == heart) || (isEnemy8 == heart) || (isEnemy9 == heart))
            {
                return false;
            }
            if ((isEnemy1 != ' ') || (isEnemy2 != ' ') || (isEnemy3 != ' ') || (isEnemy4 != ' ') || (isEnemy5 != ' ') || (isEnemy6 != ' ') || (isEnemy7 != ' ') || (isEnemy8 != ' ') || (isEnemy9 != ' '))
            {
                collision = true;
            }
            if ((isEnemy1 == '!') || (isEnemy2 == '!') || (isEnemy3 == '!') || (isEnemy4 == '!') || (isEnemy5 == '!') || (isEnemy6 == '!') || (isEnemy7 == '!') || (isEnemy8 == '!') || (isEnemy9 == '!'))
            {
                collision = false;
            }
            if ((isEnemy1 == '*') || (isEnemy2 == '*') || (isEnemy3 == '*') || (isEnemy4 == '*') || (isEnemy5 == '*') || (isEnemy6 == '*') || (isEnemy7 == '*') || (isEnemy8 == '*') || (isEnemy9 == '*'))
            {
                collision = false;
            }

            return collision;
        }
    }
}
