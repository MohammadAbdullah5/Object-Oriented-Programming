using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Framework.GL;
using EZInput;

namespace Game_Framework
{
    public partial class GameForm : Form
    {
        GameGrid grid = new GameGrid("Maze.txt", 10, 18);
        Player player;
        VerticalEnemy vEnemy;
        HorizontalEnemy hEnemy;
        RandomEnemy rEnemy;
        SmartEnemy sEnemy;
        Enemy enemy;
        bool flag;
        bool collision;

        int enemyCount;

        public GameForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            printMaze(grid);

            Image playerImg = Game.getImage('P');
            GameCell startPlayerCell = grid.getCell(5, 2);
            player = new Player(playerImg, startPlayerCell, playerHealthBar);

            timerGameLoop.Enabled = true;
            flag = false;
            enemyCount = 0;
        }

        private void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    cell.PictureBox.Visible = true;
                    Controls.Add(cell.PictureBox);
                }
            }
        }

        private void timerGameLoop_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                player.move(GameDirection.Up);
            }

            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                player.move(GameDirection.Down);
            }

            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.move(GameDirection.Left);
            }

            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.move(GameDirection.Right);
            }

            if (Keyboard.IsKeyPressed(Key.Space))
            {
                Image fireImg = Properties.Resources.Fire_Player;
                Bullet fire = new Bullet(fireImg, player.CurrentCell.nextCell(GameDirection.Right));
                player.playerFires.Add(fire);
            }

            enemy = getEnemy();
            if (enemy != null)
            {
                enemy.move();
                addEnemyBullet(enemy);
                moveEnemyFires(enemy);
            }
            moveFires();
            int score = Game.getScore();
            lblScore.Text = score.ToString();

            collision = player.detectCollisionWithEnemy();
            if(collision == true || playerHealthBar.Value <= 0)
            {
                LoseForm form = new LoseForm();
                form.Show();
                this.Hide();
                timerGameLoop.Enabled = false;
            }

            flag = detectVictory();
            if(flag == true)
            {
                VictoryForm form = new VictoryForm();
                form.Show();
                this.Hide();
                timerGameLoop.Enabled = false;
            }
        }

        private bool detectVictory()
        {
            if(sEnemyHealthBar.Value == 0)
            {
                return true;
            }
            return false;
        }

        private void moveFires()
        {
            for (var i = 0; i < player.playerFires.Count; i++)
            {
                Bullet fire = player.playerFires[i];
                fire.move(GameDirection.Right);
                if (fire.collisionWithEnemy() != null)
                {
                    player.playerFires.Remove(fire);
                }
            }
        }

        private void moveEnemyFires(Enemy enemy)
        {
            for (var i = 0; i < enemy.Fires.Count; i++)
            {
                Bullet fire = enemy.Fires[i];
                fire.move(GameDirection.Left);
                if (fire.collisionWithPlayer() != null)
                {
                    enemy.Fires.Remove(fire);
                }
            }
        }

        private Enemy getEnemy()
        {
            if (enemyCount == 0)
            {
                Image verticalEnemyImg = Game.getImage('V');
                GameCell verticalEnemyCell = grid.getCell(4, 15);
                vEnemy = new VerticalEnemy(verticalEnemyImg, verticalEnemyCell, GameDirection.Up, vEnemyHealthBar);
                SetLblPbAndHealthBarVisibilityFalse();
                pbEnemyCyanLbl.Visible = true;
                vEnemyHealthBar.Visible = true;
                enemyCount++;
            }

            else if (enemyCount == 1)
            {
                if (vEnemyHealthBar.Value > 0)
                {
                    return vEnemy;
                }

                else
                {
                    enemyCount++;
                }
            }

            else if (enemyCount == 2)
            {
                Image horizontalEnemyImg = Game.getImage('H');
                GameCell horizontalEnemyCell = grid.getCell(6, 10);
                hEnemy = new HorizontalEnemy(horizontalEnemyImg, horizontalEnemyCell, GameDirection.Left, hEnemyHealthBar);
                SetLblPbAndHealthBarVisibilityFalse();
                pbEnemyPurpleLbl.Visible = true;
                hEnemyHealthBar.Visible = true;
                enemyCount++;
            }

            else if (enemyCount == 3)
            {
                if (hEnemyHealthBar.Value > 0)
                {
                    return hEnemy;
                }

                else
                {
                    enemyCount++;
                }
            }

            else if (enemyCount == 4)
            {
                Image randomEnemyImg = Game.getImage('R');
                GameCell randomEnemyCell = grid.getCell(2, 13);
                rEnemy = new RandomEnemy(randomEnemyImg, randomEnemyCell, rEnemyHealthBar);
                SetLblPbAndHealthBarVisibilityFalse();
                pbEnemyYellowLbl.Visible = true; 
                rEnemyHealthBar.Visible = true;
                enemyCount++;
            }

            else if (enemyCount == 5)
            {
                if (rEnemyHealthBar.Value > 0)
                {
                    return rEnemy;
                }

                else
                {
                    enemyCount++;
                }
            }

            else if (enemyCount == 6)
            {
                Image smartEnemyImg = Game.getImage('S');
                GameCell smartEnemyCell = grid.getCell(5, 13);
                sEnemy = new SmartEnemy(smartEnemyImg, smartEnemyCell, player, sEnemyHealthBar);
                SetLblPbAndHealthBarVisibilityFalse();
                sEnemyHealthBar.Visible = true;
                pbEnemyRedLbl.Visible = true;

                enemyCount++;
            }

            else if (enemyCount == 7)
            {
                if (sEnemyHealthBar.Value > 0)
                {
                    return sEnemy;
                }

                else
                {
                    enemyCount++;
                }
            }
            return null;
        }

        public void addEnemyBullet(Enemy enemy)
        {
            if (enemy.addBullet())
            {
                Bullet bullet = new Bullet(enemy.getBulletImage(), enemy.CurrentCell.nextCell(GameDirection.Left));
                enemy.Fires.Add(bullet);
            }
        }

        private void SetLblPbAndHealthBarVisibilityFalse()
        {
            pbEnemyCyanLbl.Visible = false;
            pbEnemyYellowLbl.Visible = false;
            pbEnemyPurpleLbl.Visible = false;
            pbEnemyRedLbl.Visible = false;

            sEnemyHealthBar.Visible = false;
            vEnemyHealthBar.Visible = false;
            hEnemyHealthBar.Visible = false;
            rEnemyHealthBar.Visible = false;
        }
    }
}