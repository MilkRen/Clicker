using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hooks;

namespace Clicker
{
    public partial class MainForm : Form
    {
        FormAdvanced formAdvanced = new FormAdvanced();

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

        public MainForm()
        {
            TopMost = true;
            InitializeComponent();

            labelClick.Text = $"Click {Properties.Settings.Default.TimeClick.ToString()}ms ";

            int tc = Properties.Settings.Default.TimeClick; // timeClick
            
            //keyboard hook
            KBDHook.KeyDown += new KBDHook.HookKeyPress(KBDHook_KeyDown);
            KBDHook.LocalHook = false;
            KBDHook.InstallHook();
           
            //button
            buttonDetector.Click += (s, e) =>
            {
                if (buttonDetector.Text == "Off")
                {
                    timer.Start();
                    buttonDetector.BackColor = Color.DarkRed;
                    buttonDetector.Text = "On";
                }
                else
                {
                    timer.Stop();
                    buttonDetector.BackColor = Color.Empty;
                    buttonDetector.Text = "Off";
                }
            };
           
            buttonDetector.MouseEnter += (s, e) => { timer.Stop(); };

            //label
            labelClick.MouseEnter += (s, e) => { labelClick.Enabled = false; };
           
            labelClick.MouseLeave += async (s, e) =>
            {
                await Task.Delay(3000);
                labelClick.Enabled = true;
            };
           
            //notufiio - contextMenuStrip
            closingToolStripMenuItem.Click += (s, e) => { Application.Exit(); };
     
            advancedToolStripMenuItem.Click += (s, e) =>
            {
                Properties.Settings.Default.Mode = "Advanced";
                Properties.Settings.Default.Save();

                timer.Stop();
                Hide();
                formAdvanced.Show(this);
                formAdvanced.Location = new Point(Properties.Settings.Default.MouseX, Properties.Settings.Default.MouseY);
               
            };

            helpToolStripMenuItem.Click += (s, e) =>
            {
                FormHelp formhelp = new FormHelp();
                timer.Stop();
                buttonDetector.BackColor = Color.Empty;
                buttonDetector.Text = "Off";
                formhelp.Show();
            };

            resetToolStripMenuItem.Click += (s, e) =>
            {
                timer.Stop();
                Properties.Settings.Default.Defbool = true;
                Properties.Settings.Default.TimeClick = 150;
                Properties.Settings.Default.Save();
                MessageBox.Show("restart application!");
                Close();
            };

            contextMenuStrip.MouseEnter += (s, e) =>
            {
                timer.Stop();
                if (buttonDetector.Text == "On")
                {
                    buttonDetector.BackColor = Color.Empty;
                    buttonDetector.Text = "Off";
                }
            };

            //timer
            timer.Tick += async (s, e) =>
            {    
                await Task.Run(() => {
                    mouse_event(0x0002, 1200, 1200, 0, 0);
                    Thread.Sleep(tc);
                    mouse_event(0x0004, 1200, 1200, 0, 0);
                });
            };

        }

        void KBDHook_KeyDown(LLKHEventArgs e) // keyboard hook
        {
            if(e.Keys.ToString() == Properties.Settings.Default.KeyStop.ToString())
            {
                timer.Stop();
                buttonDetector.BackColor = Color.Empty;
                buttonDetector.Text = "Off";
            }
            else if(e.Keys.ToString() == Properties.Settings.Default.KeyStart.ToString())
            {
                timer.Start();
                buttonDetector.BackColor = Color.DarkRed;
                buttonDetector.Text = "On";
            }    
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
    }
}
