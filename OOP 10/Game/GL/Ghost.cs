using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GL
{
    public abstract class Ghost : GameObject
    {
        public Ghost(char character) : base(GameObjectType.ENEMY, character)
        {

        }

        public GameDirection direction;
        public virtual void changeDirection()
        {
           
        }
        public abstract GameCell move(); 
    }
}
