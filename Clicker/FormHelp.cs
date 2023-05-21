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
            {
                pictureBox.Visible = false;
                labelTitle.Text = $"Клавиша старт: {Properties.Settings.Default.KeyStart}\n";
                labelTitle.Text += $"Клавиша стоп: {Properties.Settings.Default.KeyStop}\n ";
                labelTitle.Text += $"Cкорость: {Properties.Settings.Default.TimeClick}мс";
            }
            else if ("Advanced" == labelStateName.Text)
            {
                labelTitle.Text = "Это размер стандартной формы";
            }

            buttonRUS.Click += (s, e) =>
            {
                if ("Default" == labelStateName.Text)
                {
                    labelTitle.Text = $"Клавиша старт: {Properties.Settings.Default.KeyStart}\n";
                    labelTitle.Text += $"Клавиша стоп: {Properties.Settings.Default.KeyStop}\n ";
                    labelTitle.Text += $"Cкорость клика: {Properties.Settings.Default.TimeClick}мс";
                }
                else if ("Advanced" == labelStateName.Text)
                {
                    labelTitle.Text = "Это размер стандартной формы";
                }
            };

            buttonENG.Click += (s, e) =>
            {
                if ("Default" == labelStateName.Text)
                {
                    pictureBox.Visible = false;
                    labelTitle.Text = $"Start key: {Properties.Settings.Default.KeyStart}\n";
                    labelTitle.Text += $"Stop key: {Properties.Settings.Default.KeyStop}\n ";
                    labelTitle.Text += $"Speed click: {Properties.Settings.Default.TimeClick}ms";
                }
                else if ("Advanced" == labelStateName.Text)
                {
                    labelTitle.Text = "This is the standard size";
                }
            };

        }

       
    }
}
