using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisness_Application.UI;
using Buisness_Application.BL;
using Buisness_Application.DL;

namespace Buisness_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string achievementsPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Achievements.txt";
            string cricketersPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\CricketersData.txt";
            string coachesPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\CoachesData.txt";
            string trainingPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Training.txt";
            string matchPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Schedule.txt";
            string adminAndFanPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Data.txt";

            PersonDL.loadPeoplesData(adminAndFanPath);
            PersonDL.LoadCoachesData(coachesPath);
            PersonDL.LoadCricketersData(cricketersPath);
            ScheduleDL.loadSchedule(matchPath);
            ScheduleDL.loadTraining(trainingPath);
            AchievementsDL.loadAchievements(achievementsPath);

            string option;
            MainUI.welcome();
            do
            {
                option = MenusUI.Menu();

                if (option == "1")
                {
                    Credentials user1 = PersonUI.takeInputWithoutRole();
                    Person user = PersonDL.login(user1);
                    if (user != null)
                    {
                        user.startInterface();
                    }

                    if(user == null)
                    {
                        Console.Write("Wrong Credentials.Try Again!!!");
                        Console.ReadKey();
                    }
                }

                else if(option == "2")
                {
                    PersonUI.addFan();
                }
            }
            while (option != "3");

            PersonDL.storePeoplesData(adminAndFanPath);
            PersonDL.storeCoachesData(coachesPath);
            PersonDL.storeCricketersData(cricketersPath);
            ScheduleDL.storeMatchSchedule(matchPath);
            ScheduleDL.storeTraining(trainingPath);
            AchievementsDL.storeAchievements(achievementsPath);
        }
    }
}
