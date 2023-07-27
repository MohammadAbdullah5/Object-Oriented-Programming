using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Program
    {
        class Time
        {
            public int s;
            public int m;
            public int h;

            public void PrintTime()
            {
                Console.WriteLine(h + ":" + m + ":" + s);
            }

            public void IsEqualTime(Time time)
            {
                if ((h == time.h) && (m == time.m) && (s == time.s))
                {
                    Console.WriteLine("Equal");
                }

                else
                {
                    int Difference;
                    int Object = (time.h * 3600) + (time.m * 60) + time.s;
                    int Newtime = (h * 3600) + (m * 60) + s;

                    Difference = Object - Newtime;

                    if (Difference < 0)
                    {
                        Difference = -Difference;
                    }

                    Console.WriteLine("Not Equal");
                    Console.WriteLine("Difference: " + Difference);
                }
            }

            public int Elapse()
            {
                int timeInSeconds = (h * 3600) + (m * 60) + s;
                return timeInSeconds;
            }

            public int Difference()
            {
                int secondsOfDay = 24 * 3600;
                int secondsTime = ((h * 3600) + (m * 60) + s);
                return secondsOfDay - secondsTime;
            }

        }

        static void Main(string[] args)
        {
            Time timing = new Time();
            timing.h = 10;
            timing.m = 40;
            timing.s = 56;

            int elapseTime = timing.Elapse();
            int remainingTime = timing.Difference();

            Console.Write("Time: ");
            timing.PrintTime();
            Console.WriteLine("Elapse: " + elapseTime);
            Console.WriteLine("Remaining: " + remainingTime);

            Time check = new Time();
            check.h = 12;
            check.m = 12;
            check.s = 32;

            Console.Write("Equal? : ");
            timing.IsEqualTime(check);

            Console.ReadKey();
        }
    }
}
