using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using EZInput;

namespace ConsoleApp2
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
            Console.WriteLine("Press any key to continue...");
            a = Console.ReadLine();
        }

        static string mainMenu()
        {
            // Prints Main Menu
            Console.WriteLine("         MENU      ");
            Console.WriteLine("         ----------");
            Console.WriteLine("         1. Start  ");
            Console.WriteLine("         2. Options");
            Console.WriteLine("         3. Credits");
            Console.WriteLine("         4. Exit   ");
            string option;
            Console.WriteLine("         Enter your option: ");
            option = Console.ReadLine(); // Takes an option from user
            return option;
        }

        static string optionSubMenu()
        {
            // Prints Options Menu
            Console.WriteLine("         OPTIONS        ");
            Console.WriteLine("         ----------     ");
            Console.WriteLine("         1. Keys        ");
            Console.WriteLine("         2. Instructions");
            Console.WriteLine("         3. Exit        ");
            string option;
            Console.WriteLine("         Enter your option: ");
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
            //gotoxy(20, 19);
            // Sleep(90);
            Console.WriteLine("1. Graphics: Mohammad Abdullah");
            //Sleep(90);
            //gotoxy(20, 20);
            Console.WriteLine("2. Sound: Mr. Mohammad Abdullah ");
            //Sleep(90);
            //gotoxy(20, 21);
            Console.WriteLine("3. Game Development: Dr. Mohammad Abdullah");
            //Sleep(90);
            //gotoxy(20, 22);
            Console.WriteLine("4. Produced by: Sir Mohammad Abdullah");
            //Sleep(90);
            //gotoxy(20, 23);
            Console.WriteLine("5. Sponsored by: Mohammad Abdullah Group of Companies.");
            //gotoxy(20, 24);
            //Sleep(90);
            Console.Write("Press any key to continue...");
            // Any string to continue the game later
            string a;
            a = Console.ReadLine();
        }

        static void showInstructions()
        {
            Console.Clear();
            header();
                                                  // Shows Instructions
            Console.WriteLine("         1. The player can move in all the directions.          ");
            Console.WriteLine("         2. The player will have to kill all the enemies to win.");
            Console.WriteLine("         Press any key to exit...                               ");
            // Any string to continue the game later
            string a;
            a = Console.ReadLine();
        }

        static void showKeys()
        {
            Console.Clear();
            header();
                                                  // Shows Keys
            Console.WriteLine("   Up        Key Up    ");
            Console.WriteLine("  Down       Key Down  ");
            Console.WriteLine("  Left       Key Left  ");
            Console.WriteLine("  Right      Key Right ");
            Console.WriteLine("  Fire       Key Space ");
            Console.WriteLine("  Exit       Key Escape");
            Console.WriteLine("Enter any key to exit...");
            // Any string to continue the game later
            string a;
            a = Console.ReadLine();
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
            char box =  (char)219;
            char fire = (char)170;
            char[,] tank = new char[3, 5] { { '<', '-', '-', '-', fire }, { box, box, box, box, box }, { 'O', 'O', 'O', 'O', 'O' } } ;
            // Prints Tank
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(tankX,tankY + i); // Goes below to print next line
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(tank[i,j]);
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

        static void printJetPlane()
        {
            char backslash = (char)92;
            char[,] jetPlane = new char [5,6] { { ' ', ' ', ' ', ' ', '/', '|'}, { ' ', '/', backslash, '/', ' ', '|'}, { '<', '[', ' ', ' ', ' ', '|'}, { ' ', backslash, '/', backslash, ' ', '|'}, { ' ', ' ', ' ', ' ', backslash, '|'} };

            for (int i = 0; i < 5; i++)
            {
                //gotoxy(jetPlaneX, jetPlaneY + i);
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(jetPlane[i,j]);
                }
            }
        }

        static void eraseJetPlane()
        {
            // Erases Jet Plane
            int a = 6;
            //gotoxy(jetPlaneX, jetPlaneY);
            for (int i = 0; i < a; i++)
            {
                Console.Write(" ");
            }
            //gotoxy(jetPlaneX, jetPlaneY + 1);
            for (int i = 0; i < a; i++)
            {
                Console.Write(" ");
            }
            //gotoxy(jetPlaneX, jetPlaneY + 2);

            for (int i = 0; i < a; i++)
            {
                Console.Write(" ");
            }
            //gotoxy(jetPlaneX, jetPlaneY + 3);

            for (int i = 0; i < a; i++)
            {
                Console.Write(" ");
            }
            //gotoxy(jetPlaneX, jetPlaneY + 4);

            for (int i = 0; i < a; i++)
            {
                Console.Write(" ");
            }
        }

        static void printInfantry(int infantryX, int infantryY)
        {
            // Infantry Character
            char backslash = (char)92;
            char box = (char)219;
            char fire = (char)170;
            char[,] infantry = new char[3,11]{
                { ' ', ' ', ' ', ' ', ' ', '(', '-', ' ', '-', ')', ' '},
                            { '<', '-', '-', fire, backslash, box, box, box, box, box, '/'},
                            { ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' '}
            };

            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(infantryX, infantryY + i);
                for (int j = 0; j < 11; j++)
                {
                    Console.Write(infantry[i,j]);
                }
            }
        }

        static void eraseInfantry(int infantryX, int infantryY)
        {
            int a = 11;

            // Erasing Functionality for infantry
            for(int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(infantryX, infantryY + i);
                for(int j = 0; j < a; j++)
                {
                    Console.Write(" ");
                }
            }
        }

        static void printBala()
        {
            // Bala Characters
            char backslash = (char)92;
            char[,] bala = new char[4,9]  {
                { '/', '=', '=', '=', '=', '=', '=', '=', ']'},
        { backslash, '=', '=', '=', '=', '=', '=', '=', '|'},
        { ' ', ' ', ' ', ' ', ' ', '<', ' ', '|', '|'},
        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '|'}
            };
            for (int i = 0; i < 4; i++)
            {
                //gotoxy(balaX, balaY + i); // Goes to next y-coordinate to print next row
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(bala[i,j]);
                }
            }
        }

        static void eraseBala()
        {
            int a = 9;
            // Erases Bala
            //gotoxy(balaX, balaY);
            for (int i = 0; i < a; i++)
            {
                Console.Write(" ");
            }

            //gotoxy(balaX, balaY + 1);
            for (int i = 0; i < a; i++)
            {
                Console.Write(" ");
            }

            //gotoxy(balaX, balaY + 2);
            for (int i = 0; i < a; i++)
            {
                Console.Write(" ");
            }

            //gotoxy(balaX, balaY + 3);
            for (int i = 0; i < a; i++)
            {
                Console.Write(" ");
            }
        }

        static void gameOver()
        {
            // Game Over is printed
            Console.Clear();
            //gotoxy(40, 10);
            Console.Write("       *********      ***      **    **  *********       ");
            //gotoxy(40, 11);
            Console.Write("       *             ** **     * *  * *  *               ");
            //gotoxy(40, 12);
            Console.Write("       *    ****    *******    *  **  *  ******          ");
            //gotoxy(40, 13);
            Console.Write("       *       *   **     **   *      *  *               ");
            //gotoxy(40, 14);
            Console.Write("       *********  **       **  *      *  *********       ");
            //gotoxy(40, 17);
            Console.Write("       *********  **       **  *********  *******        ");
            //gotoxy(40, 18);
            Console.Write("       *       *   **     **   *         *       *       ");
            //gotoxy(40, 19);
            Console.Write("       *       *    **   **    ******    ********        ");
            //gotoxy(40, 20);
            Console.Write("       *       *     ** **     *         *  **           ");
            //gotoxy(40, 21);
            Console.Write("       *********      **       ********* *     **        ");
            //gotoxy(40, 23);
            Console.WriteLine("       Enter any key to exit.");
            Console.ReadLine();
        }

        void youWon()
        {
            // Prints Congrats
            Console.Clear();
            //gotoxy(40, 10);
            Console.Write("       *********  *********   ***     *  *********   *******       ***      **********  ********* ");
            //gotoxy(40, 11);
            Console.Write("       *          *       *   *  *    *  *          *       *     ** **         **      **        ");
            //gotoxy(40, 12);
            Console.Write("       *          *       *   *   *   *  *   *****  *********    *******        **      ********* ");
            //gotoxy(40, 13);
            Console.Write("       *          *       *   *    *  *  *       *  *  **       **     **       **             ** ");
            //gotoxy(40, 14);
            Console.Write("       *********  *********   *     ***  *********  *     **   **       **      **      ********* ");
            //gotoxy(40, 16);
            Console.WriteLine("       Enter 0 to exit.");

            string a;
            a = Console.ReadLine();
        }

        static void printRambo(int ramboX, int ramboY)
        {
            // Rambo Character
            char backslash = (char)92;
            char[,] rambo = new char[4,9] { { '[', '=', '=', '=', '=', '=', '=', '=', backslash}, { '|', '=', '=', '=', '=', '=', '=', '=', '/'}, { '|', '|', ' ', '>', ' ', ' ', ' ', ' ', ' '}, { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' '} };

            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(ramboX, ramboY + i);
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(rambo[i,j]);
                }
            }
        }

        static void removeRambo(int ramboX, int ramboY)
        {
            // Erases Rambo
            int a = 9;
           
            for(int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(ramboX, ramboY + i);
                for( int j = 0; j < a; j++)
                {
                    Console.Write(" ");
                }
            }
        }

        static void nextLevel()
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
            //printMaze();
        }

        static void gameInterface()
        {
            // Reinitiate all the valuse so the game could run the same way it started
            
            int healthTimer = 0;
            //int smartTimer = 0;
            //int level = 1;
            int towerHealth = 300;
            int balaHealth = 20;
            int infantryHealth = 5;
            int tankHealth = 10;
            //int jetPlaneHealth = 15;
            int ramboX = 16;
            int ramboY = 10;
            int infantryX = 60;
            int infantryY = 15;
            int tankX = 90;
            int tankY = 7;
            //int jetPlaneX = 80;
            //int jetPlaneY = 7;
            //int balaX = 60;
            //int balaY = 15;
            int enemy = 4;
            int enemyFireDamage = 1;
            int slow = 0;
            string infantryDirection = "Right";
            string tankDirection = "Up";
            //string jetPlaneDirection = "Up";
            //string balaDirection = "Up";
            int[] bulletX = new int[500];
            int[] bulletY = new int[500];
            bool[] isBulletActive = new bool[500];
            int[] enemyBulletX = new int[500];
            int[] enemyBulletY = new int[500];
            bool[] isEnemyBulletActive = new bool[500];
            int enemyBulletCount = 0;
            int bulletCount = 0;
            int score = 0;
            int timer = 0;
            // boolean values to check collision
            //bool collisionPlayerRight, collisionPlayerLeft, collisionPlayerUp, collisionPlayerDown;
            bool gameRunning = true;
            Console.Clear();

            char[,] maze = new char[30, 150];
            readMaze(maze);
            printMaze(maze);
            printRambo(ramboX, ramboY);
            printInfantry(infantryX, infantryY);
            printRamboHealth(towerHealth, ramboX, ramboY); // Prints Rambos Health
            while (gameRunning == true)
            {
                if (towerHealth > 0 && balaHealth > 0)
                {
                    if (Keyboard.IsKeyPressed(Key.LeftArrow))
                    {
                        moveRamboLeft(maze, ref ramboX, ref ramboY); // Moves Player to the Left
                    }

                    if (Keyboard.IsKeyPressed(Key.RightArrow))
                    {
                        moveRamboRight(maze, ref ramboX, ref ramboY); // Moves Player to the Right
                    }

                    if (Keyboard.IsKeyPressed(Key.UpArrow))
                    {
                        moveRamboUp(maze, ref ramboX, ref ramboY); // Moves Player to the Up
                    }

                    if (Keyboard.IsKeyPressed(Key.DownArrow))
                    {
                        moveRamboDown(maze, ref ramboX, ref ramboY); // Moves Player to the Down
                    }

                    if (Keyboard.IsKeyPressed(Key.Space))
                    {
                        generateBullet(ref bulletX, ref bulletY, ref bulletCount, ref isBulletActive, ramboX, ramboY, maze); // Fires
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
                                moveInfantry(ref infantryDirection, ref infantryX, ref infantryY, maze);
                                slow = 0;
                            }
                            slow++;
                            bulletCollisionWithInfantry(bulletX, bulletY , infantryX, infantryY, ref infantryHealth, bulletCount, isBulletActive, ref score, maze);
                            printInfantryHealth(infantryHealth, infantryX, infantryY);
                            if (timer == 16)
                            {
                                generateEnemyBullet(enemyBulletX, enemyBulletY, ref enemyBulletCount, isEnemyBulletActive, infantryX, infantryY + 1, maze);

                                timer = 0;
                            }
                            moveEnemyBullet(maze, enemyBulletX, enemyBulletY, isEnemyBulletActive , bulletCount);
                            timer++;

                            if (infantryHealth <= 0)
                            {
                                enemy--;
                                eraseInfantry(infantryX, infantryY);
                                timer = 0;
                            }
                        }
                        if (enemy == 3) // Tanks
                        {
                            enemyFireDamage = 2;
                            printTank(tankX, tankY);
                            moveTank(ref tankDirection, ref tankX, ref tankY, maze);
                            bulletCollisionWithTank(bulletCount, bulletX, bulletY, tankX, tankY, ref score, ref tankHealth, isBulletActive);
                            printTankHealth(tankHealth, tankX, tankY);
                            if (timer == 12)
                            {
                                generateEnemyBullet(enemyBulletX, enemyBulletY, ref enemyBulletCount, isEnemyBulletActive,tankX, tankY, maze);
                                timer = 0;
                            }

                            moveEnemyBullet(maze, enemyBulletX, enemyBulletY, isEnemyBulletActive, enemyBulletCount);
                            timer++;
                            if (tankHealth <= 0)
                            {
                                enemy--;
                                timer = 0;
                            }
                        }
                        /*if (enemy == 2) // Jet Plane
                        {
                            enemyFireDamage = 3;
                            moveJetPlane();
                            bulletCollisionWithJetPlane();
                            printJetPlaneHealth();
                            if (timer == 8)
                            {
                                generateEnemyBullet(jetPlaneX - 1, jetPlaneY + 2);
                                timer = 0;
                            }

                            moveEnemyBullet();
                            timer++;
                            if (jetPlaneHealth <= 0)
                            {
                                enemy--;
                                timer = 0;
                            }
                        }
                        if (enemy == 1) // Final Enemy
                        {
                            if (level == 1)
                            {
                                nextLevel();
                                level = 0;
                            }
                            enemyFireDamage = 4;
                            moveBalaRandom();
                            bulletCollisionWithBala();
                            printBalaHealth();
                            if (smartTimer == 0)
                            {
                                moveBalaSmart();
                                smartTimer = 0;
                            }
                            smartTimer++;
                            if (timer == 4)
                            {
                                generateEnemyBullet(balaX - 1, balaY);
                                timer = 0;
                            }
                            moveEnemyBullet();
                            timer++;
                            if (balaHealth <= 0)
                            {
                                enemy--;
                                timer = 0;
                            }
                        }
                    }
                    // Health Pill Comes into the game
                    if (healthTimer == 50)
                    {
                        healthPill();
                        healthTimer = 0;
                    }*/
                        bulletCollisionWithTower(maze, ref towerHealth, enemyFireDamage, enemyBulletX, enemyBulletY, isEnemyBulletActive, enemyBulletCount);
                        moveBullet(maze, ref bulletX, ref bulletY, ref isBulletActive, bulletCount);
                        printScore(score);
                        printRamboHealth(towerHealth, ramboX, ramboY);
                        // Checking Collisions
                        /*collisionPlayerRight = playerCollisionWithEnemyRight();
                        collisionPlayerLeft = playerCollisionWithEnemyLeft();
                        collisionPlayerUp = playerCollisionWithEnemyUp();
                        collisionPlayerDown = playerCollisionWithEnemyDown();
                        if ((collisionPlayerLeft == true) || (collisionPlayerRight == true) || (collisionPlayerUp == true) || (collisionPlayerDown == true))
                        {
                            gameOver();
                            gameRunning = false;
                        }
                        // Checking if the player has lost
                        if (towerHealth <= 0)
                        {
                            gameOver();
                            gameRunning = false;
                        }
                        // Checking if the player has Won
                        if (balaHealth <= 0)
                        {
                            youWon();
                            gameRunning = false;
                        }
                        Sleep(30);*/
                        // Timer for Increasing health system
                        healthTimer++;
                        Thread.Sleep(30);
                    }
                }
            }
        }

        static void printScore(int score)
        {
            Console.SetCursorPosition(120,13);
            Console.WriteLine("Score: " + score);
        }

        static void moveRamboLeft(char[,] maze, ref int ramboX, ref int ramboY)
        {
            const char heart = (char)3;
            if (maze[ramboY, ramboX - 1] == ' ' || maze[ramboY, ramboX - 1] == heart)
            {
                removeRambo(ramboX, ramboY);
                removeRamboFromMaze(maze, ramboX, ramboY);
                ramboX--;
                printRambo(ramboX, ramboY);
                addRambotoMaze(maze, ramboX, ramboY);
            }
        }

        static void moveRamboRight(char[,] maze, ref int ramboX, ref int ramboY)
        {
            const char heart = (char)3;
            if (maze[ramboY, ramboX + 10] == ' ' || maze[ramboY, ramboX + 10] == heart)
            {
                removeRambo(ramboX, ramboY);
                removeRamboFromMaze(maze, ramboX, ramboY);
                ramboX++;
                printRambo(ramboX, ramboY);
                addRambotoMaze(maze, ramboX, ramboY);
            }
        }

        static void moveRamboUp(char[,] maze, ref int ramboX, ref int ramboY)
        {
            char heart = (char)3;
            if (maze[ramboY - 1, ramboX] == ' ' || maze[ramboY - 1, ramboX] == heart)
            {
                removeRambo(ramboX, ramboY);
                removeRamboFromMaze(maze, ramboX, ramboY);
                ramboY--;
                printRambo(ramboX, ramboY);
                addRambotoMaze(maze, ramboX, ramboY);
            }
        }

        static void moveRamboDown(char[,] maze, ref int ramboX, ref int ramboY)
        {
            char heart = (char)3;
            if (maze[ramboY + 4, ramboX] == ' ' || maze[ramboY + 4, ramboX] == heart)
            {
                removeRambo(ramboX, ramboY);
                removeRamboFromMaze(maze, ramboX, ramboY);
                ramboY++;
                printRambo(ramboX, ramboY);
                addRambotoMaze(maze, ramboX, ramboY);
            }
        }

        static void generateBullet(ref int[] bulletX, ref int[] bulletY, ref int bulletCount, ref bool[] isBulletActive, int ramboX, int ramboY, char[,] maze)
        {
            // Generates Player's Bullet
            bulletX[bulletCount] = ramboX + 10;
            bulletY[bulletCount] = ramboY;
            isBulletActive[bulletCount] = true;
            Console.SetCursorPosition(ramboX + 10, ramboY);
            Console.Write(".");
            maze[ramboY, ramboX] = '.';

            bulletCount++;
        }

        static void generateEnemyBullet(int[] enemyBulletX, int[] enemyBulletY, ref int enemyBulletCount, bool[] isEnemyBulletActive, int x, int y, char[,] maze)
        {
            // Generates Bullet for Enemies
            enemyBulletX[enemyBulletCount] = x - 1;
            enemyBulletY[enemyBulletCount] = y;
            isEnemyBulletActive[enemyBulletCount] = true;
            Console.SetCursorPosition(x - 1, y);
            Console.Write("~");
            maze[y, x] = '~';
            enemyBulletCount++;
        }

        static void moveInfantry(ref string infantryDirection, ref int infantryX, ref int infantryY, char[,] maze)
        {
            // Infantry Moving Functionality
            if (infantryDirection == "Right")
            {
                char next = maze[infantryY, infantryX + 14];
                if (next == ' ')
                {
                    eraseInfantry(infantryX, infantryY);
                    removeInfantryFromMaze(maze, infantryX, infantryY);
                    infantryX++;
                    printInfantry(infantryX, infantryY);
                    addInfantryToMaze(maze, infantryX, infantryY);
                }
                if (next == '*')
                {
                    infantryDirection = "Left";
                }
            }

            if (infantryDirection == "Left")
            {
                char next = maze[infantryY, infantryX - 1];
                if (next == ' ')
                {
                    eraseInfantry(infantryX, infantryY);
                    removeInfantryFromMaze(maze, infantryX, infantryY);
                    infantryX--;
                    printInfantry(infantryX, infantryY);
                    addInfantryToMaze(maze, infantryX, infantryY);
                }
                if (next == '!')
                {
                    infantryDirection = "Right";
                }
            }
        }

        static void printInfantryHealth(int infantryHealth, int infantryX, int infantryY)
        {
            // Prints Tank Heealth at the left side of maze
            char heart = (char)3;
            Console.SetCursorPosition(120, 3);
            if (infantryHealth == 5)
            {
                Console.Write("Infantry: {0}{0}{0}{0}{0}", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (infantryHealth == 4)
            {
                Console.Write("Infantry: {0}{0}{0}{0} ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (infantryHealth == 3)
            {
                Console.Write("Infantry: {0}{0}{0}  ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (infantryHealth == 2)
            {
                Console.Write("Infantry: {0}{0}   ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (infantryHealth == 1)
            {
                Console.Write("Infantry: {0}    ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (infantryHealth <= 0)
            {
                Console.Write("Infantry:      ", heart);
                Console.SetCursorPosition(infantryX, infantryY);
                eraseInfantry(infantryX, infantryY);
            }
        }

        static void moveEnemyBullet(char[,] maze ,int[] enemyBulletX, int[] enemyBulletY, bool[] isEnemyBulletActive, int enemyBulletCount)
        {
            // Moves Active Bullets of Enemies
            for (int i = 0; i < enemyBulletCount; i++)
            {
                if (isEnemyBulletActive[i] == true)
                {
                    char next = maze[enemyBulletY[i], enemyBulletX[i] - 1];

                    if (next == ' ')
                    {
                        eraseEnemyBullet(enemyBulletX[i], enemyBulletY[i], maze);
                        enemyBulletX[i] = enemyBulletX[i] - 1;
                        printEnemyBullet(enemyBulletX[i], enemyBulletY[i], maze);
                    }
                    else if (next != ' ')
                    {
                        eraseEnemyBullet(enemyBulletX[i], enemyBulletY[i], maze);
                        makeEnemyBulletInactive(i, ref isEnemyBulletActive);
                    }
                }
            }
        }

        static void makeEnemyBulletInactive(int idx, ref bool[] isEnemyBulletActive)
        {
            // Makes Enemy Bullet Inactive
            isEnemyBulletActive[idx] = false;
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
            Console.Write("~");
            maze[y, x] = '~';
        }

        static void moveBullet(char[,] maze, ref int[] bulletX, ref int[] bulletY, ref bool[] isBulletActive, int bulletCount)
        {
            // Moving functionality for Player's Bullet
            for (int i = 0; i < bulletCount; i++)
            {
                if (isBulletActive[i] == true)
                {
                    char next = maze[bulletY[i], bulletX[i] + 1];
                    if (next != ' ')
                    {
                        eraseBullet(bulletX[i], bulletY[i], maze);
                        makeBulletInactive(i, ref isBulletActive);
                    }

                    else
                    {
                        eraseBullet(bulletX[i], bulletY[i], maze);
                        bulletX[i] = bulletX[i] + 1;
                        printBullet(bulletX[i], bulletY[i], maze);
                    }
                }
            }
        }

        static void makeBulletInactive(int idx, ref bool[] isBulletActive)
        {
            // Makes Enemy Bullet Inactive
            isBulletActive[idx] = false;
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
            Console.Write(".");
            maze[y, x] = '.';
        }

        static void printRamboHealth(int towerHealth, int ramboX, int ramboY)
        {
            // Prints Tank Heealth at the left side of maze
            char heart = (char)3;
            Console.SetCursorPosition(120, 8);
            if (towerHealth <= 300 && towerHealth > 240)
            {
                Console.Write("Rambo: {0}{0}{0}{0}{0}", heart);
            }
            Console.SetCursorPosition(120, 8);
            if (towerHealth <= 240 && towerHealth > 180)
            {
                Console.Write("Rambo: {0}{0}{0}{0} ", heart);
            }
            Console.SetCursorPosition(120, 8);
            if (towerHealth <= 180 && towerHealth > 120)
            {
                Console.Write("Rambo: {0}{0}{0}  ", heart);
            }
            Console.SetCursorPosition(120, 8);
            if (towerHealth <= 120 && towerHealth > 60)
            {
                Console.Write("Rambo: {0}{0}   ", heart);
            }
            Console.SetCursorPosition(120, 8);
            if (towerHealth <= 60 && towerHealth > 0)
            {
                Console.Write("Rambo: {0}    ", heart);
            }
            Console.SetCursorPosition(120, 8);
            if (towerHealth <= 0)
            {
                Console.Write("Rambo:      ");
                Console.SetCursorPosition(ramboX, ramboY);
                removeRambo(ramboX, ramboY);

            }
        }

        static void bulletCollisionWithTower(char[,] maze, ref int towerHealth, int enemyFireDamage, int[] enemyBulletX, int[] enemyBulletY, bool[] isEnemyBulletActive, int enemyBulletCount)
        {
            // Detects Bullet Collision With Tower and reduces Health
            for (int x = 0; x < enemyBulletCount; x++)
            {
                if (isEnemyBulletActive[x] == true)
                {
                    char next = maze[enemyBulletY[x], enemyBulletX[x] - 1];
                    if (next == '!')
                    {
                        towerHealth = towerHealth - enemyFireDamage;
                    }
                }
            }
        }

        static void bulletCollisionWithInfantry(int[] bulletX, int[] bulletY, int infantryX, int infantryY, ref int infantryHealth, int bulletCount, bool[] isBulletActive, ref int score, char[,] maze)
        {
            for (int x = 0; x < bulletCount; x++)
            {
                if (isBulletActive[x] == true)
                {
                    if ((bulletX[x] == infantryX + 4) && (infantryY == bulletY[x]) || (bulletX[x] == infantryX + 5) && (infantryY == bulletY[x]) || (bulletX[x] == infantryX + 6) && (infantryY == bulletY[x]) || (bulletX[x] == infantryX + 7) && (infantryY == bulletY[x]) || (bulletX[x] == infantryX + 8) && (infantryY == bulletY[x]) || (bulletX[x] == infantryX + 9) && (infantryY == bulletY[x]))
                    {
                        addScore(ref score);
                        infantryHealth--;
                    }

                    else if ((bulletX[x] == infantryX - 2) && (infantryY + 1 == bulletY[x]) || (bulletX[x] == infantryX) && (infantryY + 1 == bulletY[x])
                            || (bulletX[x] == infantryX + 1) && (infantryY + 1 == bulletY[x]) || (bulletX[x] == infantryX + 2) && (infantryY + 1 == bulletY[x])
                            || (bulletX[x] == infantryX + 3) && (infantryY + 1 == bulletY[x]) || (bulletX[x] == infantryX + 4) && (infantryY + 1 == bulletY[x])
                            || (bulletX[x] == infantryX + 5) && (infantryY + 1 == bulletY[x]) || (bulletX[x] == infantryX + 6) && (infantryY + 1 == bulletY[x])
                            || (bulletX[x] == infantryX + 7) && (infantryY + 1 == bulletY[x]) || (bulletX[x] == infantryX + 8) && (infantryY + 1 == bulletY[x])
                            || (bulletX[x] == infantryX + 9) && (infantryY + 1 == bulletY[x]))
                    {
                        addScore(ref score);
                        infantryHealth--;
                    }

                    else if ((bulletX[x] == infantryX + 4) && (infantryY + 2 == bulletY[x]) || (bulletX[x] == infantryX + 7) && (infantryY + 2 == bulletY[x]) || (bulletX[x] == infantryX + 8) && (infantryY + 2 == bulletY[x]))
                    {
                        addScore(ref score);
                        infantryHealth--;
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
            char[,] rambo = new char[4, 9] { { '[', '=', '=', '=', '=', '=', '=', '=', backslash }, { '|', '=', '=', '=', '=', '=', '=', '=', '/' }, { '|', '|', ' ', '>', ' ', ' ', ' ', ' ', ' ' }, { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ' } };
            int cols;
            int rows = ramboY;
            for (int i = 0; i < 4; i++)
            {
                cols = ramboX;
                for (int j = 0; j < 9; j++)
                {
                    maze[rows, cols] = rambo[i,j];
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
                }
                rows++;
            }
        }

        static void moveTank(ref string tankDirection, ref int tankX, ref int tankY, char[,] maze)
        {
            // Infantry Moving Functionality
            if (tankDirection == "Down")
            {
                char next = maze[tankY + 4, tankX];
                if (next == ' ')
                {
                    eraseTank(tankX, tankY);
                    removeTankFromMaze(maze, tankX, tankY);
                    tankY++;
                    printTank(tankX, tankY);
                    addTankToMaze(maze, tankX, tankY);
                }
                if (next == '*')
                {
                    tankDirection = "Up";
                }
            }

            if (tankDirection == "Up")
            {
                char next = maze[tankY - 1, tankX];
                if (next == ' ')
                {
                    eraseTank(tankX, tankY);
                    removeTankFromMaze(maze, tankX, tankY);
                    tankY--;
                    printTank(tankX, tankY);
                    addTankToMaze(maze, tankX, tankY);
                }
                if (next == '*')
                {
                    tankDirection = "Down";
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

        static void printTankHealth(int tankHealth, int tankX, int tankY)
        {
            // Prints Tank Heealth at the left side of maze
            char heart = (char)3;
            Console.SetCursorPosition(120, 3);
            if (tankHealth <= 10 && tankHealth > 8)
            {
                Console.Write("Tank: {0}{0}{0}{0}{0}", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (tankHealth <= 8 && tankHealth > 6)
            {
                Console.Write("Tank: {0}{0}{0}{0} ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (tankHealth <= 6 && tankHealth > 4)
            {
                Console.Write("Tank: {0}{0}{0}  ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (tankHealth <= 4 && tankHealth > 2)
            {
                Console.Write("Tank: {0}{0}   ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (tankHealth <= 2 && tankHealth > 0)
            {
                Console.Write("Tank: {0}    ", heart);
            }
            Console.SetCursorPosition(120, 3);
            if (tankHealth <= 0)
            {
                Console.Write("Tank:      ", heart);
                Console.SetCursorPosition(tankX, tankY);
                eraseInfantry(tankX, tankY);
            }
        }

        static void bulletCollisionWithTank(int bulletCount, int[] bulletX, int[] bulletY, int tankX, int tankY, ref int score, ref int tankHealth, bool[] isBulletActive)
        {
            for (int x = 0; x < bulletCount; x++)
            {
                if (isBulletActive[x] == true)
                {
                    if (bulletX[x] + 1 == tankX && (bulletY[x] == tankY || bulletY[x] == tankY + 1 || bulletY[x] == tankY + 2))
                    {
                        addScore(ref score);
                        tankHealth--;
                    }
                    else if (tankX - 1 == bulletX[x] && tankY + 1 == bulletY[x])
                    {
                        addScore(ref score);
                        tankHealth--;
                    }
                }
            }
        }
    }
}
