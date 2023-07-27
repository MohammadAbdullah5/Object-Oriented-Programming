using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Framework.GL
{
    class Player : GameObject
    {
        public List<Bullet> playerFires = new List<Bullet>();
        public Player(Image img, GameCell startCell, ProgressBar health) : base(GameObjectType.PLAYER, img, health)
        {
            CurrentCell = startCell;
        }

        public GameCell move(GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            this.CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());

            }
            return nextCell;
        }

        public bool detectCollisionWithEnemy()
        {
            if(CurrentCell.CurrentGameObject.type == GameObjectType.ENEMY)
            {
                return true;
            }
            return false;
        }
    }
}
