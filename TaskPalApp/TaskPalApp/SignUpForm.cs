using System;
using System.Windows.Forms;

namespace TaskPalApp
{
    public partial class SignUpForm : Form
    {
        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Perform any additional validation if needed

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
