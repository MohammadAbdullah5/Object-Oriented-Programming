using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game_Framework.GL
{
    public class Game
    {
        static int score = 0;

        public static void addScore()
        {
            score++;
        }

        public static int getScore()
        {
            return score;
        }

        public static GameObject getBlankGameObject()
        {
            GameObject blank = new GameObject(GameObjectType.NONE, Properties.Resources.simple_box);
            return blank;
        }

        public static Image getImage(char character)
        {
            Image img = Game_Framework.Properties.Resources.simple_box;
            if (character == '*')
            {
                img = Game_Framework.Properties.Resources.horizontal;
            }

            else if (character == '|')
            {
                img = Game_Framework.Properties.Resources.vertical;
            }

            else if (character == 'P')
            {
                img = Game_Framework.Properties.Resources.player;
            }

            else if (character == 'V')
            {
                img = Game_Framework.Properties.Resources.enemy_cyan;
            }

            else if (character == 'H')
            {
                img = Game_Framework.Properties.Resources.enemy_purple;
            }

            else if (character == 'R')
            {
                img = Game_Framework.Properties.Resources.enemy_yellow;
            }

            else if (character == 'S')
            {
                img = Game_Framework.Properties.Resources.enemy_red;
            }

            return img;
        }
    }
}
