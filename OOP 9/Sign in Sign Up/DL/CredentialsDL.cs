using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sign_in_Sign_Up.BL;
using System.IO;

namespace Sign_in_Sign_Up.DL
{
    class CredentialsDL
    {
        public static List<Credentials> users = new List<Credentials>();

        public static bool login(Credentials user)
        {
            foreach (Credentials storedUser in users)
            {
                if ((user.getUsername() == storedUser.getUsername()) && (user.getPassword() == storedUser.getPassword()))
                {
                    return true;
                }
            }
            return false;
        }

        public static void storeDataInList(Credentials info)
        {
            users.Add(info);
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
                    Credentials user = new Credentials(username, password, role);
                    users.Add(user);

                }
                file.Close();
                return true;
            }

            else
            {
                return false;
            }
        }

        public static void storeInFile(string path)
        {
            if (File.Exists(path))
            {
                StreamWriter file = new StreamWriter(path, false);
                foreach (Credentials user in users)
                {
                    file.WriteLine(user.getUsername() + "," + user.getPassword() + "," + user.getRole());
                }
            }

            else
            {
                return;
            }
        }
    }
}
