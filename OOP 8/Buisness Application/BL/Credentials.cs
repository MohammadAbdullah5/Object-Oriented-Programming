using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Credentials
    {
        private string username;
        private string password;
        private string role;

        public Credentials(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public Credentials(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setRole(string role)
        {
            this.role = role;
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
    }
}
