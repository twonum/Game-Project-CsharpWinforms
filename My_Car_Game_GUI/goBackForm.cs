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
    public partial class goBackForm : Form
    {
        public goBackForm()
        {
            InitializeComponent();
        }
        public static Form currentForm;
        private void button1_MouseHover(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backToMenu();
        }
        void backToMenu()
        {
            this.Close();
            ActiveForm.Hide();
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
        }
    }
}
