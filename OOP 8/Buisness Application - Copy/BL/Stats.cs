using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Stats
    {
        private int innings;
        private int runs;
        private int wickets;
        private int highScore;
        private float average;

        public Stats(int innings, int runs, int wickets, int highScore, float average)
        {
            this.innings = innings;
            this.runs = runs;
            this.wickets = wickets;
            this.highScore = highScore;
            this.average = average;
        }

        public int getInnings()
        {
            return innings;
        }

        public int getRuns()
        {
            return runs;
        }

        public int getWickets()
        {
            return wickets;
        }

        public int getHighScore()
        {
            return highScore;
        }

        public float getAverage()
        {
            return average;
        }

        public void setInnings(int innings)
        {
            this.innings = innings;
        }

        public void setRuns(int runs)
        {
            this.runs = runs;
        }

        public void setWickets(int wickets)
        {
            this.wickets = wickets;
        }

        public void setHighScore(int highScore)
        {
            this.highScore = highScore;
        }

        public void setAverage(float average)
        {
            this.average = average;
        }
    }
}
