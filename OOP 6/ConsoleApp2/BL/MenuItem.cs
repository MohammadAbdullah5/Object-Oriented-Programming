using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MenuItem
    {
        public string name;
        public bool type;
        public int price;

        public MenuItem(string name, bool type, int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
    }
}
