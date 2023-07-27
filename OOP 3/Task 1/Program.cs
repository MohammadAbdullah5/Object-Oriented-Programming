using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeClockType nullTime = new TimeClockType();
            Console.Write("Empty Time: ");
            nullTime.printTime();

            TimeClockType hourTime = new TimeClockType(8);
            Console.Write("Hour Time: ");
            hourTime.printTime();

            TimeClockType minuteTime = new TimeClockType(8, 10);
            Console.Write("Minute Time: ");
            minuteTime.printTime();

            TimeClockType fullTime = new TimeClockType(8, 10, 40);
            Console.Write("Second Time: ");
            fullTime.printTime();

            Console.Write("Full Time(Increment Seconds): ");
            fullTime.incrementSeconds();
            fullTime.printTime();

            Console.Write("Full Time(Increment Minutes): ");
            fullTime.incrementMinutes();
            fullTime.printTime();

            Console.Write("Full Time(Increment Hours): ");
            fullTime.incrementHours();
            fullTime.printTime();

            bool flag = fullTime.isEqual(9, 11, 41);
            Console.WriteLine("Flag: " + flag);

            TimeClockType cmp = new TimeClockType(10, 12, 1);
            flag = fullTime.isEqual(cmp);
            Console.WriteLine("Object Flag: " + flag);

            Console.ReadKey();
        }
    }
}
