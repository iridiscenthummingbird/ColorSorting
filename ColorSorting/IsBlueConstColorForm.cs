using System;
using System.Windows.Forms;

namespace ColorSorting
{
    public partial class Question : Form
    {
        public Question()
        {
            InitializeComponent();
            changeLanguage();
        }

        private void changeLanguage()
        {
            int tmp = ChangeLanguage.Language ? 1 : 0;

            Text = ChangeLanguage.ResManager[tmp].GetString("question");
            yesButton.Text = ChangeLanguage.ResManager[tmp].GetString("yes");
            noButton.Text = ChangeLanguage.ResManager[tmp].GetString("no");
            label1.Text = ChangeLanguage.ResManager[tmp].GetString("questionText");
        }
        

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }
    }
}
