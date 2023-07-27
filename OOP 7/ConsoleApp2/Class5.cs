using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        protected string name;

        public Person(string name)
        {
            this.name = name;
        }

        public void drive()
        {
            //Code for driving
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void extinguish()
        {
            //Code for Extinguish Fire
        }
    }
}