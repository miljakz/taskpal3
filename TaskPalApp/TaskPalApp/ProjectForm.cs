using System;
using System.Windows.Forms;

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
                txtDescription.Text = project.Description;
                dtpDueDate.Value = project.DueDate;
                chkIsUrgent.Checked = project.IsUrgent;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Project = new ProjectItem
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                DueDate = dtpDueDate.Value,
                IsUrgent = chkIsUrgent.Checked
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
