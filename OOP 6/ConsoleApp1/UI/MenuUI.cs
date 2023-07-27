using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.UI
{
    class MenuUI
    {
        public static string menu()
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students of a specific program");
            Console.WriteLine("6. Register Subjects for a specific student");
            Console.WriteLine("7. Calculate Fees for all registered students");
            Console.WriteLine("8. Exit");
            Console.Write("   Enter your option...");
            string option = Console.ReadLine();
            return option;
        }

        public static void header()
        {
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("                             UAMS                                     ");
            Console.WriteLine("**********************************************************************");
        }

        public static void clrScreen()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
