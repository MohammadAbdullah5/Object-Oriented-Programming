using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class CredentialsCRUD
    {
        public static List<Credentials> users = new List<Credentials>();

        public static Credentials login(Credentials user)
        {
            foreach (Credentials storedUser in users)
            {
                if ((user.username == storedUser.username) && (user.password == storedUser.password))
                {
                    return storedUser;
                }
            }
            return null;
        }

        public static void storeDataInList(Credentials info)
        {
            users.Add(info);
        }

        public static Credentials takeInputWithoutRole()
        {
            Credentials user = CredentialsUI.TakeInputWithoutRole();
            if (user.username != null && user.password != null)
            {
                return user;
            }

            return null;
        }

        public static void addUser()
        {
            Credentials user = CredentialsUI.TakeInputWithRole();

            if (user.role == "Admin" || user.role == "Customer")
            {
                if (users.Count <= 99)
                {
                    users.Add(user);
                }
                else
                {
                    Console.WriteLine("       User Limit Exceeded.");
                }
            }
            else
            {
                Console.WriteLine("       Invalid User type");
            }

        }

        

        public static void storeUsersData(List<Credentials> users)
        {
            string usersPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Programming Fundamentals\\Project\\Data.txt";
            StreamWriter file = new StreamWriter(usersPath, false);
            for (int x = 0; x < users.Count; x++)
            {
                file.WriteLine(users[x].username + "," + users[x].password + "," + users[x].role);
            }
            file.Flush();
            file.Close();
        }

    }
}
