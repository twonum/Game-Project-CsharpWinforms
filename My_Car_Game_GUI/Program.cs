using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Car_Game_GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Menu());
            water_Melon_Start = true;
        }
        public static bool water_Melon_Start = false;
        public static bool top_Down_Start = false;
        public static bool arow_Game_Start = false;
        public static bool car_Game_Start = false;
    }
      
}
