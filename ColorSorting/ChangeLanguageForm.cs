using System;
using System.Windows.Forms;

namespace ColorSorting
{
    public partial class ChangeLanguageForm : Form
    {
        public ChangeLanguageForm()
        {
            InitializeComponent();
            engRadioButton.Checked = ChangeLanguage.Language;
            ukrRadioButton.Checked = !ChangeLanguage.Language;
            changeLanguage();
        }

        private void changeLanguage()
        {
            int tmp = ChangeLanguage.Language ? 1 : 0;
            ukrRadioButton.Text = ChangeLanguage.ResManager[tmp].GetString("ukrL");
            engRadioButton.Text = ChangeLanguage.ResManager[tmp].GetString("engL");
            this.Text = ChangeLanguage.ResManager[tmp].GetString("changeLanguage");
            Properties.Settings.Default.Language = ChangeLanguage.Language;
            Properties.Settings.Default.Save();
        }

        private void engRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLanguage.Language = true;
            changeLanguage();

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ukrRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLanguage.Language = false;
            changeLanguage();
        }
    }
}
