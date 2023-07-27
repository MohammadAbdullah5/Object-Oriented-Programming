using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_In_Sign_Up_2
{
    public class MUser
    {
        private string username;
        private string password;
        private string role;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public MUser(string username, string password, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public MUser(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.Role = "NA";
            this.Role = role;
        }

        public bool isAdmin()
        {
            if(Role == "Admin")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
