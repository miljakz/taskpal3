using System.Windows.Forms;
using System;

namespace TaskPalApp
{
    public partial class ProjectForm : Form
    {
        public ProjectItem Project { get; private set; }

        public ProjectForm(ProjectItem project = null)
        {
            InitializeComponent();

            if (project != null)
            {
                txtTitle.Text = project.Title;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Project = new ProjectItem
            {
                Title = txtTitle.Text
            };

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
