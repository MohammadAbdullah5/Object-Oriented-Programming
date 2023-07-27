using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class CredentialsUI
    {
        public static Credentials TakeInputWithRole()
        {
            Console.Write("       Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("       Enter Password: ");
            string password = Console.ReadLine();
            Console.Write("       Enter Role: ");
            string role = Console.ReadLine();
            Credentials user = new Credentials(username, password, role);
            return user;
        }

        public static Credentials TakeInputWithoutRole()
        {
            Console.Write("       Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("       Enter Password: ");
            string password = Console.ReadLine();
            Credentials user = new Credentials(username, password);
            return user;
        }
    }
}
