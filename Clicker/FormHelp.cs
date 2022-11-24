using System.Windows.Forms;

namespace Clicker
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            labelStateName.Text = Properties.Settings.Default.Mode;

            if ("Default" == labelStateName.Text)
                pictureBox.Image = Properties.Resources.def1;

            if ("Advanced" == labelStateName.Text)
                pictureBox.Image = Properties.Resources.adv1;

            buttonRUS.Click += (s, e) =>
            {
                if ("Default" == labelStateName.Text)
                     pictureBox.Image = Properties.Resources.def2;
            };

            buttonENG.Click += (s, e) =>
            {
                if ("Default" == labelStateName.Text)
                    pictureBox.Image = Properties.Resources.def1;
            };


            buttonRUS.Click += (s, e) =>
            {
                if ("Advanced" == labelStateName.Text)
                    pictureBox.Image = Properties.Resources.adv2;
            };

            buttonENG.Click += (s, e) =>
            {
                if ("Advanced" == labelStateName.Text)
                    pictureBox.Image = Properties.Resources.adv1;
            };
        }

       
    }
}
