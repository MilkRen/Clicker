using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Gma.System.MouseKeyHook;
using System.Threading;

namespace Clicker
{
    public partial class FormAdvanced: Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetCursorPos(int X, int Y);
        private IKeyboardMouseEvents m_Events;

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        // mouse hook
        static int MX = 0;
        static int MY = 0;

        public FormAdvanced()
        {
            TopMost = true;
            InitializeComponent();

            int tc = Properties.Settings.Default.TimeClick; // timeClick

            textBoxPositionMouseX.Text = Properties.Settings.Default.MouseX.ToString();
            textBoxPositionMouseY.Text = Properties.Settings.Default.MouseY.ToString();
            textBoxTimeClick.Text = Properties.Settings.Default.TimeClick.ToString();

            //keyboard hook
            Hooks.KBDHook.KeyDown += new Hooks.KBDHook.HookKeyPress(KBDHook_KeyDown);
            Hooks.KBDHook.LocalHook = false;
            Hooks.KBDHook.InstallHook();

            //button
            buttonDetector.Click += (s, e) =>
            {
                if (buttonDetector.Text == "Off")
                {
                    timer.Start();
                    buttonDetector.BackColor = Color.Red;
                    buttonDetector.Text = "On";
                }
                else
                {
                    timer.Stop();
                    buttonDetector.BackColor = Color.Empty;
                    buttonDetector.Text = "Off";
                }
            };

            buttonDetector.MouseEnter += (s, e) =>
            {
                timer.Stop();
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

            //panel move
            panelMouseMove.MouseEnter += (s, e) =>
            {
                panelMouseMove.Enabled = false;
            };

            panelMouseMove.MouseLeave += async (s, e) =>
            {
                await Task.Delay(3000);
                panelMouseMove.Enabled = true;
            };

            //panel copy MainForm move
            panelMainFormCopy.MouseEnter += (s, e) =>
            {
                panelMainFormCopy.Enabled = false;
            };

            panelMainFormCopy.MouseLeave += async (s, e) =>
            {
                await Task.Delay(3000);
                panelMainFormCopy.Enabled = true;
            };

            //notufiio - contextMenuStrip
            closingToolStripMenuItem.Click += (s, e) =>
            {
                Properties.Settings.Default.MouseX = int.Parse(textBoxPositionMouseX.Text);
                Properties.Settings.Default.MouseY = int.Parse(textBoxPositionMouseY.Text);
                Properties.Settings.Default.TimeClick = int.Parse(textBoxTimeClick.Text);
                Properties.Settings.Default.Save();
                this.Close();
            };

            defaultToolStripMenuItem.Click += (s, e) =>
            {
                Properties.Settings.Default.Mode = "Default";
                Properties.Settings.Default.Save();

                MainForm mainform = new MainForm();
                timer.Stop();
                Hide();

                mainform.Show(this);
                mainform.Location = new Point(Properties.Settings.Default.MouseX, Properties.Settings.Default.MouseY);
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

        void KBDHook_KeyDown(Hooks.LLKHEventArgs e) // keyboard hook
        {
            int a = 0;
            if (e.Keys.ToString() == "T")
            {
                timer.Stop();
                buttonDetector.BackColor = Color.Empty;
                buttonDetector.Text = "Off";
            }
            else if (e.Keys.ToString() == "J")
            {
                timer.Start();
                buttonDetector.BackColor = Color.Red;
                buttonDetector.Text = "On";
            }
            if (e.Keys.ToString() == "Oemplus")
            {
                textBoxPositionMouseX.Text = MX.ToString();
                textBoxPositionMouseY.Text = MY.ToString();
            }                 
            labelKeyboardHook.Text = e.Keys.ToString();
        }


        // mouse hook
        private void Subcsride(IKeyboardMouseEvents events) 
        {
            m_Events = events;
            m_Events.MouseMove += M_Events_MouseMove;
        }

        private void Unsubcride()
        {
            if (m_Events == null) return;
            m_Events.MouseMove -= M_Events_MouseMove;
            m_Events.Dispose();
            m_Events = null;
        }

        private void M_Events_MouseMove(object sender, MouseEventArgs e)
        {
            labelMouseXY.Text = $"{e.X}:{e.Y}";
            MX = e.X;
            MY = e.Y;
        }

        private void FormAdvanced_Load(object sender, EventArgs e)
        {
            Unsubcride();
            Subcsride(Hook.GlobalEvents());
        }

        //form
        private void FormAdvanced_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void FormAdvanced_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.MouseX = int.Parse(textBoxPositionMouseX.Text);
            Properties.Settings.Default.MouseY = int.Parse(textBoxPositionMouseY.Text);
            Properties.Settings.Default.TimeClick = int.Parse(textBoxTimeClick.Text);
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void FormAdvanced_MouseEnter(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void FormAdvanced_MouseLeave(object sender, EventArgs e)
        {
            if (buttonDetector.Text == "On")
                timer.Start();
        }

     
    }
}
