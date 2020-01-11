using System;
using System.Windows.Forms;

namespace WinFileRename
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            TextBoxProgress.Text = this.SetAppPath();
        }

        private string SetAppPath()
        {
            string returnValue = Application.ExecutablePath;

            return returnValue;
        }
    }
}
