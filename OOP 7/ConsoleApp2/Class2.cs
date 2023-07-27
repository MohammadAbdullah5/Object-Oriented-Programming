using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Ladder
    {
        private int length;
        private string colour;

        public int getLength()
        {
            return length;
        }

        public string getColour()
        {
            return colour;
        }

        public void setLength(int len)
        {
            length = len;
        }

        public void setColour(string col)
        {
            colour = col;
        }
    }
}
