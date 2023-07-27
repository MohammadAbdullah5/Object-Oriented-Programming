using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisness_Application.DL;

namespace Buisness_Application.BL
{
    class Person
    {
        protected string name;
        protected string role;
        protected int age;
        protected int salary;
        protected Credentials credentials;

        public Person(string name, string role, int age, int salary, Credentials credentials)
        {
            this.name = name;
            this.age = age;
            this.role = role;
            this.salary = salary;
            this.credentials = credentials;
        }

        public Person(string name, Credentials credentials)
        {
            this.name = name;
            this.age = 0;
            this.credentials = credentials;
            role = null;
            salary = 0;
        }

        public Person(string name, int age, Credentials credentials)
        {
            this.name = name;
            this.age = age;
            this.credentials = credentials;
            role = null;
            salary = 0;
        }

        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public string getRole()
        {
            return role;
        }

        public int getSalary()
        {
            return salary;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setRole(string role)
        {
            this.role = role;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        public Credentials getCredentials()
        {
            return credentials;
        }

        public virtual string toString()
        {
            return role;
        }

        public virtual void startInterface()
        {
            if(this.credentials.getRole() == "Fan")
            {
                Interface.fansInterface();
            }

            else if(this.credentials.getRole() == "Admin")
            {
                Interface.adminInterface();
            }
        }

        public virtual Stats getStats()
        {
            return null;
        }

        public virtual string getBattingStyle()
        {
            return null;
        }

        public virtual string getBowlingStyle()
        {
            return null;
        }

        public virtual string getPlayerRole()
        {
            return null;
        }

        public virtual string getCoachRole()
        {
            return null;
        }
    }
}
