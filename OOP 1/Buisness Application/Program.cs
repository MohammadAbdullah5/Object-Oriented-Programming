using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int num = 20;
            const int clubPlayers = 25;
            const int clubCoaches = 3;

            string[] userNamesArray = new string[num];
            string[] userPasswordsArray = new string[num];
            string[] userRolesArray = new string[num];
            string[] clubPlayerName = new string[clubPlayers];
            string[] clubPlayerRole = new string[clubPlayers];
            string[] clubPlayerBattingStyle = new string[clubPlayers];
            string[] clubPlayerBowlingStyle = new string[clubPlayers];
            int[] clubPlayersAge = new int[clubPlayers];
            int[] clubPlayersSalary = new int[clubPlayers];
            string[] clubCoachesName = new string[clubCoaches];
            string[] clubCoachesRole = new string[clubCoaches];
            int[] clubCoachesAge = new int[clubCoaches];
            int[] clubCoachesSalary = new int[clubCoaches];
            int[] clubPlayerInnings = new int[clubPlayers];
            int[] clubPlayerRuns = new int[clubPlayers];
            int[] clubPlayerWickets = new int[clubPlayers];
            int[] clubPlayerHighScore = new int[clubPlayers];
            float[] clubPlayerAverage = new float[clubPlayers];

            int usersCount = 1;
            int currentPlayers = 0;
            int currentCoaches = 0;
            loadData(userNamesArray, userPasswordsArray, userRolesArray, ref usersCount);
            string option = "";

            userNamesArray[0] = "admin";
            userPasswordsArray[0] = "5678";
            userRolesArray[0] = "Admin";

            welcome();

            do
            {
                option = Menu();

                if (option == "1")
                {
                    string username, password, role;
                    Console.Write("       Enter Username: ");
                    username = Console.ReadLine();
                    Console.Write("       Enter Password: ");
                    password = Console.ReadLine();

                    role = login(username, password, userNamesArray, userPasswordsArray, userRolesArray, usersCount);

                    if (role == "Admin")
                    {
                        Console.Clear();
                        adminInterface(userNamesArray, userPasswordsArray, userRolesArray, ref usersCount, clubCoachesName, clubCoachesAge, clubCoachesRole, clubCoachesSalary, clubPlayerAverage, clubPlayerBattingStyle, clubPlayerBowlingStyle, clubPlayerHighScore, clubPlayerInnings, clubPlayerName, clubPlayerRole, clubPlayerRuns, clubPlayersAge, clubPlayersSalary, clubPlayerWickets, ref currentCoaches, ref currentPlayers);
                    }

                    else if (role == "Coach")
                    {
                        Console.Clear();
                        //CoachInterface();
                    }

                    else if (role == "Player")
                    {
                        Console.Clear();
                        //PlayersInterface();
                    }

                    else if (role == "Fans")
                    {
                        Console.Clear();
                        //Fans Interface
                    }

                    else
                    {
                        Console.Clear();
                        Console.Write("Wrong Credentials.Try Again!!!");
                        Console.ReadKey();
                    }
                }
            }
            while (option != "2");

            storeCricketersData(currentPlayers, clubPlayerName, clubPlayerRole, clubPlayerBattingStyle, clubPlayerBowlingStyle, clubPlayersAge, clubPlayersSalary);
            storeUsersData(userNamesArray, userPasswordsArray, userRolesArray, usersCount);
        }

        static void adminInterface(string [] userNamesArray, string[] userPasswordsArray, string[] userRolesArray, ref int usersCount, string[] clubCoachesName, int[] clubCoachesAge, string[] clubCoachesRole, int[] clubCoachesSalary, float[] clubPlayerAverage, string[] clubPlayerBattingStyle, string[] clubPlayerBowlingStyle, int[] clubPlayerHighScore, int[] clubPlayerInnings, string[] clubPlayerName, string[] clubPlayerRole, int[] clubPlayerRuns, int[] clubPlayersAge, int[] clubPlayersSalary, int[] clubPlayerWickets, ref int currentCoaches, ref int currentPlayers)
        {
            string adminOption = "";
            do
            {
                adminOption = adminMenu();

                if (adminOption == "1")
                {
                    header();
                    addPlayer(clubPlayerName, clubPlayerRole, clubPlayerBattingStyle, clubPlayerBowlingStyle, clubPlayersAge, clubPlayersSalary, ref currentPlayers);
                }

                else if (adminOption == "2")
                {
                    header();
                    removePlayer(clubPlayerName, clubPlayersAge, clubPlayerBattingStyle, clubPlayerBowlingStyle, clubPlayerRole, clubPlayersSalary, ref currentPlayers, clubPlayerRuns, clubPlayerWickets, clubPlayerHighScore, clubPlayerAverage, clubPlayerInnings);
                }

                else if (adminOption == "3")
                {
                    header();
                    checkFinances(currentPlayers, clubPlayersSalary, clubCoachesSalary, currentCoaches);
                }

                else if (adminOption == "4")
                {
                    header();
                    searchPlayer(currentPlayers, clubPlayerName, clubPlayerRole, clubPlayerBattingStyle, clubPlayerBowlingStyle, clubPlayersSalary);
                }

                else if (adminOption == "11")
                {
                    header();
                    changePlayerName(clubPlayerName, clubPlayerRole, currentPlayers);
                }

                else if (adminOption == "13")
                {
                    header();
                    addUser(userNamesArray, userPasswordsArray, userRolesArray ,ref usersCount);
                }
            }
            while (adminOption != "14");
        }

        static string adminMenu()
        {
            header();

            Console.WriteLine("        1. Add a player.");
            Console.WriteLine("        2. Remove a player.");
            Console.WriteLine("        3. Check Finances.");
            Console.WriteLine("        4. Search a player.");
            Console.WriteLine("        5. Add a coach.");
            Console.WriteLine("        6. Remove a coach.");
            Console.WriteLine("        7. Add Achievements.");
            Console.WriteLine("        8. Set Ticket Prices.");
            Console.WriteLine("        9. Check Team.");
            Console.WriteLine("        10. Check Management Staff.");
            Console.WriteLine("        11. Change a player's name.");
            Console.WriteLine("        12. Schedule a match.");
            Console.WriteLine("        13. Add User.");
            Console.WriteLine("        14. Exit.");
            Console.Write("Enter an option...");
            string option;
            option = Console.ReadLine();
            return option;
        }

        static string login(string name, string password, string[] usernamesData, string[] userPasswordsData, string[] userRolesData, int usersCount)
        {
            for (int idx = 0; idx < usersCount; idx++)
            {
                if ((name == usernamesData[idx]) && (password == userPasswordsData[idx]))
                {
                    return userRolesData[idx];
                }
            }
            return "nothing";
        }

        static string Menu()
        {
            header();

            Console.ForegroundColor = ConsoleColor.Blue;

            string option;
            Console.WriteLine("       1. Sign In");
            Console.WriteLine("       2. Exit");
            option = Console.ReadLine();
            return option;
        }

        static string parseWord(string line, int field)
        {
            int commaCount = 1;
            string reqdWord = "";
            for (int idx = 0; idx < line.Length; idx++)
            {
                if (line[idx] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == field)
                {
                    reqdWord = reqdWord + line[idx];
                }
            }
            return reqdWord;
        }

        static void loadData(string[] names, string[] passwords, string[] roles, ref int count)
        {
            string line;
            StreamReader file = new StreamReader("C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Data.txt");
            while ((line = file.ReadLine()) != null)
            {
                names[count] = parseWord(line, 1);
                passwords[count] = parseWord(line, 2);
                roles[count] = parseWord(line, 3);
                count++;
            }
            file.Close();
        }

        static void LoadCricketersData(string[] PlayerName, string[] PlayersRole, string[] BattingStyle, string[] BowlingStyle, int[] age, int[] salary, ref int playersCount)
        {
            string line = "";
            StreamReader file = new StreamReader("C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\CricketersData.txt");
            while ((line = file.ReadLine()) != null)
            {
                PlayerName[playersCount] = parseWord(line, 1);
                PlayersRole[playersCount] = parseWord(line, 2);
                BattingStyle[playersCount] = parseWord(line, 3);
                BowlingStyle[playersCount] = parseWord(line, 4);
                age[playersCount] = int.Parse(parseWord(line, 5));
                salary[playersCount] = int.Parse(parseWord(line, 6));
                playersCount++;
                file.Close();
            }
        }

        static void addPlayer(string[] playersName, string[] role, string[] battingStyle, string[] bowlingStyle, int[] age, int[] salary, ref int playersCount)
        {
            Console.Clear();
            //header();
            string userEnter = "";

            while (userEnter != "0")
            {
                Console.Write("       Enter Player's Name: ");
                playersName[playersCount] = validateString(Console.ReadLine());
                Console.Write("       Enter Player's Age: ");
                age[playersCount] = int.Parse(validateInteger(Console.ReadLine()));
                Console.Write("       Enter Player's Role(Batter / Bowler / WK / AllRounder): ");
                role[playersCount] = validatePlayerRole(Console.ReadLine());
                Console.Write("       Enter Player's Batting Style(Left / Right): ");
                battingStyle[playersCount] = validateBattingStyleRole(Console.ReadLine());
                Console.Write("       Enter Player's Bowling Style(Left / Right / No): ");
                bowlingStyle[playersCount] = validateBowlingStyleRole(Console.ReadLine());
                Console.Write("       Enter Player's Salary: ");
                salary[playersCount] = int.Parse(validateInteger(Console.ReadLine()));
                playersCount++;
                Console.Write("       Enter 0 to exit and any other key to continue...");
                userEnter = Console.ReadLine();
            }

        }

        static void removePlayer(string[] clubPlayersName, int[] clubPlayersAge, string[] clubPlayersBattingStyle, string[] clubPlayersBowlingStyle, string[] clubPlayersRole, int[] clubPlayersSalary, ref int currentPlayers, int[] runs, int[] wickets, int[] Highscore, float[] average, int[] innings)
        {
            string removingPlayer;
            Console.Write("Enter the name of Player: ");
            removingPlayer = validateString(Console.ReadLine());
            int removingIdx = -1;
            for (int idx = 0; idx < currentPlayers; idx++)
            {
                if (removingPlayer == clubPlayersName[idx])
                {
                    removingIdx = idx;
                }
            }
            if (removingIdx == -1)
            {
                Console.Write("There is no such Player in the team.Enter anything to Exit...");
                Console.ReadLine();
                return;
            }
            for (int i = removingIdx; i < currentPlayers - 1; i++)
            {
                clubPlayersName[i] = clubPlayersName[i + 1];
                clubPlayersAge[i] = clubPlayersAge[i + 1];
                clubPlayersBattingStyle[i] = clubPlayersBattingStyle[i + 1];
                clubPlayersBowlingStyle[i] = clubPlayersBowlingStyle[i + 1];
                clubPlayersRole[i] = clubPlayersRole[i + 1];
                clubPlayersSalary[i] = clubPlayersSalary[i + 1];
                runs[i] = runs[i + 1];
                average[i] = average[i + 1];
                innings[i] = innings[i + 1];
                wickets[i] = wickets[i + 1];
                Highscore[i] = Highscore[i + 1];
            }
            currentPlayers--;
            Console.Write("Enter to exit..");
            Console.ReadLine();
        }

        static string validateString(string line)
        {
            char ch;
            int ascii;
            int idx = 0;
            string words = "";
            bool flag = true;
            bool outerLoop = true;
            while (outerLoop == true)
            {
                int num = line.Length;
                while (idx < num)
                {
                    flag = true;
                    ch = line[idx];
                    ascii = (int)ch;
                    if (((ascii > 64) && (ascii <= 91)) || ((ascii > 96) && (ascii <= 122)) || (ascii == 32))
                    {
                        words = words + line[idx];
                    }
                    else if (((ascii < 64) || (ascii > 92)) && ((ascii < 96) || (ascii > 122)))
                    {
                        flag = false;
                    }
                    idx++;
                }
                if (flag == false)
                {
                    Console.Write("       Invalid Input.Enter only Alphabets or Space.Try Again.....");
                    words = "";
                    line = Console.ReadLine();
                    idx = 0;
                }
                if (flag == true)
                {
                    return words;
                }
            }
            return "invalid";
        }

        static string validatePlayerRole(string line)
        {
            char ch;
            int ascii;
            int idx = 0;
            string words = "";
            bool flag = true;
            bool outerLoop = true;
            while (outerLoop == true)
            {
                int num = line.Length;
                while (idx < num)
                {
                    flag = true;
                    ch = line[idx];
                    ascii = (int)ch;
                    if (((ascii > 64) && (ascii <= 91)) || ((ascii > 96) && (ascii <= 122)))
                    {
                        words = words + line[idx];
                    }
                    else if (((ascii < 64) || (ascii > 92)) && ((ascii < 96) || (ascii > 122)))
                    {
                        flag = false;
                        break;
                    }
                    idx++;
                }
                if ((flag == true) && ((words == "Batter") || (words == "Bowler") || (words == "WK") || (words == "AllRounder")))
                {
                    return words;
                }
                flag = false;
                if (flag == false)
                {
                    Console.Write("       Invalid Input.Enter only Batter, Bowler, WK or AllRounder.Try Again.....");
                    words = "";
                    line = Console.ReadLine();
                    idx = 0;
                }
            }
            return "invalid";
        }

        static string validateBattingStyleRole(string line)
        {
            char ch;
            int ascii;
            int idx = 0;
            string words = "";
            bool flag = true;
            bool outerLoop = true;
            while (outerLoop == true)
            {
                int num = line.Length;
                while (idx < num)
                {
                    flag = true;
                    ch = line[idx];
                    ascii = (int)ch;
                    if (((ascii > 64) && (ascii <= 91)) || ((ascii > 96) && (ascii <= 122)))
                    {
                        words = words + line[idx];
                    }
                    else if (((ascii < 64) || (ascii > 92)) && ((ascii < 96) || (ascii > 122)))
                    {
                        flag = false;
                        break;
                    }
                    idx++;
                }
                if ((flag == true) && ((words == "Left") || (words == "Right")))
                {
                    return words;
                }
                flag = false;
                if (flag == false)
                {
                    Console.Write("       Invalid Input.Enter only Left or Right.Try Again.....");
                    words = "";
                    line = Console.ReadLine();
                    idx = 0;
                }
            }
            return "invalid";
        }

        static string validateBowlingStyleRole(string line)
        {
            char ch;
            int ascii;
            int idx = 0;
            string words = "";
            bool flag = true;
            bool outerLoop = true;
            while (outerLoop == true)
            {
                int num = line.Length;
                while (idx < num)
                {
                    flag = true;
                    ch = line[idx];
                    ascii = (int)ch;
                    if (((ascii > 64) && (ascii <= 91)) || ((ascii > 96) && (ascii <= 122)))
                    {
                        words = words + line[idx];
                    }
                    else if (((ascii < 64) || (ascii > 92)) && ((ascii < 96) || (ascii > 122)))
                    {
                        flag = false;
                        break;
                    }
                    idx++;
                }
                if ((flag == true) && ((words == "Left") || (words == "Right") || (words == "No")))
                {
                    return words;
                }
                flag = false;
                if (flag == false)
                {
                    Console.Write("       Invalid Input.Enter only Batter, Bowler, WK or AllRounder.Try Again.....");
                    words = "";
                    line = Console.ReadLine();
                    idx = 0;
                }
            }
            return "invalid";
        }

        static string validateInteger(string line)
        {
            char ch;
            int ascii;
            int idx = 0;
            string num = "";
            bool flag = true;
            bool outerLoop = true;
            while (outerLoop == true)
            {
                int len = line.Length;
                while (idx < len)
                {
                    flag = true;
                    ch = line[idx];
                    ascii = (int)ch;
                    if ((ascii > 47) && (ascii < 58))
                    {
                        num = num + line[idx];
                    }
                    else if ((ascii <= 47) || (ascii >= 58))
                    {
                        flag = false;
                    }
                    idx++;
                }

                if (flag == true)
                {
                    return num;
                }

                if (flag == false)
                {
                    Console.WriteLine("       Invalid Input.Try Again");
                    num = "";
                    line = Console.ReadLine();
                    idx = 0;
                    continue;
                }
            }
            return "1";
        }

        static void checkFinances(int currentPlayers, int[] clubPlayersSalary, int[] clubCoachesSalary, int currentCoaches)
        {
            int sumPlayer = 0;
            int sumCoach = 0;
            string userEnter = "1";
            while (userEnter != "0")
            {
                for (int idx = 0; idx < currentPlayers; idx++)
                {
                    sumPlayer = sumPlayer + clubPlayersSalary[idx];
                }
                for (int idx = 0; idx < currentCoaches; idx++)
                {
                    sumCoach = sumCoach + clubCoachesSalary[idx];
                }
                Console.WriteLine("       1. Player's Salary: {0}", sumPlayer);
                Console.WriteLine("       2. Coach's Salary: {0}", sumCoach);

                Console.WriteLine("       Enter 0 to exit.");
                Console.WriteLine("       Enter any other thing to continue...");
                userEnter = Console.ReadLine();
            }
        }

        static void searchPlayer(int clubPlayers, string[] clubPlayersName, string[] clubPlayersRole, string[] clubPlayersBattingStyle, string[] clubPlayersBowlingStyle, int[] clubPlayersSalary)
        {
            string search;
            bool flag = false;
            string userEnter = "1";
            while (userEnter != "0")
            {
                Console.Write("       Enter the player's name: ");
                search = Console.ReadLine();

                for (int idx = 0; idx < clubPlayers; idx++)
                {
                    if (search == clubPlayersName[idx])
                    {
                        flag = true;
                        Console.WriteLine("       The player is at index {0}", idx);
                        Console.WriteLine("       Player's Role: {0}", clubPlayersRole[idx]);
                        Console.WriteLine("       Player's Batting Style: {0}", clubPlayersBattingStyle[idx]);
                        Console.WriteLine("       Player's Bowling Style: {0}", clubPlayersBowlingStyle[idx]);
                        Console.WriteLine("       Player's Salary: {0}", clubPlayersSalary[idx]);
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("       There is no such player in the team.");
                }
                Console.WriteLine("       Do you want to continue?");
                Console.WriteLine("       Enter 0 to exit.Enter any other number to continue...");
                userEnter = Console.ReadLine();
            }
        }

        static void changePlayerName(string[] clubPlayersName, string[] clubPlayersRole, int currentPlayers)
        {
            string userEnter = "1";
            string name, role;
            string correctName;
            bool decision;
            while (userEnter != "0")
            {
                Console.Write("       Name of player which was recorded previously: ");
                name = validateString(Console.ReadLine());

                Console.Write("       His Role: ");
                role = validateString(Console.ReadLine());

                decision = isValidPlayer(name, role, clubPlayersName, clubPlayersRole, currentPlayers);
                if (decision == true)
                {
                    for (int idx = 0; idx < currentPlayers; idx++)
                    {
                        if ((name == clubPlayersName[idx]) && (role == clubPlayersRole[idx]))
                        {
                            Console.Write("       Write the corrected name: ");
                            correctName = validateString(Console.ReadLine());
                            clubPlayersName[idx] = correctName;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("       There is no such player...");
                }

                Console.WriteLine("       Do you want to continue?");
                Console.Write("       Enter 0 to exit.Enter any other number to continue...");
                userEnter = Console.ReadLine();
            }
        }

        static bool isValidPlayer(string name, string role, string[] clubPlayersName, string[] clubPlayersRole, int currentPlayers)
        {
            for (int idx = 0; idx < currentPlayers; idx++)
            {
                if ((name == clubPlayersName[idx]) && (role == clubPlayersRole[idx]))
                {
                    return true;
                }
            }
            return false;
        }

        static void addUser(string[] names, string[] pass, string[] roles, ref int usersCount)
        {
            Console.Write("Enter Name: ");
            string newUser = Console.ReadLine();
            Console.Write("Enter Password: ");
            string newPass = Console.ReadLine();
            Console.Write("Enter Role: ");
            string newRole = Console.ReadLine();
            
            if (newRole == "Coach" || newRole == "Players" || newRole == "Fans")
            {
                if (usersCount <= 99)
                {
                    
                    names[usersCount] = newUser;
                    pass[usersCount] = newPass;
                    roles[usersCount] = newRole;
                    usersCount++;
                }
                else
                {
                    Console.WriteLine("User Limit Exceeded.");
                }
            }
            else
            {
                Console.WriteLine("Invalid User type");            
            }

        }

        static void storeUsersData(string[] usernames, string[] passwords, string[] roles, int usersCount)
        {
            string usersPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Data.txt";
            StreamWriter file = new StreamWriter(usersPath, false);
            for (int x = 0; x < usersCount; x++)
            {
                file.WriteLine(usernames[x] + "," + passwords[x] + "," + roles[x]);
            }
            file.Flush();
            file.Close();
        }

        static void storeCricketersData(int currentPlayers, string[] clubPlayersName, string[] clubPlayersRole, string[] clubPlayersBattingStyle, string[] clubPlayersBowlingStyle, int[] clubPlayersAge, int[] clubPlayersSalary)
        {
            string usersPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\CricketersData.txt";
            StreamWriter file = new StreamWriter(usersPath, false);
            for (int idx = 0; idx < currentPlayers; idx++)
            {
                if ((idx == (currentPlayers - 1)) && (idx != 0))
                {
                    file.WriteLine(clubPlayersName[idx] + "," + clubPlayersRole[idx] + "," + clubPlayersBattingStyle[idx] + "," + clubPlayersBowlingStyle[idx] + "," + clubPlayersAge[idx] + "," + clubPlayersSalary[idx]);
                }
                else
                {
                    file.Write(clubPlayersName[idx] + "," + clubPlayersRole[idx] + "," + clubPlayersBattingStyle[idx] + "," + clubPlayersBowlingStyle[idx] + "," + clubPlayersAge[idx] + "," + clubPlayersSalary[idx]);
                }
            }

            file.Flush();
            file.Close();
        }

        static void header()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("             _________        .__        __           __    _________ .__       ___.                                                          ");
            Console.WriteLine("             \\_   ___ \\_______|__| ____ |  | __ _____/  |_  \\_   ___ \\|  |  __ _\\_ |__                                                   ");
            Console.WriteLine("             /    \\  \\/\\_  __ \\  |/ ___\\|  |/ // __ \\   __\\ /    \\  \\/|  | |  |  \\ __ \\                                            ");
            Console.WriteLine("             \\     \\____|  | \\/  \\  \\___|    <\\  ___/|  |   \\     \\___|  |_|  |  / \\_\\ \\                                           ");
            Console.WriteLine("              \\______  /|__|  |__|\\___  >__|_ \\\\___  >__|    \\______  /____/____/|___  /                                                 ");
            Console.WriteLine("                     \\/               \\/     \\/    \\/               \\/               \\/                                                 ");
            Console.WriteLine("     _____                                                             __      _________               __                                     ");
            Console.WriteLine("   /     \\ _____    ____ _____     ____   ____   _____   ____   _____/  |_   /   _____/__.__. _______/  |_  ____   _____                     ");
            Console.WriteLine("  /  \\ /  \\\\__  \\  /    \\\\__  \\   / ___\\_/ __ \\ /     \\_/ __ \\ /    \\   __\\  \\_______<   |  |/  ___/\\   __\\/ __ \\ /     \\   ");
            Console.WriteLine(" /    Y    \\/ __ \\|   |  \\/ __ \\_/ /_/  >  ___/|  Y Y  \\  ___/|   |  \\  |    /        \\___  |\\___ \\  |  | \\  ___/|  Y Y  \\         ");
            Console.WriteLine(" \\____|__  (____  /___|  (____  /\\___  / \\___  >__|_|  /\\___  >___|  /__|   /_______  / ____/____  > |__|  \\___  >__|_|  /               ");
            Console.WriteLine("         \\/     \\/     \\/     \\//_____/      \\/      \\/     \\/     \\/               \\/\\/         \\/            \\/      \\/        ");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        static void welcome()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                        d8b             888                   888   ");
            Console.WriteLine("                                        888                   888   ");
            Console.WriteLine("                                        888                   888   ");
            Console.WriteLine("     .d8888b8  88d888   888    .d8888   b888 .d88    .d88b.   888888");
            Console.WriteLine("    d88P       888P     888   d88P      888.d88P     d8  8    Y8b   ");
            Console.WriteLine("    Y88b.      888      888   Y88b.     888  .d88    Y8b/     Y88   ");
            Console.WriteLine("      Y8888P   888      888     Y8888   P888    88    Y8888    Y8880");

            Console.Write("Enter any key to continue...");
            Console.ReadLine();
        }
    }
}


