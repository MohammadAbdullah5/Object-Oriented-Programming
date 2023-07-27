using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisness_Application.BL;

namespace Buisness_Application.UI
{
    class ScheduleUI
    {
        public static void checkTrainingSchedule(List<TrainingSchedule> trainingSchedules)
        {
            string userEnter = "1";
            Console.WriteLine("\t                       Date        Time        End Time        Description");
            for (int idx = 0; idx < trainingSchedules.Count; idx++)
            {
                Console.WriteLine("\t                       " + trainingSchedules[idx].getDate() + "    " + trainingSchedules[idx].getTime() + "    " + trainingSchedules[idx].getEndTime() + "    " + trainingSchedules[idx].getDescription());
            } 
            Console.Write("\tEnter any key to exit.");
            userEnter = Console.ReadLine();
        }

        public static TrainingSchedule takeInputforTrainingSchedule()
        {
            Console.Write("       Date: ");
            string date = Console.ReadLine();
            Console.Write("       Time: ");
            string time = validateTime(Console.ReadLine());
            Console.Write("       End Time: ");
            string endtime = validateTime(Console.ReadLine());
            Console.Write("       Description: ");
            string description = Console.ReadLine();

            TrainingSchedule training = new TrainingSchedule(time, date, endtime, description);
            return training;
        }

        public static MatchSchedule TakeScheduleInput()
        {
            Console.Write("       Opposition: ");
            string opposition = validateString(Console.ReadLine());
            Console.Write("       Date: ");
            string date = validateDate(Console.ReadLine());
            Console.Write("       Time: ");
            string time = validateTime(Console.ReadLine());
            Console.Write("       Ground: ");
            string ground = validateString(Console.ReadLine());
            Console.Write("       Ticket Price: ");
            int price = int.Parse(PersonUI.validateInteger(Console.ReadLine()));

            MatchSchedule matchSchedule = new MatchSchedule(opposition, date, time, ground, price);
            return matchSchedule;
        }

        public static void checkSchedule(List<MatchSchedule> matchSchedules)
        {
            string userEnter = "";

            Console.WriteLine("   " + "    Opposition        Date        Time        Ground        Ticket Price");
            for (int i = 0; i < matchSchedules.Count; i++)
            {
                Console.WriteLine("   " + "{4} " + "{0}        {1}        {2}        {3}        {4}", matchSchedules[i].getOpposition(), matchSchedules[i].getDate(), matchSchedules[i].getTime(), matchSchedules[i].getGround(), i + 1, matchSchedules[i].getTicketPrice());
            }

            userEnter = Console.ReadLine();
        }

        public static bool isDateValid(string line)
        {
            string date = "", month = "", year = "";
            if (line.Length != 10)
            {
                return false;
            }

            if ((line[2] != '-') || (line[5] != '-'))
            {
                return false;
            }

            for (int idx = 0; idx < 2; idx++)
            {
                date = date + line[idx];
            }

            for (int idx = 3; idx < 5; idx++)
            {
                month = month + line[idx];
            }

            for (int idx = 6; idx < 10; idx++)
            {
                year = year + line[idx];
            }

            if (((int.Parse(date) > 31) || (int.Parse(date) < 0)) || ((int.Parse(month) > 12) || (int.Parse(month) < 0)) || ((int.Parse(year) > 2030) || (int.Parse(year) < 0)))
            {
                return false;
            }
            return true;
        }

        public static string validateDate(string line)
        {
            bool flag = false;
            while (flag == false)
            {
                flag = isDateValid(line);
                if (flag == false)
                {
                    Console.WriteLine("       Invalid Input. Enter Date in (dd-mm-yyyy) format.Try Again...");
                    Console.WriteLine("       Note: Date(0---31) and Month(0---12) and Year(0000---2030)");
                    Console.WriteLine("       ");
                    line = Console.ReadLine();
                }
                if (flag == true)
                {
                    return line;
                }
            }
            return "invalid";
        }

        public static string validateTime(string line)
        {
            bool flag = false;
            while (flag == false)
            {
                flag = isTimeValid(line);

                if (flag == false)
                {
                    Console.WriteLine("       Invalid Input. Enter Time in (hh:mm) format.Try Again...");
                    Console.WriteLine("       Note: Hours(0---23) and Minutes(0---59)");
                    Console.WriteLine("       ");
                    line = Console.ReadLine();
                }

                if (flag == true)
                {
                    return line;
                }
            }
            return "invalid";
        }

        public static bool isTimeValid(string time)
        {
            if (time.Length != 5)
            {
                return false;
            }

            if (time[2] != ':')
            {
                return false;
            }

            string hours = "", minutes = "";
            for (int idx = 0; idx < 2; idx++)
            {
                hours = hours + time[idx];
            }
            for (int idx = 3; idx < 5; idx++)
            {
                minutes = minutes + time[idx];
            }

            if (((int.Parse(hours) >= 24) || (int.Parse(hours) < 0)) || ((int.Parse(minutes) >= 60) || (int.Parse(minutes) < 0)))
            {
                return false;
            }

            return true;
        }

        public static string validateString(string line)
        {
            char ch;
            int ascii;
            int idx = 0;
            string words = "";
            bool flag = true;
            bool outerLoop = true;
            while (outerLoop == true)
            {
                int num = line.Length;
                while (idx < num)
                {
                    flag = true;
                    ch = line[idx];
                    ascii = (int)ch;
                    if (((ascii > 64) && (ascii <= 91)) || ((ascii > 96) && (ascii <= 122)) || (ascii == 32))
                    {
                        words = words + line[idx];
                    }
                    else if (((ascii < 64) || (ascii > 92)) && ((ascii < 96) || (ascii > 122)))
                    {
                        flag = false;
                    }
                    idx++;
                }
                if (flag == false)
                {
                    Console.Write("       Invalid Input.Enter only Alphabets or Space.Try Again.....");
                    words = "";
                    line = Console.ReadLine();
                    idx = 0;
                }
                if (flag == true)
                {
                    return words;
                }
            }
            return "invalid";
        }

    }
}
