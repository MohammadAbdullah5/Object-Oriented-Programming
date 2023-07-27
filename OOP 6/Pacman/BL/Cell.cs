using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BL
{
    class Cell
    {
        public int x;
        public int y;
        public char value;

        public Cell(char value, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.value = value; 
        }

        public char getValue()
        {
            return value;
        }

        public void setValue(char character)
        {
            value = character;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public bool isPacmanPresent()
        {
            if(value == 'P' || value == 'p')
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool isGhostPresent(char GhostChar)
        {
            if (value == GhostChar)
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
