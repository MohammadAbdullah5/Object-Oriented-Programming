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

        public Player(string name, int age, string role, string battingStyle, string bowlingStyle, int salary)
        {
            this.name = name;
            this.age = age;
            this.role = role;
            this.battingStyle = battingStyle;
            this.bowlingStyle = bowlingStyle;
            this.salary = salary;
            this.innings = 2;
            this.runs = 3;
            this.wickets = 4;
            this.highScore = 5;
            this.average = 6;
        }

        public void addStats(int runs, int innings, int wickets, int highscore)
        {
            this.runs = runs;
            this.innings = innings;
            this.wickets = wickets;
            this.highScore = highscore;
            this.average = (float)runs / (float)innings;
        }

        public void changeName(string name)
        {
            this.name = name;
        }
    }

}

