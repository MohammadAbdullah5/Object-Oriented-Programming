using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_in_Sign_Up.BL
{
    class Credentials
    {
        private string username;
        private string password;
        private string role;

        public Credentials(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public Credentials(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

        public string getRole()
        {
            return role;
        }

        public bool isAdmin()
        {
            if(role == "Admin")
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
