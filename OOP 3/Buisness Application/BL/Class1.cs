using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.BL
{
    class Player
    {
        public string name;
        public int age;
        public string role;
        public string battingStyle;
        public string bowlingStyle;
        public int salary;
        public int innings;
        public int runs;
        public int wickets;
        public int highScore;
        public float average;

        public Player()
        {
            this.name = "Don't Know";
            this.age = 00;
            this.role = "Don't Know";
            this.battingStyle = "Don't Know";
            this.bowlingStyle = "Don't Know";
            this.salary = 01;
            this.innings = 2;
            this.runs = 3;
            this.wickets = 4;
            this.highScore = 5;
            this.average = 6;
        }

        public Player addPlayer()
        {
            string userEnter = "";

            Player player = new Player();
            while (userEnter != "0")
            {
                Console.Write("       Enter Player's Name: ");
                player.name = Console.ReadLine();
                Console.Write("       Enter Player's Age: ");
                player.age = int.Parse(Console.ReadLine());
                Console.Write("       Enter Player's Role(Batter / Bowler / WK / AllRounder): ");
                player.role = Console.ReadLine();
                Console.Write("       Enter Player's Batting Style(Left / Right): ");
                player.battingStyle = Console.ReadLine();
                Console.Write("       Enter Player's Bowling Style(Left / Right / No): ");
                player.bowlingStyle = Console.ReadLine();
                Console.Write("       Enter Player's Salary: ");
                player.salary = int.Parse(Console.ReadLine());
                Console.Write("       Enter 0 to exit and any other key to continue...");
                userEnter = Console.ReadLine();
            }
            return player;
        }

        public Player addStats(Player player)
        {
            Console.Write("       Runs: ");
            player.runs = int.Parse(Console.ReadLine());
            Console.Write("       Innings: ");
            player.innings = int.Parse(Console.ReadLine());
            Console.Write("       Wickets: ");
            player.wickets = int.Parse(Console.ReadLine());
            Console.Write("       High Score: ");
            player.highScore = int.Parse(Console.ReadLine());
            player.average = (float)player.runs / (float)player.innings;
            return player;
        }

        public Player changeName(Player player)
        {
            Console.Write("       Write the corrected name: ");
            player.name = Console.ReadLine();
            return player;
        }
    }

}

