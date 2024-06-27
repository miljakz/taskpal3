using System;
using System.Windows.Forms;

namespace TaskPalApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenProjectForm_Click(object sender, EventArgs e)
        {
            ProjectForm projectForm = new ProjectForm();
            projectForm.ShowDialog(); // ShowDialog() for modal, Show() for modeless
        }
    }
}
