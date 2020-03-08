using System;
using System.Windows.Forms;

namespace ColorSorting
{
    public partial class FileExceptionForm : Form
    {
        public FileExceptionForm(Exception ex, int In = 0)
        {
            InitializeComponent();

            int tmp = ChangeLanguage.Language ? 1 : 0;
            this.Text = ChangeLanguage.ResManager[tmp].GetString("ExceptErrTitle");

            switch (In)
            {
                case 0:
                    label1.Text = ChangeLanguage.ResManager[tmp].GetString("ExceptFileRead");
                    break;

                case 1:
                    label1.Text = ChangeLanguage.ResManager[tmp].GetString("ExceptFileSave");
                    break;

                case 2:
                    label1.Text = ChangeLanguage.ResManager[tmp].GetString("ExceptFileInUse");
                    break;

                case 3:
                    label1.Text = ChangeLanguage.ResManager[tmp].GetString("ExceptFileInUseWrite");
                    break;
            }
            

            SimpleLog.SWatch_stop(ex.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
