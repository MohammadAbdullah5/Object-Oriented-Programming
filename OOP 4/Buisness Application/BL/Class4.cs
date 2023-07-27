using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.BL
{
    class MatchSchedule
    {
        public string opposition;
        public string date;
        public string time;
        public string ground;

        public MatchSchedule(string opposition, string date, string time, string ground)
        {
            this.date = date;
            this.time = time;
            this.opposition = opposition;
            this.ground = ground;
        }


    }
}
