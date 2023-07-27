using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Subject
    {
        public string code;
        public string name;
        public int creditHours;
        public int fees;

        public Subject( string name, string code, int creditHours, int fees)
        {
            this.code = code;
            this.name = name;
            this.creditHours = creditHours;
            this.fees = fees;
        }
    }
}
