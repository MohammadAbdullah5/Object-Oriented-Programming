using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class TimeClockType
    {
        public TimeClockType()
        {
            seconds = 0;
            minutes = 0;
            hours = 0;
        }

        public TimeClockType(int h)
        {
            hours = h;
        }

        public TimeClockType(int h, int m)
        {
            hours = h;
            minutes = m;
        }

        public TimeClockType(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }

        public void incrementSeconds()
        {
            seconds++;
        }

        public void incrementMinutes()
        {
            minutes++;
        }

        public void incrementHours()
        {
            hours++;
        }

        public void printTime()
        {
            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
        }

        public bool isEqual(int h, int m, int s)
        {
            if((hours == h) && (minutes == m) && (seconds == s))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool isEqual(TimeClockType time)
        {
            if ((hours == time.hours) && (minutes == time.minutes) && (seconds == time.seconds))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public int seconds;
        public int minutes;
        public int hours;
    }
}
