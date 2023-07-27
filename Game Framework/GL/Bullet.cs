using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game_Framework.GL
{
    public class Bullet : GameObject
    {
        public Bullet(Image img, GameCell startCell) : base(GameObjectType.FIRE, img)
        {
            CurrentCell = startCell;
        }

        public GameCell move(GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            this.CurrentCell = nextCell;
            currentCell.setGameObject(Game.getBlankGameObject());
            return nextCell;
        }

        public GameObject collisionWithEnemy()
        {
            GameCell nxtCell = CurrentCell.nextCell(GameDirection.Right);

            if (nxtCell.CurrentGameObject.type == GameObjectType.ENEMY)
            {
                Enemy ghost = (Enemy)nxtCell.CurrentGameObject;
                CurrentCell.setGameObject(Game.getBlankGameObject());
                if (ghost.health.Value != 0)
                {
                    CurrentCell.setGameObject(Game.getBlankGameObject());
                    ghost.health.Value -= 10;
                    Game.addScore();
                }

                if (ghost.health.Value == 10)
                {
                    nxtCell.setGameObject(Game.getBlankGameObject());
                    ghost.health.Value -= 10;
                }
                return nxtCell.CurrentGameObject;
            }
            return null;
        }

        public GameObject collisionWithPlayer()
        {
            GameCell nxtCell = CurrentCell.nextCell(GameDirection.Left);

            if (nxtCell.CurrentGameObject.type == GameObjectType.PLAYER)
            {
                Player player = (Player)nxtCell.CurrentGameObject;
                CurrentCell.setGameObject(Game.getBlankGameObject());
                if (player.health.Value != 0)
                {
                    CurrentCell.setGameObject(Game.getBlankGameObject());
                    player.health.Value -= 5;
                }

                if (player.health.Value == 5)
                {
                    nxtCell.setGameObject(Game.getBlankGameObject());
                    player.health.Value -= 5;
                }
                return nxtCell.CurrentGameObject;
            }
            return null;
        }
    }
}