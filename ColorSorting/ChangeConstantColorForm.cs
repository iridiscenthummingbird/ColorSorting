using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorSorting
{
    public partial class ChangeConstantColorForm : Form
    {
        public ChangeConstantColorForm()
        {
            InitializeComponent();
            trackBar1.Value = 255 - Colors.ConstantColor;
            changeColor();
            changeLanguage();
        }

        private void changeLanguage()
        {
            int tmp = ChangeLanguage.Language ? 1 : 0;

            Text = ChangeLanguage.ResManager[tmp].GetString("changeConstantColorForm");
        }

        private void changeColor()
        {
            panel3.BackColor = Color.FromArgb(0, 0, 255 - trackBar1.Value);
            panel2.BackColor = Color.FromArgb(255 / 2, 255 / 2, 255 - trackBar1.Value);
            panel1.BackColor = Color.FromArgb(255, 255, 255 - trackBar1.Value);

            panel5.BackColor = Color.FromArgb(255, 0, 255 - trackBar1.Value);
            panel9.BackColor = Color.FromArgb(0, 255, 255 - trackBar1.Value);

            panel8.BackColor = Color.FromArgb(0, 255 / 2, 255 - trackBar1.Value);
            panel7.BackColor = Color.FromArgb(255 / 2, 0, 255 - trackBar1.Value);

            panel4.BackColor = Color.FromArgb(255, 255 / 2, 255 - trackBar1.Value);
            panel6.BackColor = Color.FromArgb(255 / 2, 255, 255 - trackBar1.Value);

            Colors.ConstantColor = byte.Parse((255 - trackBar1.Value).ToString());
            Properties.Settings.Default.ConstantColor = Colors.ConstantColor;
            Properties.Settings.Default.Save();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            changeColor();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
