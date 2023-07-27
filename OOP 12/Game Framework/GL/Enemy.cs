using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game_Framework.GL
{
    public abstract class Enemy : GameObject
    {
        protected int fireTime = 0;

        public List<Bullet> Fires = new List<Bullet>();
        public Enemy(Image display, ProgressBar health) : base(GameObjectType.ENEMY, display, health)
        {
            this.health = health;
        }

        public GameDirection direction;
        public abstract GameCell move(); 
        public abstract bool addBullet();
        public abstract Image getBulletImage();
    }
}
