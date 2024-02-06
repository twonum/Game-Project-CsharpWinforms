using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Car_Game_GUI
{
    public partial class Player : Form
    {
        public Player()
        {
            if (Program.arow_Game_Start==true)
            {
                InitializeComponent();
                gameOverLBL.Visible = false;
            }
        }
        int score = -5;
        void collision()
        {
            if (Arrow.Bounds.IntersectsWith(b1.Bounds))
            {
                b1.Top = 400;
                score += 5;
                label1.Text = "Score: " + score;
                Arrow.Image = My_Car_Game_GUI.Properties.Resources.Explosion;
            }
            if (Arrow.Bounds.IntersectsWith(b2.Bounds))
            {
                b2.Top = 400;
                score += 5;
                label1.Text = "Score: " + score;
                Arrow.Image = My_Car_Game_GUI.Properties.Resources.Explosion;
            }
            if (Arrow.Bounds.IntersectsWith(b3.Bounds))
            {
                b3.Top = 400;
                score += 5;
                label1.Text = "Score: " + score;
                Arrow.Image = My_Car_Game_GUI.Properties.Resources.Explosion;
            }
            
        }
        void baloon()
        {
            Random random = new Random();
            int x, y, z;
            if (b1.Top<20)
            {
                b1.Top = 300;
                x = random.Next(200,600);
                b1.Location = new Point(x, 500);
            }
            if (b2.Top < 20)
            {
                b2.Top = 300;
                y = random.Next(200, 600);
                b2.Location = new Point(y, 500);
            }
            if (b3.Top < 20)
            {
                b3.Top = 300;
                z = random.Next(200, 600);
                b3.Location = new Point(z, 500);
            }
            else
            {
                b1.Top -= 5;
                b2.Top -= 8;
                b3.Top -= 10;
            }
        }
        private void Player_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Arrow.Left = pictureBox1.Left;
                pictureBox1.Image = My_Car_Game_GUI.Properties.Resources.shoot;
            }
            //if (e.KeyCode == Keys.Up)
            //{
            //    if (pictureBox1.Top > 50)
            //    {
            //        pictureBox1.Top = -5;
            //    }
                
            //}
            //if (e.KeyCode == Keys.Down)
            //{
            //    if (pictureBox1.Top < 200)
            //    {
            //        pictureBox1.Top = +5;
            //    }
            //}
        }
        void shoot()
        {
            Arrow.Left += 100;
            if (Arrow.Left>600)
            {
                pictureBox1.Image = My_Car_Game_GUI.Properties.Resources.idle;
                Arrow.Image = My_Car_Game_GUI.Properties.Resources.arrow;
                Arrow.Top = pictureBox1.Top + 35;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            collision();
            shoot();
            baloon();
            if (score == 35)
            {
                timer1.Stop();
                gameOverLBL.Visible = true;
                timer2.Start();
            }
        }

        private void Player_KeyUp(object sender, KeyEventArgs e)
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
