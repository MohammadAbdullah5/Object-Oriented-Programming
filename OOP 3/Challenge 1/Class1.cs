using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Time
    {
        public int seconds;
        public int minutes;
        public int hours;

        public void PrintTime()
        {
            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
        }

        public void IsEqualTime(Time time)
        {
            if((hours == time.hours) && (minutes == time.minutes) && (seconds == time.seconds))
            {
                Console.WriteLine("Equal");
            }

            else
            {
                int Difference;
                int Object = (time.hours * 3600) + (time.minutes * 60) + time.seconds;
                int Newtime = (hours * 3600) + (minutes * 60) + seconds;

                Difference = Object - Newtime;

                if(Difference < 0)
                {
                    Difference = -Difference;
                }

                Console.WriteLine("Not Equal");
                Console.WriteLine("Difference: " + Difference);
            }
        }

        public int Elapse()
        {
            int time = ((hours * 3600) + (minutes * 60) + seconds);
            return time;
        }

        public int Difference()
        {
            int day = 24 * 3600;
            int time = ((hours * 3600) + (minutes * 60) + seconds);
            return day - time;
        }

    }
}
