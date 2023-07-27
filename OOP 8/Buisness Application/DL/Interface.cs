using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisness_Application.BL;
using Buisness_Application.UI;

namespace Buisness_Application.DL
{
    class Interface
    {
        public static void fansInterface()
        {
            string fanOption = "0";
            do
            {
                Console.Clear();
                MainUI.header();
                fanOption = MenusUI.fanMenu();
                Console.Clear();

                if (fanOption == "1")
                {
                    MainUI.header();
                    ScheduleUI.checkSchedule(ScheduleDL.returnMatchSchedules());
                }

                else if (fanOption == "2")
                {
                    MainUI.header();
                    PersonUI.checkStats(PersonDL.returnPlayersList());
                }

                else if (fanOption == "3")
                {
                    MainUI.header();
                    AchievementUI.checkAchievement(AchievementsDL.achievements);
                }

                else if (fanOption == "4")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("\tInvalid Input.Try Again.");
                    Console.ReadKey();
                }
            }
            while (fanOption != "4");
        }

        public static void PlayersInterface()
        {
            string playerOption;
            do
            {
                Console.Clear();
                MainUI.header();
                playerOption = MenusUI.playerMenu();
                Console.Clear();

                if (playerOption == "1")
                {
                    MainUI.header();
                    ScheduleUI.checkSchedule(ScheduleDL.returnMatchSchedules());
                }

                else if (playerOption == "2")
                {
                    MainUI.header();
                    PersonUI.checkPlayingXI(PersonDL.returnPlayersList());
                }

                else if (playerOption == "3")
                {
                    MainUI.header();
                    PersonUI.checkStats(PersonDL.returnPlayersList());
                }

                else if (playerOption == "4")
                {
                    MainUI.header();
                    AchievementUI.checkAchievement(AchievementsDL.achievements);
                }

                else if (playerOption == "5")
                {
                    MainUI.header();
                    ScheduleUI.checkTrainingSchedule(ScheduleDL.returnTrainingSchedules());
                }

                else if (playerOption == "6")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid Input.Try Again.");
                    Console.ReadKey();
                }
            }
            while (playerOption != "6");
        }


        public static void adminInterface()
        {
            string adminOption;
            do
            {
                adminOption = MenusUI.adminMenu();

                if (adminOption == "1")
                {
                    MainUI.header();
                    Player player = PersonUI.takePlayerInput();
                    PersonDL.addPlayerToList(player);
                }

                else if (adminOption == "2")
                {
                    MainUI.header();
                    PersonUI.removePlayer();
                }

                else if (adminOption == "3")
                {
                    MainUI.header();
                    PersonUI.checkFinances();
                }

                else if (adminOption == "4")
                {
                    MainUI.header();
                    PersonUI.searchPlayer();
                }

                else if (adminOption == "5")
                {
                    MainUI.header();

                    Coach coach = PersonUI.addCoach();
                    PersonDL.people.Add(coach);
                }

                else if (adminOption == "6")
                {
                    MainUI.header();
                    PersonUI.removeCoach();
                }

                else if (adminOption == "7")
                {
                    MainUI.header();
                    AchievementsDL.addAchievements(AchievementUI.inputAchievement());
                }

                else if (adminOption == "8")
                {
                    MainUI.header();
                    PersonUI.checkTeam(PersonDL.returnPlayersList());
                }

                else if (adminOption == "9")
                {
                    MainUI.header();
                    PersonUI.checkMgmtStaff(PersonDL.returnCoachList());
                }

                else if (adminOption == "10")
                {
                    MainUI.header();
                    PersonUI.changeNameOfPlayer();
                }

                else if (adminOption == "11")
                {
                    MainUI.header();
                    MatchSchedule schedule = ScheduleUI.TakeScheduleInput();
                    ScheduleDL.addMatchSchedule(schedule);
                }
            }
            while (adminOption != "12");
        }

        public static void coachInterface()
        {
            string coachOption = "";
            do
            {
                coachOption = MenusUI.coachMenu();

                if (coachOption == "1")
                {
                    MainUI.header();
                    PersonUI.searchPlayer();
                }

                else if (coachOption == "2")
                {
                    MainUI.header();
                    ScheduleUI.checkSchedule(ScheduleDL.returnMatchSchedules());
                }

                else if (coachOption == "3")
                {
                    MainUI.header();
                    PersonUI.checkTeam(PersonDL.returnPlayersList());
                }

                else if (coachOption == "4")
                {
                    MainUI.header();
                    PersonUI.changePlayingXI();
                }

                else if (coachOption == "5")
                {
                    MainUI.header();
                    PersonUI.checkStats(PersonDL.returnPlayersList());
                }

                else if (coachOption == "6")
                {
                    MainUI.header();
                    ScheduleDL.addTrainingSchedule(ScheduleUI.takeInputforTrainingSchedule());
                }

                else if (coachOption == "7")
                {
                    MainUI.header();
                    AchievementUI.checkAchievement(AchievementsDL.achievements);
                }

                else if (coachOption == "8")
                {
                    MainUI.header();
                    PersonUI.addStats();
                }

                else if (coachOption == "9")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("       Invalid Input.Try Again.");
                    Console.ReadKey();
                }
            }
            while (coachOption != "9");
        }
    }
}
