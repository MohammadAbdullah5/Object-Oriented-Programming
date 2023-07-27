using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisness_Application.BL;
using Buisness_Application.DL;

namespace Buisness_Application.UI
{
    class PersonUI
    {
        public static Player takePlayerInput()
        {
            Console.Write("       Enter Player's Name: ");
            string name = Console.ReadLine();
            Console.Write("       Enter Player's Age: ");
            int age = int.Parse(validateInteger(Console.ReadLine()));
            Console.Write("       Enter Player's Role(Batter / Bowler / WK / AllRounder): ");
            string role = Console.ReadLine();
            Console.Write("       Enter Player's Batting Style(Left / Right): ");
            string battingStyle = validateBattingStyleRole(Console.ReadLine());
            Console.Write("       Enter Player's Bowling Style(Left / Right / No): ");
            string bowlingStyle = validateBowlingStyleRole(Console.ReadLine());
            Console.Write("       Enter Player's Salary: ");
            int salary = int.Parse(validateInteger(Console.ReadLine()));

            Credentials credentials = takeInputWithoutRole();
            credentials.setRole("Player");
            Console.Write("       Enter any key to continue...");
            string userEnter = Console.ReadLine();

            Player player = new Player(name, age, role, battingStyle, bowlingStyle, salary, credentials);
            return player;
        }

        public static Coach addCoach()
        {
            Console.Clear();
            MainUI.header();
            string userEnter = "";

            Console.Write("       Enter Coach's Name: ");
            string name = validateString(Console.ReadLine());
            Console.Write("       Enter Coach's Age: ");
            int age = int.Parse(validateInteger(Console.ReadLine()));
            Console.Write("       Enter Coach's Role(Head/ Batting / Bowling/ Fielding): ");
            string role = validateCoachesRole(Console.ReadLine());
            Console.Write("       Enter Coach's Salary: ");
            int salary = int.Parse(validateInteger(Console.ReadLine()));

            Credentials credentials = takeInputWithoutRole();
            credentials.setRole("Coach");
            userEnter = Console.ReadLine();
            Coach coach = new Coach(name, role, age, salary, credentials);
            return coach;
        }

        public static Credentials takeInputWithoutRole()
        {
            Console.Write("       Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("       Enter Password: ");
            string password = Console.ReadLine();

            if (username != null && password != null)
            {
                Credentials user = new Credentials(username, password);
                return user;
            }

            return null;
        }

        public static Credentials takeInputWithRole()
        {
            Console.Write("       Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("       Enter Password: ");
            string password = Console.ReadLine();
            Console.Write("       Enter Role: ");
            string role = Console.ReadLine();

            if (username != null && password != null && role != null)
            {
                Credentials user = new Credentials(username, password, role);
                return user;
            }

            return null;
        }

        public static void checkPlayingXI(List<Player> players)
        {
            string userEnter = "1";
            Console.WriteLine("      Name            Age            Role            Batting Style            Bowling Style            Salary");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("  " + "{6}" + "    {0}            {1}            {2}            {3}            {4}            {5}", players[i].getName(), players[i].getAge(), players[i].getPlayerRole(), players[i].getBattingStyle(), players[i].getBowlingStyle(), players[i].getSalary(), i + 1);

            }
            Console.WriteLine("Enter any key to exit");
            userEnter = Console.ReadLine();
        }

        public static void checkTeam(List<Player> players)
        {
            string userEnter = "1";
            Console.WriteLine("      Name            Age            Role            Batting Style            Bowling Style            Salary");
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine("  " + "{6}" + "    {0}            {1}            {2}            {3}            {4}            {5}", players[i].getName(), players[i].getAge(), players[i].getPlayerRole(), players[i].getBattingStyle(), players[i].getBowlingStyle(), players[i].getSalary(), i + 1);

            }
            Console.WriteLine("Enter any key to exit");
            userEnter = Console.ReadLine();
        }

        public static void checkMgmtStaff(List<Coach> coaches)
        {
            string userEnter = "1";
            Console.WriteLine("      Name            Age            Role            Salary");
            for (int i = 0; i < coaches.Count; i++)
            {
                Console.WriteLine("  " + "{4} " + "    {0}            {1}            {2}            {3}", coaches[i].getName(), coaches[i].getAge(), coaches[i].getCoachRole(), coaches[i].getSalary(), i + 1);

            }
            Console.WriteLine("       Enter any key to exit");
            userEnter = Console.ReadLine();
        }

        public static void checkFinances()
        {
            int sumPlayer = PersonDL.sumPlayerSalary();
            int sumCoach = PersonDL.sumCoachSalary();
            Console.WriteLine("       1. Player's Salary: {0}", sumPlayer);
            Console.WriteLine("       2. Coach's Salary: {0}", sumCoach);

            Console.WriteLine("       Enter 0 to exit.");
            Console.WriteLine("       Enter any other thing to continue...");
            string userEnter = Console.ReadLine();
        }

        public static void searchPlayer()
        {
            Console.Write("       Enter the name of Player: ");
            string search = Console.ReadLine();

            Player searchedPlayer = PersonDL.searchPlayer(search);
            if (searchedPlayer != null)
            {
                printPlayer(searchedPlayer);
            }

            else
            {
                Console.WriteLine("No such player was found...");
            }
            Console.ReadLine();
        }

        public static void printPlayer(Player searchedPlayer)
        {
            Console.WriteLine("       Player's Role: " + searchedPlayer.getPlayerRole());
            Console.WriteLine("       Player's Age: " + searchedPlayer.getAge());
            Console.WriteLine("       Player's Batting Style: " + searchedPlayer.getBattingStyle());
            Console.WriteLine("       Player's Bowling Style: " + searchedPlayer.getBowlingStyle());
            Console.WriteLine("       Player's Salary: " + searchedPlayer.getSalary());
        }

        public static void changeNameOfPlayer()
        {
            Console.Write("       Enter the current name of Player: ");
            string currentName = Console.ReadLine();
            Console.Write("       Enter the new name of Player: ");
            string newName = Console.ReadLine();
            bool flag = PersonDL.changePlayerName(currentName, newName);

            if(flag == true)
            {
                Console.WriteLine("       Name changed successfully");
            }

            else
            {
                Console.WriteLine("       No such player is found!!!"); 
            }
        }

        public static void checkStats(List<Player> players)
        {
            Console.Write("       Enter the name of Player: ");
            string name = Console.ReadLine();
            Console.Write("       Enter the role of Player: ");
            string role = Console.ReadLine();

            Player player = PersonDL.isValidPlayer(name, role);

            if(player != null)
            {
                printStats(player);
            }

            else
            {
                Console.WriteLine("No such player...");
            }
            Console.ReadLine();
        }

        public static void printStats(Player player)
        {
            Stats stats = player.getStats();
            Console.WriteLine("        Player Name: {0}", player.getName());
            Console.WriteLine("        Player Role: {0}", player.getPlayerRole());
            Console.WriteLine("        Innings: {0}", stats.getInnings());
            Console.WriteLine("        Runs: {0}", stats.getRuns());
            Console.WriteLine("        Wickets: {0}", stats.getWickets());
            Console.WriteLine("        High Score: {0}", stats.getHighScore());
            Console.WriteLine("        Average: {0}", stats.getAverage());
        }



        public static void addStats()
        {
            Console.Write("       Enter the name of Player: ");
            string name = Console.ReadLine();
            Console.Write("       Enter the role of Player: ");
            string role = Console.ReadLine();

            Player player = PersonDL.isValidPlayer(name, role);
            if (player != null)
            {
                Stats stats = addPerformance();
                player.addStats(stats);
            }

            else
            {
                Console.WriteLine("       No such player in the team...");
            }
        }

        public static Stats addPerformance()
        {
            Console.Write("       Runs: ");
            int runs = int.Parse(validateInteger(Console.ReadLine()));
            Console.Write("       Innings: ");
            int innings = int.Parse(validateInteger(Console.ReadLine()));
            Console.Write("       Wickets: ");
            int wickets = int.Parse(validateInteger(Console.ReadLine()));
            Console.Write("       High Score: ");
            int highScore = int.Parse(validateInteger(Console.ReadLine()));
            float average = runs / innings;

            Stats stats = new Stats(innings, runs, wickets, highScore, average);
            return stats;
        }

        public static void removePlayer()
        {
            Console.Write("       Enter the Name of Player: ");
            string name = Console.ReadLine();
            Console.Write("       Enter the Role of Player: ");
            string role = Console.ReadLine();

            int index = PersonDL.isValidPlayerAndReturnIndex(name, role);
            if(index != -1)
            {
                PersonDL.removePlayer(index);
            }

            else
            {
                Console.WriteLine("       No such player in the team...");
            }
        }

        public static void removeCoach()
        {
            Console.Write("       Enter the Name of Coach: ");
            string name = Console.ReadLine();
            Console.Write("       Enter the Role of Coach: ");
            string role = Console.ReadLine();

            int index = PersonDL.isValidCoachAndReturnIndex(name, role);
            if (index != -1)
            {
                PersonDL.removeCoach(index);
            }

            else
            {
                Console.WriteLine("       No such player in the team...");
            }
        }

        public static void changePlayingXI()
        {
            Console.Write("       Enter the index of player in Playing XI: ");
            int index = int.Parse(validateInteger(Console.ReadLine()));
            index--;
            Console.Write("       Enter the index of substitution player in Playing XI: ");
            int substituteIndex = int.Parse(validateInteger(Console.ReadLine()));
            substituteIndex--;

            PersonDL.changeplayingXI(index, substituteIndex);
        }

        public static void addFan()
        {
            Console.Write("       Enter your Name: ");
            string name = Console.ReadLine();
            Credentials user = takeInputWithoutRole();

            PersonDL.addUser(name, user);
        }

        public static string validateString(string line)
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

        public static string validatePlayerRole(string line)
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

        public static string validateCoachesRole(string line)
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
                if ((flag == true) && ((words == "Batting") || (words == "Bowling") || (words == "Head") || (words == "Fielding")))
                {
                    return words;
                }
                flag = false;
                if (flag == false)
                {
                    Console.Write("       Invalid Input.Enter only Batting, Bowling, Fielding or Head.Try Again.....");
                    words = "";
                    line = Console.ReadLine();
                    idx = 0;
                }
            }
            return "invalid";
        }

        public static string validateBattingStyleRole(string line)
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

        public static string validateBowlingStyleRole(string line)
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

        public static string validateInteger(string line)
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

    }

}