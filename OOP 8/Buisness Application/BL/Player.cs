using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisness_Application.DL;

namespace Buisness_Application.BL
{
    class Player : Person
    { 
        private string battingStyle;
        private string bowlingStyle;
        private string playerRole;
        private Stats stats;

        public Player(string name, int age, string playerRole, string battingStyle, string bowlingStyle, int salary, Credentials credentials) : base(name, credentials.getRole(), age, salary, credentials)
        {
            this.battingStyle = battingStyle;
            this.bowlingStyle = bowlingStyle;
            this.playerRole = playerRole;
        }

        public Player(string name, int age, string playerRole, string battingStyle, string bowlingStyle, int salary, Stats stats, Credentials credentials) : base(name, "Player", age, salary, credentials)
        {
            this.battingStyle = battingStyle;
            this.bowlingStyle = bowlingStyle;
            this.stats = stats;
            this.playerRole = playerRole;
            
        }

        public void addStats(Stats stats)
        {
            this.stats = stats;
        }

        public string getBattingStyle()
        {
            return battingStyle;
        }

        public string getBowlingStyle()
        {
            return bowlingStyle;
        }

        public string getPlayerRole()
        {
            return playerRole;
        }

        public void setBattingStyle(string battingStyle)
        {
            this.battingStyle = battingStyle;
        }

        public void setPlayerRole(string playerRole)
        {
            this.playerRole = playerRole;
        }

        public void setBowlingStyle(string bowlingStyle)
        {
            this.bowlingStyle = bowlingStyle;
        }

        public Stats getStats()
        {
            return stats;
        }

        public override string toString()
        {
            return "Player";
        }

        public override void startInterface()
        {
            Interface.PlayersInterface();
        }
    }

}

