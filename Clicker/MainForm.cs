using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hooks;

namespace Clicker
{
    public partial class MainForm : Form
    {
        #region dll

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        // border form
        private const int WS_BORDER = 0x00800000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_BORDER;
                cp.ExStyle &= (~0x00000200); // Удаляем стиль WS_EX_CLIENTEDGE
                return cp;
            }
        }

        #endregion

        #region ctor

        public MainForm()
        {
            InitializeComponent();
            TopMost = true;
            labelClick.Text = $"Click {Properties.Settings.Default.TimeClick.ToString()}ms ";
            var timeClick = Properties.Settings.Default.TimeClick; 
            
            //keyboard hook
            KBDHook.KeyDown += new KBDHook.HookKeyPress(KBDHook_KeyDown);
            KBDHook.LocalHook = false;
            KBDHook.InstallHook();
           
            //button
            buttonDetector.Click += (s, e) =>
            {
                if (buttonDetector.Text == "Off")
                {
                    buttonDetector.Enabled = false;
                    ButtonOn();
                }
                else   
                    ButtonOff();
            };
            buttonDetector.MouseEnter += (s, e) => 
            { 
                timer.Stop(); 
            };
            buttonDetector.MouseLeave += (s, e) => 
            {
                buttonDetector.Enabled = true;
                if(buttonDetector.Text == "Off")
                    buttonDetector.BackColor = Color.Transparent; 
            };

            //label
            labelClick.MouseEnter += (s, e) => 
            { 
                labelClick.Enabled = false; 
            };   
            labelClick.MouseLeave += async (s, e) =>
            {
                await Task.Delay(3000);
                labelClick.Enabled = true;
            };

            //notifyIcon - contextMenuStrip
            contextMenuStrip.Opening += (s,e) => 
            {
                ButtonOff();
            };
            closingToolStripMenuItem.Click += (s, e) => 
            { 
                Application.Exit(); 
            };
            advancedToolStripMenuItem.Click += (s, e) =>
            {
                Properties.Settings.Default.Mode = "Advanced";
                Properties.Settings.Default.Save();

                Hide();
                var formAdvanced = new FormAdvanced();
                formAdvanced.Show(this);
                formAdvanced.Location = new Point(Properties.Settings.Default.MouseX, Properties.Settings.Default.MouseY);
               
            };
            helpToolStripMenuItem.Click += (s, e) =>
            { 
                var formHelp = new FormHelp();
                formHelp.Show();
            };
            resetToolStripMenuItem.Click += (s, e) =>
            {
                Properties.Settings.Default.Defbool = true;
                Properties.Settings.Default.TimeClick = 150;
                Properties.Settings.Default.Save();
                MessageBox.Show("Restart application!");
                Close();
            };

            //timer
            timer.Tick += (s, e) =>
            {    
                mouse_event(0x0002, 1200, 1200, 0, 0);
                Thread.Sleep(timeClick);
                mouse_event(0x0004, 1200, 1200, 0, 0);
            };
        }

        #endregion

        void KBDHook_KeyDown(LLKHEventArgs e) // keyboard hook
        {
            if(e.Keys == Properties.Settings.Default.KeyStop)
                ButtonOff();
            else if(e.Keys == Properties.Settings.Default.KeyStart)
                ButtonOn();
        }

        //form
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }     

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            if (buttonDetector.Text == "On")
                timer.Start();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Stop();
        }

        public void ButtonOn()
        {
            buttonDetector.BackColor = Color.DarkRed;
            buttonDetector.Text = "On";
            timer.Start();
        }

        public void ButtonOff() 
        {   
            buttonDetector.BackColor = Color.Empty;
            buttonDetector.Text = "Off";
            timer.Stop();
        }
    }
}
