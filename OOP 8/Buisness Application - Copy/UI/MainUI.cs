using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class MainUI
    {
        public static void header()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("             _________        .__        __           __    _________ .__       ___.                                                          ");
            Console.WriteLine("             \\_   ___ \\_______|__| ____ |  | __ _____/  |_  \\_   ___ \\|  |  __ _\\_ |__                                                   ");
            Console.WriteLine("             /    \\  \\/\\_  __ \\  |/ ___\\|  |/ // __ \\   __\\ /    \\  \\/|  | |  |  \\ __ \\                                            ");
            Console.WriteLine("             \\     \\____|  | \\/  \\  \\___|    <\\  ___/|  |   \\     \\___|  |_|  |  / \\_\\ \\                                           ");
            Console.WriteLine("              \\______  /|__|  |__|\\___  >__|_ \\\\___  >__|    \\______  /____/____/|___  /                                                 ");
            Console.WriteLine("                     \\/               \\/     \\/    \\/               \\/               \\/                                                 ");
            Console.WriteLine("     _____                                                             __      _________               __                                     ");
            Console.WriteLine("   /     \\ _____    ____ _____     ____   ____   _____   ____   _____/  |_   /   _____/__.__. _______/  |_  ____   _____                     ");
            Console.WriteLine("  /  \\ /  \\\\__  \\  /    \\\\__  \\   / ___\\_/ __ \\ /     \\_/ __ \\ /    \\   __\\  \\_______<   |  |/  ___/\\   __\\/ __ \\ /     \\   ");
            Console.WriteLine(" /    Y    \\/ __ \\|   |  \\/ __ \\_/ /_/  >  ___/|  Y Y  \\  ___/|   |  \\  |    /        \\___  |\\___ \\  |  | \\  ___/|  Y Y  \\         ");
            Console.WriteLine(" \\____|__  (____  /___|  (____  /\\___  / \\___  >__|_|  /\\___  >___|  /__|   /_______  / ____/____  > |__|  \\___  >__|_|  /               ");
            Console.WriteLine("         \\/     \\/     \\/     \\//_____/      \\/      \\/     \\/     \\/               \\/\\/         \\/            \\/      \\/        ");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void welcome()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                        d8b             888                   888   ");
            Console.WriteLine("                                        888                   888   ");
            Console.WriteLine("                                        888                   888   ");
            Console.WriteLine("     .d8888b8  88d888   888    .d8888   b888 .d88    .d88b.   888888");
            Console.WriteLine("    d88P       888P     888   d88P      888.d88P     d8  8    Y8b   ");
            Console.WriteLine("    Y88b.      888      888   Y88b.     888  .d88    Y8b/     Y88   ");
            Console.WriteLine("      Y8888P   888      888     Y8888   P888    88    Y8888    Y8880");

            Console.Write("Enter any key to continue...");
            Console.ReadLine();
        }

    }
}
