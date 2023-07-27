using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MountainBike : Bicycle
    {
        private int seatHeight;
        
        public MountainBike(int cardence, int gear, int speed, int seatHeight) : base(cardence, gear, speed)
        {
            this.seatHeight = seatHeight;
        }

        public void setSeatHeight(int seatHeight)
        {
            this.seatHeight = seatHeight;
        }
    }
}
