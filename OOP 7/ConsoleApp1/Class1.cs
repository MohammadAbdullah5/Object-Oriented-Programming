using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bicycle
    {
        protected int cardence;
        protected int gear;
        protected int speed;

        public Bicycle(int cardence, int gear, int speed)
        {
            this.cardence = cardence;
            this.gear = gear;
            this.speed = speed;
        }

        public void setCardence(int cardence)
        {
            this.cardence = cardence;
        }

        public void setGear(int gear)
        {
            this.gear = gear;
        }

        public void setSpeed(int speed)
        {
            this.speed = speed;
        }

        public void applyBrake(int decrement)
        {
            speed -= decrement;
        }

        public void speedUp(int increment)
        {
            speed += increment;
        }
    }
}
