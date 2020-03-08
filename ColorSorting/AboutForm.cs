using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSorting
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            changeLanguage();
        }

        private void changeLanguage()
        {
            int tmp = ChangeLanguage.Language ? 1 : 0;
            
            versionLabel.Text = ChangeLanguage.ResManager[tmp].GetString("version") + ": 1.0";
            authorsLabel.Text = ChangeLanguage.ResManager[tmp].GetString("authors");
            groupLabel.Text = ChangeLanguage.ResManager[tmp].GetString("group");
            tretLabel.Text = ChangeLanguage.ResManager[tmp].GetString("tret");
            sydLabel.Text = ChangeLanguage.ResManager[tmp].GetString("syd");
            radLabel.Text = ChangeLanguage.ResManager[tmp].GetString("rad");
            pavLabel.Text = ChangeLanguage.ResManager[tmp].GetString("pav");
            Text = ChangeLanguage.ResManager[tmp].GetString("about");
        }

    }
}
