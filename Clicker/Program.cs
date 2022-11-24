using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(Properties.Settings.Default.Defbool == true)
            {
                Properties.Settings.Default.MouseX = 0;
                Properties.Settings.Default.MouseY = 0;
                Properties.Settings.Default.Save();
            }


            if (Properties.Settings.Default.Mode == "Advanced")
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                FormAdvanced S = new FormAdvanced();
                S.Show();
                S.Location = new Point(Properties.Settings.Default.MouseX, Properties.Settings.Default.MouseY);
                Application.Run();

            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MainForm S = new MainForm();
                S.Show();
                S.Location = new Point(Properties.Settings.Default.MouseX, Properties.Settings.Default.MouseY);
                Application.Run();
            }
        }
    }
}
