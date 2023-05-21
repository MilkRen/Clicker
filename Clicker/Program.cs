using System;
using System.Drawing;
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

                FormAdvanced FA = new FormAdvanced();
                FA.Show();
                FA.Location = new Point(Properties.Settings.Default.MouseX, Properties.Settings.Default.MouseY);
                Application.Run();

            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MainForm MF = new MainForm();
                MF.Show();
                MF.Location = new Point(Properties.Settings.Default.MouseX, Properties.Settings.Default.MouseY);
                Application.Run();
            }
        }
    }
}
