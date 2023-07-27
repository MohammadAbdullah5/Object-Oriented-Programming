using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.BL
{
    class Player
    {
        public int posX;
        public int posY;
        public int health;
        public List<Bullets> bullets = new List<Bullets>();

        public Player()
        {
            posX = 16;
            posY = 10;
            health = 300;
        }

        public void bulletsAdd()
        {
            Bullets playerBullet = new Bullets();
            playerBullet.posX = posX + 10;
            playerBullet.posY = posY;
            playerBullet.isActive = true;
            bullets.Add(playerBullet);
        }

        public void makeBulletInactive(int idx)
        {
            bullets[idx].isActive = false;
        }

    }
}
