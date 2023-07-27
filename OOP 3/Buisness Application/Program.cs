using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp3.BL;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            List<Coach> coach = new List<Coach>();
            List<Credentials> users = new List<Credentials>();
            List<MatchSchedule> matchSchedules = new List<MatchSchedule>();
            List<TrainingSchedule> trainingSchedules = new List<TrainingSchedule>();
            List<string> achievements = new List<string>();
            int ticketPrices = 1;
            int usersCount = 1;
            int currentPlayers = 0;
            int currentCoaches = 0;
            loadAchievements(achievements);
            LoadCricketersData(players, ref currentPlayers);
            LoadCoachesData(coach, ref currentPlayers);
            loadSchedule(matchSchedules);
            loadData(ref usersCount, users);
            loadTraining(trainingSchedules);
            string option = "";

            welcome();

            do
            {
                option = Menu();

                if (option == "1")
                {
                    Credentials user = takeInputWithoutRole();
                    if (user != null)
                    {
                        user = login(user, users);

                        if (user.role == "Admin")
                        {
                            Console.Clear();
                            adminInterface(ref usersCount, ref currentCoaches, ref currentPlayers, users, players, coach, achievements, ref ticketPrices, matchSchedules);
                        }

                        else if (user.role == "Coach")
                        {
                            Console.Clear();
                            coachInterface(ref currentPlayers, players, achievements, matchSchedules, trainingSchedules);
                        }

                        else if (user.role == "Player")
                        {
                            Console.Clear();
                            PlayersInterface(matchSchedules, players, achievements, trainingSchedules);
                        }

                        else if (user.role == "Fan")
                        {
                            Console.Clear();
                            fansInterface(players, matchSchedules, achievements);
                        }
                    }

                    if (user == null)
                    {
                        Console.Write("Wrong Credentials.Try Again!!!");
                        Console.ReadKey();
                    }
                }

                if (option == "2")
                {
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();
                    string role = "Fan";

                    Credentials fans = new Credentials(username, password, role);
                    storeDataInList(users, fans);
                }
            }
            while (option != "3");

            storeCricketersData(players);
            storeUsersData(users);
            storeAchievements(achievements);
            storeSchedule(matchSchedules);
            storeTraining(trainingSchedules);
        }

        static void fansInterface(List<Player> players, List<MatchSchedule> matchSchedules, List<string> achievements)
        {
            string fanOption = "0";
            while (fanOption != "4")
            {
                Console.Clear();
                header();
                fanOption = fanMenu();
                Console.Clear();

                if (fanOption == "1")
                {
                    header();
                    checkSchedule(matchSchedules);
                }

                else if (fanOption == "2")
                {
                    header();
                    checkStats(players);
                }

                else if (fanOption == "3")
                {
                    header();
                    checkAchievements(achievements);
                }

                else if (fanOption == "4")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("\tInvalid Input.Try Again.");
                    Console.ReadKey();
                }
            }
        }

        static string fanMenu()
        {
            Console.WriteLine("1. Check Schedule.");
            Console.WriteLine("2. Check Statistics of players");
            Console.WriteLine("3. Check Achievements");
            Console.WriteLine("4. Exit");
            string option;
            Console.Write("Enter your option...");
            option = Console.ReadLine();
            return option;
        }

        static void PlayersInterface(List<MatchSchedule> matchSchedules, List<Player> players, List<string> achievements, List<TrainingSchedule> trainingSchedules)
        {
            string playerOption = "0";
            while (playerOption != "6")
            {
                Console.Clear();
                header();
                playerOption = playerMenu();
                Console.Clear();

                if (playerOption == "1")
                {
                    header();
                    checkSchedule(matchSchedules);
                }

                else if (playerOption == "2")
                {
                    header();
                    checkPlayingXI(players);
                }

                else if (playerOption == "3")
                {
                    header();
                    checkStats(players);
                }

                else if (playerOption == "4")
                {
                    header();
                    checkAchievements(achievements);
                }

                else if (playerOption == "5")
                {
                    header();
                    checkTrainingSchedule(trainingSchedules);
                }

                else if (playerOption == "6")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid Input.Try Again.");
                    Console.ReadKey();
                }
            }
        }

        static void checkTrainingSchedule(List<TrainingSchedule> trainingSchedules)
        {
            string userEnter = "1";
            Console.WriteLine("\t                       Date        Time");
            for (int idx = 0; idx < trainingSchedules.Count; idx++)
            {
                Console.WriteLine("Training Session " + "{0} " + ". " + trainingSchedules[idx].date + "    " + trainingSchedules[idx].time, idx + 1);
            }
            Console.Write("\tEnter any key to exit.");
            userEnter = Console.ReadLine();
        }

        static void checkPlayingXI(List<Player> players)
        {
            string userEnter = "1";

            for (int idx = 0; idx < players.Count; idx++)
            {
                Console.WriteLine("{0} " + ". " + players[idx].name, idx + 1);
            }
            Console.WriteLine("Enter any key to exit.");
            userEnter = Console.ReadLine();
        }

        static string playerMenu()
        {
            Console.WriteLine("       1. Check Schedule.");
            Console.WriteLine("       2. Check Playing XI.");
            Console.WriteLine("       3. Check Statistics.");
            Console.WriteLine("       4. Check Achievements.");
            Console.WriteLine("       5. Check Training Schedule.");
            Console.WriteLine("       6. Exit.");
            string option;
            Console.Write("       Enter an option...");
            option = Console.ReadLine();
            return option;
        }

        static Player takePlayerInput()
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
            Console.Write("       Enter any key to continue...");
            string userEnter = Console.ReadLine();

            Player player = new Player(name, age, role, battingStyle, bowlingStyle, salary);
            return player;
        }

        static void addPlayerToList(List<Player> players, Player player)
        {
            players.Add(player);
        }

        static void adminInterface(ref int usersCount, ref int currentCoaches, ref int currentPlayers, List<Credentials> users, List<Player> players, List<Coach> coaches, List<string> achievements, ref int ticketPrices, List<MatchSchedule> matchSchedules)
        {
            string adminOption = "";
            do
            {
                adminOption = adminMenu();

                if (adminOption == "1")
                {
                    header();
                    Player player = takePlayerInput();
                    addPlayerToList(players, player);
                }

                else if (adminOption == "2")
                {
                    header();
                    removePlayer(players);
                }

                else if (adminOption == "3")
                {
                    header();
                    checkFinances(players, coaches);
                }

                else if (adminOption == "4")
                {
                    header();
                    Player player = searchPlayer(players);
                    if (player != null)
                    {
                        Console.WriteLine("       Player's Role: {0}", player.role);
                        Console.WriteLine("       Player's Batting Style: {0}", player.battingStyle);
                        Console.WriteLine("       Player's Bowling Style: {0}", player.bowlingStyle);
                        Console.WriteLine("       Player's Salary: {0}", player.salary);
                    }
                }

                else if (adminOption == "5")
                {
                    header();
                    addCoach(ref currentCoaches, coaches);
                }

                else if (adminOption == "6")
                {
                    header();
                    removeCoach(ref currentCoaches, coaches);
                }

                else if (adminOption == "7")
                {
                    header();
                    addAchievements(achievements);
                }

                else if (adminOption == "8")
                {
                    header();
                    setTicketPrices(ref ticketPrices);
                }

                else if (adminOption == "9")
                {
                    header();
                    checkTeam(players);
                }

                else if (adminOption == "10")
                {
                    header();
                    checkMgmtStaff(coaches);
                }

                else if (adminOption == "11")
                {
                    header();
                    changePlayerName(players, currentPlayers);
                }

                else if (adminOption == "12")
                {
                    header();
                    scheduleMatch(matchSchedules);
                }

                else if (adminOption == "13")
                {
                    header();
                    addUser(ref usersCount, users);
                }
            }
            while (adminOption != "14");
        }

        static void coachInterface(ref int currentPlayers, List<Player> players, List<string> achievements, List<MatchSchedule> matchSchedules, List<TrainingSchedule> trainingSchedules)
        {
            string coachOption = "";
            do
            {
                coachOption = coachMenu();

                if (coachOption == "1")
                {
                    header();
                    Player player = takePlayerInput();
                    addPlayerToList(players, player);
                }

                else if (coachOption == "2")
                {
                    header();
                    removePlayer(players);
                }

                else if (coachOption == "3")
                {
                    header();
                    Player player = searchPlayer(players);
                    if (player != null)
                    {
                        Console.WriteLine("       Player's Role: {0}", player.role);
                        Console.WriteLine("       Player's Batting Style: {0}", player.battingStyle);
                        Console.WriteLine("       Player's Bowling Style: {0}", player.bowlingStyle);
                        Console.WriteLine("       Player's Salary: {0}", player.salary);
                    }
                }

                else if (coachOption == "4")
                {
                    header();
                    checkSchedule(matchSchedules);
                }

                else if (coachOption == "5")
                {
                    header();
                    checkTeam(players);
                }

                else if (coachOption == "6")
                {
                    header();
                    changePlayingXI(players);
                }

                else if (coachOption == "7")
                {
                    header();
                    checkStats(players);
                }

                else if (coachOption == "8")
                {
                    header();
                    scheduleTraining(trainingSchedules);
                }

                else if (coachOption == "9")
                {
                    header();
                    checkAchievements(achievements);
                }

                else if (coachOption == "10")
                {
                    header();
                    addPlayerPerformance(players);
                }

                else if (coachOption == "11")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("       Invalid Input.Try Again.");
                    Console.ReadKey();
                }
            }
            while (coachOption != "11");
        }

        static void addPlayerPerformance(List<Player> players)
        {
            string userEnter = "1";
            string name, role;
            bool decision;

            while (userEnter != "0")
            {
                Console.Write("       Player's name: ");
                name = validateString(Console.ReadLine());
                Console.Write("       Player's Role: ");
                role = validateString(Console.ReadLine());
                decision = isValidPlayer(name, role, players);
                if (decision == true)
                {
                    for (int idx = 0; idx < players.Count; idx++)
                    {
                        if ((players[idx].name == name))
                        {
                            Console.Write("       Runs: ");
                            players[idx].runs = int.Parse(validateInteger(Console.ReadLine()));
                            Console.Write("       Innings: ");
                            players[idx].innings = int.Parse(validateInteger(Console.ReadLine()));
                            Console.Write("       Wickets: ");
                            players[idx].innings = int.Parse(validateInteger(Console.ReadLine()));
                            Console.Write("       High Score: ");
                            players[idx].innings = int.Parse(validateInteger(Console.ReadLine()));
                            players[idx].average = (float)players[idx].runs / (float)players[idx].innings;
                        }
                    }

                    Console.WriteLine("        Do you want to continue?");
                    Console.WriteLine("        Enter 0 to exit..Enter any other number to continue...");
                    userEnter = Console.ReadLine();
                }

                if (decision == false)
                {
                    Console.WriteLine("       There is no such player...");
                    Console.ReadKey();
                    userEnter = "0";
                }
            }
        }

        static void checkStats(List<Player> players)
        {
            string userEnter = "1";
            string name, role;
            bool decision;
            while (userEnter != "0")
            {
                Console.Write("       Player's Name: ");
                name = validateString(Console.ReadLine());
                Console.Write("       Player's Role: ");
                role = validateString(Console.ReadLine());
                decision = isValidPlayer(name, role, players);
                if (decision == true)
                {
                    for (int idx = 0; idx < players.Count; idx++)
                    {
                        if ((name == players[idx].name) && (role == players[idx].role))
                        {
                            Console.WriteLine("        Player Name: {0}", name);
                            Console.WriteLine("        Player Role: {0}", role);
                            Console.WriteLine("        Innings: {0}", players[idx].innings);
                            Console.WriteLine("        Runs: {0}", players[idx].runs);
                            Console.WriteLine("        Wickets: {0}", players[idx].wickets);
                            Console.WriteLine("        High Score: {0}", players[idx].highScore);
                            Console.WriteLine("        Average: {0}", players[idx].average);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("       There is no such player...");
                    Console.ReadKey();
                }

                Console.WriteLine("        Do you want to continue?");
                Console.WriteLine("        Enter 0 to exit..Enter any other number to continue...");
                userEnter = Console.ReadLine();
            }
        }

        static void scheduleTraining(List<TrainingSchedule> trainingSchedules)
        {
            string userEnter = "1";
            while (userEnter != "0")
            {
                TrainingSchedule training = new TrainingSchedule();
                Console.WriteLine("       Training no {0}", trainingSchedules.Count);
                Console.Write("       Date: ");
                training.date = validateDate(Console.ReadLine());
                Console.Write("       Time: ");
                training.time = validateTime(Console.ReadLine());
                trainingSchedules.Add(training);
                Console.WriteLine("        Enter 0 to exit.");
                Console.WriteLine("        Enter any other number to continue...");
                userEnter = Console.ReadLine();
            }
        }

        static void checkAchievements(List<string> achievements)
        {
            string userEnter = "1";
            for (int idx = 0; idx < achievements.Count; idx++)
            {
                Console.WriteLine("  " + "{0} " + ". " + achievements[idx], idx + 1);
            }
            Console.WriteLine("       Enter 0 to exit.");
            Console.WriteLine("Enter any other number to continue...");
            userEnter = Console.ReadLine();

        }

        static void checkSchedule(List<MatchSchedule> matchSchedules)
        {
            string userEnter = "";

            Console.WriteLine("   " + "    Opposition        Date        Time        Ground");
            for (int i = 0; i < matchSchedules.Count; i++)
            {
                Console.WriteLine("   " + "{4} " + "{0}        {1}        {2}        {3}", matchSchedules[i].opposition, matchSchedules[i].date, matchSchedules[i].time, matchSchedules[i].ground, i + 1);
            }

            userEnter = Console.ReadLine();
        }

        static void scheduleMatch(List<MatchSchedule> matchSchedules)
        {
            string userEnter = "1";
            while (userEnter != "0")
            {
                MatchSchedule match = new MatchSchedule();
                Console.WriteLine("       Match no {0}", matchSchedules.Count + 1);
                Console.Write("       Opposition: ");
                match.opposition = validateString(Console.ReadLine());
                Console.Write("       Date: ");
                match.date = validateDate(Console.ReadLine());
                Console.Write("       Time: ");
                match.time = validateTime(Console.ReadLine());
                Console.Write("       Ground: ");
                match.ground = validateString(Console.ReadLine());

                matchSchedules.Add(match);
                Console.WriteLine("        Enter 0 to exit.");
                Console.WriteLine("        Enter any other number to continue...");
                userEnter = Console.ReadLine();
            }
        }

        static void setTicketPrices(ref int ticketPrices)
        {
            string userEnter = "1", ticketPrice;
            while (userEnter != "0")
            {
                Console.Write("       Set New Ticket Prices: ");
                ticketPrice = validateInteger(Console.ReadLine());
                Console.WriteLine("Do you want to continue?");
                Console.WriteLine("Enter 0 to exit.Enter any other number to continue...");
                userEnter = Console.ReadLine();
            }
        }

        static void addAchievements(List<string> achievements)
        {
            string userEnter = "1";
            while (userEnter != "0")
            {
                Console.Write("       Enter Achievement: ");
                string achievmnt = Console.ReadLine();
                achievements.Add(achievmnt);
                Console.WriteLine("        Do you want to continue?");
                Console.WriteLine("        Press 0 to exit.Enter any other number to continue...");
                userEnter = Console.ReadLine();
            }
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

        static string coachMenu()
        {
            header();

            Console.WriteLine("        1. Add a player.");
            Console.WriteLine("        2. Remove a player.");
            Console.WriteLine("        3. Search a player.");
            Console.WriteLine("        4. Check Schedule.");
            Console.WriteLine("        5. Check Team.");
            Console.WriteLine("        6. Change playing XI.");
            Console.WriteLine("        7. Check statistics of players.");
            Console.WriteLine("        8. Schedule Training Session.");
            Console.WriteLine("        9. Check Achievements.");
            Console.WriteLine("       10. Add Player Statistics.");
            Console.WriteLine("       11. Exit.");
            Console.Write("Enter an option...");
            string option;
            option = Console.ReadLine();
            return option;
        }

        static Credentials login(Credentials user, List<Credentials> users)
        {
            foreach (Credentials storedUser in users)
            {
                if ((user.username == storedUser.username) && (user.password == storedUser.password))
                {
                    return storedUser;
                }
            }
            return null;
        }

        static string Menu()
        {
            header();

            Console.ForegroundColor = ConsoleColor.Blue;

            string option;
            Console.WriteLine("       1. Sign In");
            Console.WriteLine("       2. Sign Up (Only for Fans)");
            Console.WriteLine("       3. Exit");
            Console.Write("       Enter you option...");
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

        static void loadData(ref int count, List<Credentials> users)
        {
            string line;
            StreamReader file = new StreamReader("C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Data.txt");
            while ((line = file.ReadLine()) != null)
            {
                string username = parseWord(line, 1);
                string password = parseWord(line, 2);
                string role = parseWord(line, 3);
                Credentials info = new Credentials(username, password, role);
                storeDataInList(users, info);
                count++;
            }
            file.Close();
        }

        static void storeDataInList(List<Credentials> users, Credentials info)
        {
            users.Add(info);
        }

        static void LoadCricketersData(List<Player> players, ref int playersCount)
        {
            string line = "";
            string path = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\CricketersData.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    Player player = new Player();
                    player.name = parseWord(line, 1);
                    player.role = parseWord(line, 2);
                    player.battingStyle = parseWord(line, 3);
                    player.bowlingStyle = parseWord(line, 4);
                    player.age = int.Parse(parseWord(line, 5));
                    player.salary = int.Parse(parseWord(line, 6));
                    player.innings = int.Parse(parseWord(line, 7));
                    player.runs = int.Parse(parseWord(line, 8));
                    player.wickets = int.Parse(parseWord(line, 9));
                    player.highScore = int.Parse(parseWord(line, 10));
                    player.average = float.Parse(parseWord(line, 11));
                    players.Add(player);
                    playersCount++;
                }
                file.Close();
            }

            else
            {
                return;
            }
        }

        static void LoadCoachesData(List<Coach> coaches, ref int coachesCount)
        {
            string line = "";
            StreamReader file = new StreamReader("C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\CoachesData.txt");
            while ((line = file.ReadLine()) != null)
            {
                Coach coach = new Coach();
                coach.name = parseWord(line, 1);
                coach.role = parseWord(line, 2);
                coach.age = int.Parse(parseWord(line, 3));
                coach.salary = int.Parse(parseWord(line, 4));
                coaches.Add(coach);
                coachesCount++;
            }
            file.Close();
        }

        static void loadAchievements(List<string> achievements)
        {
            StreamReader file = new StreamReader("C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Achievements.txt");
            string line = "";
            while ((line = file.ReadLine()) != null)
            {
                achievements.Add(line);
            }
            file.Close();
        }

        /*static void addPlayer(ref int playersCount, List<Player> players)
        {
            Console.Clear();
            header();
            string userEnter = "";

            while (userEnter != "0")
            {
                Player player = new Player();
                Console.Write("       Enter Player's Name: ");
                player.name = validateString(Console.ReadLine());
                Console.Write("       Enter Player's Age: ");
                player.age = int.Parse(validateInteger(Console.ReadLine()));
                Console.Write("       Enter Player's Role(Batter / Bowler / WK / AllRounder): ");
                player.role = validatePlayerRole(Console.ReadLine());
                Console.Write("       Enter Player's Batting Style(Left / Right): ");
                player.battingStyle = validateBattingStyleRole(Console.ReadLine());
                Console.Write("       Enter Player's Bowling Style(Left / Right / No): ");
                player.bowlingStyle = validateBowlingStyleRole(Console.ReadLine());
                Console.Write("       Enter Player's Salary: ");
                player.salary = int.Parse(validateInteger(Console.ReadLine()));
                playersCount++;
                players.Add(player);
                Console.Write("       Enter 0 to exit and any other key to continue...");
                userEnter = Console.ReadLine();
            }
        }*/

        static void addCoach(ref int coachesCount, List<Coach> coaches)
        {
            Console.Clear();
            header();
            string userEnter = "";

            while (userEnter != "0")
            {
                Coach coach = new Coach();
                Console.Write("       Enter Player's Name: ");
                coach.name = validateString(Console.ReadLine());
                Console.Write("       Enter Player's Age: ");
                coach.age = int.Parse(validateInteger(Console.ReadLine()));
                Console.Write("       Enter Player's Role(Head/ Batting / Bowling/ Fielding): ");
                coach.role = validateCoachesRole(Console.ReadLine());
                Console.Write("       Enter Player's Salary: ");
                coach.salary = int.Parse(validateInteger(Console.ReadLine()));
                coachesCount++;
                coaches.Add(coach);
                Console.Write("       Enter 0 to exit and any other key to continue...");
                userEnter = Console.ReadLine();
            }
        }

        static Credentials takeInputWithoutRole()
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

        static Credentials takeInputWithRole()
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

        static void removeCoach(ref int currentCoaches, List<Coach> coaches)
        {
            string removingPlayer;
            Console.Write("Enter the name of Player: ");
            removingPlayer = validateString(Console.ReadLine());
            int removingIdx = -1;
            for (int idx = 0; idx < coaches.Count; idx++)
            {
                if (removingPlayer == coaches[idx].name)
                {
                    removingIdx = idx;
                    coaches.Remove(coaches[idx]);
                    currentCoaches--;
                }
            }
            if (removingIdx == -1)
            {
                Console.Write("There is no such Player in the team.Enter anything to Exit...");
                Console.ReadLine();
                return;
            }

            Console.Write("Enter to exit..");
            Console.ReadLine();
        }

        static void removePlayer(List<Player> players)
        {
            string removingPlayer;
            Console.Write("Enter the name of Player: ");
            removingPlayer = validateString(Console.ReadLine());
            int removingIdx = -1;
            for (int idx = 0; idx < players.Count; idx++)
            {
                if (removingPlayer == players[idx].name)
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

            else if(removingIdx != -1)
            {
                players.RemoveAt(removingIdx);
                Console.Write("Enter to exit..");
                Console.ReadLine();
            }

        }

        static void checkTeam(List<Player> players)
        {
            string userEnter = "1";
            Console.WriteLine("      Name            Age            Role            Batting Style            Bowling Style            Salary");
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine("  " + "{6}" + "    {0}            {1}            {2}            {3}            {4}            {5}", players[i].name, players[i].age, players[i].role, players[i].battingStyle, players[i].bowlingStyle, players[i].salary, i + 1);

            }
            Console.WriteLine("Enter any key to exit");
            userEnter = Console.ReadLine();
        }

        static void changePlayingXI(List<Player> players)
        {
            int index, substituteIndex;
            string userEnter = "1";
            while (userEnter != "0")
            {
                Console.Clear();
                header();
                Console.Write("       Enter the index of player in Playing XI: ");
                index = int.Parse(validateInteger(Console.ReadLine()));
                index--;
                Console.Write("       Enter the index of substitution player in Playing XI: ");
                substituteIndex = int.Parse(validateInteger(Console.ReadLine()));
                substituteIndex--;
                Player tempPlayer = new Player();
                tempPlayer = players[index];
                players[index] = players[substituteIndex];
                players[substituteIndex] = tempPlayer;
                Console.WriteLine("       Do you want to continue?");
                Console.WriteLine("       Enter 0 to exit.Enter any other number to continue...");
                userEnter = Console.ReadLine();
            }
        }

        static void checkMgmtStaff(List<Coach> coaches)
        {
            string userEnter = "1";
            Console.WriteLine("      Name            Age            Role            Salary");
            for (int i = 0; i < coaches.Count; i++)
            {
                Console.WriteLine("  " + "{4} " + "    {0}            {1}            {2}            {3}", coaches[i].name, coaches[i].age, coaches[i].role, coaches[i].salary, i + 1);

            }
            Console.WriteLine("       Enter any key to exit");
            userEnter = Console.ReadLine();
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

        static string validateCoachesRole(string line)
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

        static void checkFinances(List<Player> players, List<Coach> coaches)
        {
            int sumPlayer = 0;
            int sumCoach = 0;
            string userEnter = "1";
            while (userEnter != "0")
            {
                for (int idx = 0; idx < players.Count; idx++)
                {
                    sumPlayer += players[idx].salary;
                }
                for (int idx = 0; idx < coaches.Count; idx++)
                {
                    sumCoach += coaches[idx].salary;
                }
                Console.WriteLine("       1. Player's Salary: {0}", sumPlayer);
                Console.WriteLine("       2. Coach's Salary: {0}", sumCoach);

                Console.WriteLine("       Enter 0 to exit.");
                Console.WriteLine("       Enter any other thing to continue...");
                userEnter = Console.ReadLine();
            }
        }

        static bool isDateValid(string line)
        {
            string date = "", month = "", year = "";
            if (line.Length != 10)
            {
                return false;
            }

            if ((line[2] != '-') || (line[5] != '-'))
            {
                return false;
            }

            for (int idx = 0; idx < 2; idx++)
            {
                date = date + line[idx];
            }

            for (int idx = 3; idx < 5; idx++)
            {
                month = month + line[idx];
            }

            for (int idx = 6; idx < 10; idx++)
            {
                year = year + line[idx];
            }

            if (((int.Parse(date) > 31) || (int.Parse(date) < 0)) || ((int.Parse(month) > 12) || (int.Parse(month) < 0)) || ((int.Parse(year) > 2030) || (int.Parse(year) < 0)))
            {
                return false;
            }
            return true;
        }

        static string validateDate(string line)
        {
            bool flag = false;
            while (flag == false)
            {
                flag = isDateValid(line);
                if (flag == false)
                {
                    Console.WriteLine("       Invalid Input. Enter Date in (dd-mm-yyyy) format.Try Again...");
                    Console.WriteLine("       Note: Date(0---31) and Month(0---12) and Year(0000---2030)");
                    Console.WriteLine("       ");
                    line = Console.ReadLine();
                }
                if (flag == true)
                {
                    return line;
                }
            }
            return "invalid";
        }

        static string validateTime(string line)
        {
            bool flag = false;
            while (flag == false)
            {
                flag = isTimeValid(line);

                if (flag == false)
                {
                    Console.WriteLine("       Invalid Input. Enter Time in (hh:mm) format.Try Again...");
                    Console.WriteLine("       Note: Hours(0---23) and Minutes(0---59)");
                    Console.WriteLine("       ");
                    line = Console.ReadLine();
                }

                if (flag == true)
                {
                    return line;
                }
            }
            return "invalid";
        }

        static bool isTimeValid(string time)
        {
            if (time.Length != 5)
            {
                return false;
            }

            if (time[2] != ':')
            {
                return false;
            }

            string hours = "", minutes = "";
            for (int idx = 0; idx < 2; idx++)
            {
                hours = hours + time[idx];
            }
            for (int idx = 3; idx < 5; idx++)
            {
                minutes = minutes + time[idx];
            }

            if (((int.Parse(hours) >= 24) || (int.Parse(hours) < 0)) || ((int.Parse(minutes) >= 60) || (int.Parse(minutes) < 0)))
            {
                return false;
            }

            return true;
        }

        static Player searchPlayer(List<Player> players)
        {
            string search;
            Console.Write("       Enter the player's name: ");
            search = Console.ReadLine();

            for (int idx = 0; idx < players.Count; idx++)
            {
                if (search == players[idx].name)
                {
                    return players[idx];
                }
            }
            return null;

        }

        static void changePlayerName(List<Player> players, int currentPlayers)
        {
            string userEnter = "1";
            string name, role;
            bool decision;
            while (userEnter != "0")
            {
                Console.Write("       Name of player which was recorded previously: ");
                name = validateString(Console.ReadLine());

                Console.Write("       His Role: ");
                role = validateString(Console.ReadLine());

                decision = isValidPlayer(name, role, players);
                if (decision == true)
                {
                    for (int idx = 0; idx < players.Count; idx++)
                    {
                        if ((name == players[idx].name) && (role == players[idx].role))
                        {
                            players[idx].name = players[idx].changeName();
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

        static bool isValidPlayer(string name, string role, List<Player> players)
        {
            for (int idx = 0; idx < players.Count; idx++)
            {
                if ((name == players[idx].name) && (role == players[idx].role))
                {
                    return true;
                }
            }
            return false;
        }

        static void addUser(ref int usersCount, List<Credentials> users)
        {
            Console.Write("       Enter Name: ");
            string newUser = Console.ReadLine();
            Console.Write("       Enter Password: ");
            string newPass = Console.ReadLine();
            Console.Write("       Enter Role: ");
            string newRole = Console.ReadLine();
            Credentials user = new Credentials(newUser, newPass, newRole);

            if (newRole == "Coach" || newRole == "Player" || newRole == "Fans")
            {
                if (usersCount <= 99)
                {
                    user.username = newUser;
                    user.password = newPass;
                    user.role = newRole;
                    users.Add(user);
                    usersCount++;
                }
                else
                {
                    Console.WriteLine("       User Limit Exceeded.");
                }
            }
            else
            {
                Console.WriteLine("       Invalid User type");
            }

        }

        static void storeUsersData(List<Credentials> users)
        {
            string usersPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Data.txt";
            StreamWriter file = new StreamWriter(usersPath, false);
            for (int x = 0; x < users.Count; x++)
            {
                file.WriteLine(users[x].username + "," + users[x].password + "," + users[x].role);
            }
            file.Flush();
            file.Close();
        }

        static void storeCricketersData(List<Player> players)
        {
            string usersPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\CricketersData.txt";
            StreamWriter file = new StreamWriter(usersPath, false);
            for (int idx = 0; idx < players.Count; idx++)
            {

                file.WriteLine(players[idx].name + "," + players[idx].role + "," + players[idx].battingStyle + "," + players[idx].bowlingStyle + "," + players[idx].age + "," + players[idx].salary + "," + players[idx].innings + "," + players[idx].runs + "," + players[idx].wickets + "," + players[idx].highScore + "," + players[idx].average);
            }

            file.Flush();
            file.Close();
        }

        static void storeCoachesData(List<Coach> coaches)
        {
            string usersPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\CoachesData.txt";
            StreamWriter file = new StreamWriter(usersPath, false);
            for (int idx = 0; idx < coaches.Count; idx++)
            {
                if ((idx == (coaches.Count - 1)) && (idx != 0))
                {
                    file.WriteLine(coaches[idx].name + "," + coaches[idx].role + "," + coaches[idx].age + "," + coaches[idx].salary);
                }
                else
                {
                    file.Write(coaches[idx].name + "," + coaches[idx].role + "," + coaches[idx].age + "," + coaches[idx].salary);
                }
            }

            file.Flush();
            file.Close();
        }

        static void storeAchievements(List<string> achievements)
        {
            string usersPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Achievements.txt";
            StreamWriter file = new StreamWriter(usersPath, false);
            for (int idx = 0; idx < achievements.Count; idx++)
            {
                Console.WriteLine(achievements[idx]);
            }

            file.Flush();
            file.Close();
        }

        static void storeSchedule(List<MatchSchedule> matchSchedules)
        {
            string usersPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Schedule.txt";
            StreamWriter file = new StreamWriter(usersPath, false);
            for (int idx = 0; idx < matchSchedules.Count; idx++)
            {
                if (idx == (matchSchedules.Count - 1) && idx != 0)
                {
                    file.WriteLine(matchSchedules[idx].opposition + "," + matchSchedules[idx].date + "," + matchSchedules[idx].time + "," + matchSchedules[idx].ground);
                }
                else
                {
                    file.WriteLine(matchSchedules[idx].opposition + "," + matchSchedules[idx].date + "," + matchSchedules[idx].time + "," + matchSchedules[idx].ground);
                }
            }
            file.Flush();
            file.Close();
        }

        static void storeTraining(List<TrainingSchedule> trainingSchedules)
        {
            string usersPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Training.txt";
            StreamWriter file = new StreamWriter(usersPath, false);
            for (int idx = 0; idx < trainingSchedules.Count; idx++)
            {
                if (idx == (trainingSchedules.Count - 1) && idx != 0)
                {
                    file.WriteLine(trainingSchedules[idx].date + "," + trainingSchedules[idx].time);
                }
                else
                {
                    file.WriteLine(trainingSchedules[idx].date + "," + trainingSchedules[idx].time);
                }
            }
            file.Flush();
            file.Close();
        }

        static void loadSchedule(List<MatchSchedule> matchSchedules)
        {
            string line = "";
            StreamReader file = new StreamReader("C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Schedule.txt");
            while ((line = file.ReadLine()) != null)
            {
                MatchSchedule matchSchedule = new MatchSchedule();
                matchSchedule.opposition = parseWord(line, 1);
                matchSchedule.date = parseWord(line, 2);
                matchSchedule.time = parseWord(line, 3);
                matchSchedule.ground = parseWord(line, 4);
                matchSchedules.Add(matchSchedule);
            }
            file.Close();
        }

        static void loadTraining(List<TrainingSchedule> trainingSchedules)
        {
            string line = "";
            StreamReader file = new StreamReader("C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Training.txt");
            while ((line = file.ReadLine()) != null)
            {
                TrainingSchedule matchSchedule = new TrainingSchedule();
                matchSchedule.date = parseWord(line, 1);
                matchSchedule.time = parseWord(line, 2);
                trainingSchedules.Add(matchSchedule);
            }
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


