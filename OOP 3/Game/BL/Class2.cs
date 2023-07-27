using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.BL
{
    class Enemy
    {
        public int posX;
        public int posY;
        public int health;
        public string direction;

        public Enemy(int posX, int posY, int health, string direction)
        {
            this.posX = posX;
            this.posY = posY;
            this.health = health;
            this.direction = direction;
        }
    }
}
