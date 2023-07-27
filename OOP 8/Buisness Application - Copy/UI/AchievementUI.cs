using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class AchievementUI
    {
        public static string inputAchievement()
        {
            Console.Write("       Enter Achievement: ");
            string achievement = Console.ReadLine();
            return achievement;
        }

        public static int deleteAchievement()
        {
            Console.Write("       Enter the index of Achievement you want to delete: ");
            int index = int.Parse(PersonUI.validateInteger(Console.ReadLine()));
            return index - 1;
        }

        public static void checkAchievement(List<string> achievements)
        {
            int index = 1;
            foreach (var achievement in achievements)
            {
                Console.WriteLine(index + ". " + achievement);
                index++;
            }
            Console.ReadLine();
        }
    }
}
