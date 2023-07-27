using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Credentials
    {
        public string username;
        public string password;
        public string role;

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
    }
}
