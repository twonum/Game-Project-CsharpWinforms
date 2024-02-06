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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCarGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.car_Game_Start = true;
            Car_Game_Maze car_Game_Maze = new Car_Game_Maze();
            car_Game_Maze.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnArrow_Game_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.arow_Game_Start = true;
            Player player = new Player();
            player.Show();
        }

        private void btnTopDown_Game_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.top_Down_Start = true;
            Top_Down top_Down = new Top_Down();
            top_Down.Show();
        }

        private void btnCastle_Game_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.water_Melon_Start = true;
            Watermelon watermelon = new Watermelon();
            watermelon.Show();
        }
    }
    
}
