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
        public List<Bullets> bullets = new List<Bullets>();

        public Enemy(int posX, int posY, int health, string direction)
        {
            this.posX = posX;
            this.posY = posY;
            this.health = health;
            this.direction = direction;
        }

        public void bulletsAdd()
        {
            Bullets enemyBullet = new Bullets();
            enemyBullet.posX = posX - 1;
            enemyBullet.posY = posY;
            enemyBullet.isActive = true;
            bullets.Add(enemyBullet);
        }

        public void makeBulletInactive(int idx)
        {
            bullets[idx].isActive = false;
        }
    }
}
