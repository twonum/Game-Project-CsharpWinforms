using EZInput;
using My_Car_Game_GUI.GameLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Car_Game_GUI
{
    public partial class Car_Game_Maze : Form
    {
        GameGrid grid;
        List<Enemey> enemyCars = new List<Enemey>();
        List<GameFire> fires = new List<GameFire>();
        List<GameFire> enemyFires = new List<GameFire>();
        HorizontalEnemy Horizontal;
        VerticalEnemy Vertical;
        RandomEnemy Random;
        SmartEnemy Smart;
        PlayerCar player;

        int playerFireCounter = 0;
        int playerLivesCount = 4;
        GameCell playerFireCell;
        GameFire playerFire;
        GameCell horizontalEnemy1FireCell;
        GameFire horizontalEnemy1Fire;
        int horizontalEnemyFireCounter = 0;


        public Car_Game_Maze()
        {
            InitializeComponent();
            gameOverLBL.Visible= false;
        }

        private void Car_Game_Maze_Load(object sender, EventArgs e)
        {
            grid = new GameGrid("carMaze.txt", 24, 33);


            Image playerCar = Game.getGameObjectImage('c');
            Image verticalEnemyCar = Game.getGameObjectImage('v');
            Image horizontalEnemyCar = Game.getGameObjectImage('h');
            Image randomEnemyCar = Game.getGameObjectImage('r');
            Image smartEnemyCar = Game.getGameObjectImage('p');

            GameCell startCell = grid.getCell(8, 10);
            GameCell Vertical_Enemy_Cell = grid.getCell(3, 27);
            GameCell Horizontal_Enemy_Cell = grid.getCell(1, 30);
            GameCell Random_Enemy_Cell = grid.getCell(7, 14);
            GameCell Smart_Enemy_Cell = grid.getCell(3, 25);

            player = new PlayerCar(startCell, playerCar);
            Horizontal = new HorizontalEnemy(horizontalEnemyCar, Horizontal_Enemy_Cell, GameDirection.Left);
            Vertical = new VerticalEnemy(verticalEnemyCar, Vertical_Enemy_Cell, GameDirection.Down);
            Random = new RandomEnemy(randomEnemyCar, Random_Enemy_Cell);
            Smart = new SmartEnemy(smartEnemyCar, Smart_Enemy_Cell, 0, player);

            enemyCars.Add(Horizontal);
            enemyCars.Add(Vertical);
            enemyCars.Add(Random);
            enemyCars.Add(Smart);


            printMaze(grid);
        }
        void printMaze(GameGrid gameGrid)
        {
            for (int i = 0; i < gameGrid.Rows; i++)
            {
                for (int j = 0; j < gameGrid.Columns; j++)
                {
                    GameCell cell = gameGrid.getCell(i, j);
                    this.Controls.Add(cell.PictureBox);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            collisionHealthManaging();
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.move(GameDirection.Left);
                
            }
            else if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.move(GameDirection.Right);
                
            }
            else if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                player.move(GameDirection.Up);
                
            }
            else if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                player.move(GameDirection.Down);
                
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                generatePlayerBullet();
            }

            manageHealth();

            
            //Bullet Detection
            foreach (Enemey item in enemyCars)
            {
                if (item.bulletDetection(player))
                {
                    if (progressBar2.Value == 0)
                    {
                        goBackMenu();
                    }
                    else
                    {
                        progressBar2.Value -= 15;
                    }

                }
            }
            foreach (Enemey item in enemyCars)
            {
                if (item.collisionDetection(player))
                {
                    progressBar1.Value -= 25;
                    manageHealth();
                }
            }
            

            //Firing
            foreach (GameFire item in fires)
            {
                item.MovePlayerFire(grid);
                if (!item.GetFlag())
                {
                    fires.Remove(item);
                    item.CurrentCell.PictureBox.Image = My_Car_Game_GUI.Properties.Resources.transparent;
                    break;
                }
            }
            //Enemy
            foreach (GameFire i in enemyFires)
            {
                i.moveEnemyFire(grid);
                if (!i.GetFlag())
                {
                    enemyFires.Remove(i);
                    i.CurrentCell.PictureBox.Image = Properties.Resources.transparent;
                    break;
                }
            }
            generateHorizontalEnemyBullet();
            playerFireCounter++;
            horizontalEnemyFireCounter++;
        }
        private void generatePlayerBullet()
        {
            if (playerFireCounter>=4)
            {
                playerFireCell = new GameCell(player.CurrentCell.X, player.CurrentCell.Y,grid);
                playerFire = new GameFire(playerFireCell, My_Car_Game_GUI.Properties.Resources.arrowUp,GameObjectType.Fire);
                fires.Add(playerFire);
                playerFireCounter = 0;
            }
        }

        private void generateHorizontalEnemyBullet()
        {

            if (horizontalEnemyFireCounter >= 4)
            {

                if (Horizontal != null && enemyCars.Contains(Horizontal))
                {
                    horizontalEnemy1FireCell = new GameCell(Horizontal.CurrentCell.X, Horizontal.CurrentCell.Y, grid);
                    horizontalEnemy1Fire = new GameFire(horizontalEnemy1FireCell, Properties.Resources.arrowDown,GameObjectType.EnemyFire);
                    enemyFires.Add(horizontalEnemy1Fire);
                }

                horizontalEnemyFireCounter = 0;
            }
        }
            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            goBackForm backForm = new goBackForm();
            backForm.Show();
        }

        private void gameOverLBL_Click(object sender, EventArgs e)
        {

        }
        void collisionHealthManaging()
        {
            if (!player.getFlag() && progressBar1.Value >= 0)
            {
                progressBar1.Value -= 25;
                player.setPlayerFlag(true);
            }
            if (!player.getFlag() && progressBar1.Value >= 0)
            {
                progressBar1.Value -= 25;
                player.setPlayerFlag(true);
            }
            if (!player.getFlag() && progressBar1.Value >= 0)
            {
                progressBar1.Value -= 25;
                player.setPlayerFlag(true);
            }
            if (!player.getFlag() && progressBar1.Value >= 0)
            {
                progressBar1.Value -= 25;
                player.setPlayerFlag(true);
            }
        }
        void manageHealth()
        {
            if (progressBar1.Value == 0 && playerLivesCount == 4)
            {
                pbHeart3.Hide();
                progressBar1.Value = 100;
                playerLivesCount--;
            }

            if (progressBar1.Value == 0 && playerLivesCount == 3)
            {
                pbHeart2.Hide();
                playerLivesCount--;
                progressBar1.Value = 100;
            }

            if (progressBar1.Value == 0 && playerLivesCount == 2)
            {
                pbHeart1.Hide();
                playerLivesCount--;
                progressBar1.Value = 100;
            }
            if (progressBar1.Value == 0 && playerLivesCount == 1)
            {
                pbHeart1.Hide();
                playerLivesCount--;
            }

            if ( playerLivesCount <= 0)
            {
                goBackMenu();
            }
        }
        void goBackMenu()
        {
            timer1.Stop();
            gameOverLBL.Visible = true;
            timer2.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            foreach (Enemey g in enemyCars)
            {
                g.move();
            }
        }
    }
}