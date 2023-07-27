using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class MenusUI
    {
        public static string playerMenu()
        {
            Console.WriteLine("       1. Check Schedule.");
            Console.WriteLine("       2. Check Playing XI.");
            Console.WriteLine("       3. Check Statistics.");
            Console.WriteLine("       4. Check Achievements.");
            Console.WriteLine("       5. Check Training Schedule.");
            Console.WriteLine("       6. Exit.");
            string option;
            Console.Write("       Enter an option...");
            option = Console.ReadLine();
            return option;
        }

        public static string adminMenu()
        {
            MainUI.header();

            Console.WriteLine("        1. Add a player.");
            Console.WriteLine("        2. Remove a player.");
            Console.WriteLine("        3. Check Finances.");
            Console.WriteLine("        4. Search a player.");
            Console.WriteLine("        5. Add a coach.");
            Console.WriteLine("        6. Remove a coach.");
            Console.WriteLine("        7. Add Achievements.");
            Console.WriteLine("        8. Check Team.");
            Console.WriteLine("        9. Check Management Staff.");
            Console.WriteLine("        10. Change a player's name.");
            Console.WriteLine("        11. Schedule a match.");
            Console.WriteLine("        12. Exit.");
            Console.Write("Enter an option...");
            string option;
            option = Console.ReadLine();
            return option;
        }

        public static string coachMenu()
        {
            MainUI.header();

            Console.WriteLine("        1. Search a player.");
            Console.WriteLine("        2. Check Schedule.");
            Console.WriteLine("        3. Check Team.");
            Console.WriteLine("        4. Change playing XI.");
            Console.WriteLine("        5. Check statistics of players.");
            Console.WriteLine("        6. Schedule Training Session.");
            Console.WriteLine("        7. Check Achievements.");
            Console.WriteLine("        8. Add Player Statistics.");
            Console.WriteLine("        9. Exit.");
            Console.Write("Enter an option...");
            string option;
            option = Console.ReadLine();
            return option;
        }

        public static string fanMenu()
        {
            Console.WriteLine("1. Check Schedule.");
            Console.WriteLine("2. Check Statistics of players");
            Console.WriteLine("3. Check Achievements");
            Console.WriteLine("4. Exit");
            string option;
            Console.Write("Enter your option...");
            option = Console.ReadLine();
            return option;
        }

        public static string Menu()
        {
            MainUI.header();

            Console.ForegroundColor = ConsoleColor.Blue;

            string option;
            Console.WriteLine("       1. Sign In");
            Console.WriteLine("       2. Sign Up (Only for Fans)");
            Console.WriteLine("       3. Exit");
            Console.Write("       Enter you option...");
            option = Console.ReadLine();
            return option;
        }


    }
}
