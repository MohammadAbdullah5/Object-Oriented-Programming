using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class MatchSchedule : Schedule
    {
        private string opposition;
        private string ground;
        private int ticketPrice;

        public MatchSchedule(string date, string time, string opposition, string ground, int ticketPrice) : base(date, time)
        {
            this.opposition = opposition;
            this.ground = ground;
            this.ticketPrice = ticketPrice;
        }

        public void setTicketPrice(int price)
        {
            this.ticketPrice = price;
        }

        public int getTicketPrice()
        {
            return ticketPrice;
        }

        public void setOpposition(string opposition)
        {
            this.opposition = opposition;
        }

        public void setGround(string ground)
        {
            this.ground = ground;
        }

        public string getOpposition()
        {
            return opposition;
        }

        public string getGround()
        {
            return ground;
        }

        public override string toString()
        {
            return "Match " + base.toString();
        }
    }
}
