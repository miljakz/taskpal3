using System;
using System.Windows.Forms;
using TaskPalApp.Models;

namespace TaskPalApp
{
    partial class ProjectForm : Form
    {
        private TextBox txtTitle;
        private TextBox txtDescription;
        private CheckBox chkIsUrgent;
        private DateTimePicker dtpDueDate;
        private Button btnOK;
        private Button btnCancel;

        public ProjectItem Project { get; private set; } // Define a public property for Project

        public ProjectForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Create a new ProjectItem instance based on user input
            Project = new ProjectItem
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                IsUrgent = chkIsUrgent.Checked,
                DueDate = dtpDueDate.Value
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
