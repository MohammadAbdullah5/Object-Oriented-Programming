using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sign_In_Sign_Up_2
{
    class MUserDL
    {
        private static List<MUser> users = new List<MUser>();

        internal static List<MUser> Users { get => users; set => users = value; }

        public static void addIntoList(MUser user)
        {
            Users.Add(user);
        }

        public static MUser SignIn(MUser user)
        {
            foreach (var storedUser in users)
            {
                if (storedUser.Username == user.Username && storedUser.Password == user.Password)
                {
                    return storedUser;
                }
            }
            return null;
        }

        public static bool readDataFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while((record = file.ReadLine()) != null)
                {
                    string[] records = record.Split(',');
                    string username = records[0];
                    string password = records[1];
                    string role = records[2];
                    MUser user = new MUser(username, password, role);
                    addIntoList(user);
                }
                file.Close();
                return true;
            }

            else
            {
                return false;
            }
        }

        public static void storeInFile(MUser user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.Username + "," + user.Password + "," + user.Role);
            file.Flush();
            file.Close();
        }

        public static void storeAllInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (var user in users)
            {
                file.WriteLine(user.Username + "," + user.Password + "," + user.Role);
            }
            file.Flush();
            file.Close();
        }

        public static void deleteUserFromList(MUser user)
        {
            for(int i = 0; i < users.Count(); i++)
            {
                if(users[i].Username == user.Username && users[i].Password == user.Password)
                {
                    users.RemoveAt(i);
                }
            }
        }

        public static void editUserFromList(MUser previous, MUser next)
        {
            foreach(var storedUser in users)
            {
                if (storedUser.Username == previous.Username && storedUser.Password == previous.Password)
                {
                    storedUser.Username = next.Username;
                    storedUser.Password = next.Password;
                    storedUser.Role = next.Role;
                }
            }
        }
    }
}
