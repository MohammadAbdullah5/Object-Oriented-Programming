using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Angle
    {
        public int degrees;
        public float minutes;
        public char direction;

        public Angle(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }

        public void changeAngle(int degree, float minutes, char direction)
        {
            this.degrees = degree;
            this.minutes = minutes;
            this.direction = direction;
        }
    }
}