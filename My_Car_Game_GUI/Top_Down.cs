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
    public partial class Top_Down : Form
    {
        public Top_Down()
        {
            if (Program.top_Down_Start==true)
            {
                InitializeComponent();
                gameOverLBL.Visible = false;
            }
        }
        void movePlayer()
        {
            if (right==true)
            {
                if (player.Left<200)
                {
                    player.Left += 5;
                }
            }
            if (left==true)
            {
                if (player.Left>20)
                {
                    player.Left -= 5;
                }
            }
        }
        bool left,right;
        Random Random = new Random();
        int score = 0;
        void hurdles()
        {
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && item.Tag == "Block")
                {
                    if (item.Top>450)
                    {
                        item.Top = 25;
                        item.Width = Random.Next(50, 200);
                        score++;
                        scoreLBL.Text = "Score: " + score;
                    }
                    if (player.Bounds.IntersectsWith(item.Bounds))
                    {
                        
                        timer1.Stop();
                        goBackForm backForm = new goBackForm();
                        backForm.Show();
                    }
                    item.Top += 5;
                }
            }
        }
        private void Top_Down_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movePlayer();
            hurdles();
        }

        private void Top_Down_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 20;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            goBackForm backForm = new goBackForm();
            backForm.Show();
        }

        private void Top_Down_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
        }
    }
}
