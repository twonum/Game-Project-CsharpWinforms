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
    public partial class Watermelon : Form
    {
        bool jump;
        int gravity;
        int score;
        int speed;
        public Watermelon()
        {
            if (Program.water_Melon_Start == true)
            {
                InitializeComponent();
                gameOverLBL.Visible = false;
                castle.Hide();
            }
        }

        void moveBases()
        {
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && item.Tag == "Base")
                {
                    if (item.Left<-200)
                    {
                        item.Left = 900;
                    }
                    else if (player.Bounds.IntersectsWith(item.Bounds))
                    {
                        player.Top = item.Top - player.Height;
                    }
                    else if (player.Bounds.IntersectsWith(finalBase.Bounds))
                    {
                        player.Size = new Size(40, 50);
                        player.Top = finalBase.Top - player.Height;
                        speed = 0;
                    }
                    else
                    {
                        item.Left -= speed;
                    }
                }
            }
        }
        void jumpControl()
        {
            player.Top += speed;
            if (jump&&gravity<0)
            {
                jump = false;
            }
            else if (jump)
            {
                player.Top = speed;
                gravity -= 20;
            }
            
            else
            {
                speed = 5;
                gravity = 0;
            }
        }
        private void Watermelon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.Left -= 10;
            }
            if (e.KeyCode == Keys.Right)
            {
                player.Image = My_Car_Game_GUI.Properties.Resources.Walk__8_;
                player.Left += 10;
            }
            if (e.KeyCode == Keys.Space && !jump)
            {
                player.Image = My_Car_Game_GUI.Properties.Resources.Idle__2_;
                jump = true;
            }
        }
        void coinControll()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "coin")
                {
                    coin1.Top = base1.Width;
                    Random random = new Random();
                    int a;
                    if (x.Left <-900)
                    {
                        x.Left -= speed;
                        a = random.Next(1000);
                        x.Location = new Point(a, 200);
                    }
                    else if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        a = random.Next(1000);
                        x.Location = new Point(a, 100);
                        score+=5;
                        scoreLBL.Text = "Score: " + score;
                    }
                    else
                    {
                        x.Left -= speed;
                    }
                }
            }
        }

        void gameOver()
        {
            if (player.Bounds.IntersectsWith(ground.Bounds))
            {
                player.Image = My_Car_Game_GUI.Properties.Resources.Dead__8_;
                scoreLBL.Text = "score: " + score;
                timer1.Stop();
                gameOverLBL.Visible = true;
                timer2.Start();
            }
            else if (score>50)
            {
                castle.Show();
                if (player.Bounds.IntersectsWith(castle.Bounds))
                {
                    player.Hide();
                    timer1.Stop();
                    gameOverLBL.Visible = true;
                    timer2.Start();

                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            jumpControl();
            moveBases();
            coinControll();
            gameOver();
        }

        private void gameOverLBL_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            goBackForm backForm = new goBackForm();
            backForm.Show();
        }
    }
}
