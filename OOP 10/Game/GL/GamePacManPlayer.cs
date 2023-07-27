using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GL
{
    class GamePacManPlayer : GameObject
    {
        public GamePacManPlayer(char character, GameCell startCell) : base(GameObjectType.PLAYER, character)
        {
            CurrentCell = startCell;
        }

        public GameCell move(GameDirection direction)
        {
            return this.CurrentCell.nextCell(direction);
        }
    }
}
