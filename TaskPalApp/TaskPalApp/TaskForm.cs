using System;
using System.Windows.Forms;
using TaskPalApp.Models;

namespace TaskPalApp
{
    public partial class TaskForm : Form
    {
        public TaskItem Task { get; private set; }

        public TaskForm(TaskItem task = null)
        {
            InitializeComponent();

            // Set the maximum value for priority to 2 (High)
            numPriority.Maximum = 2;

            if (task != null)
            {
                txtTitle.Text = task.Title;
                txtDescription.Text = task.Description;
                chkIsCompleted.Checked = task.IsCompleted;
                dtpDueDate.Value = task.DueDate;
                numPriority.Value = (int)task.Priority;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Task = new TaskItem
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                DueDate = dtpDueDate.Value,
                IsCompleted = chkIsCompleted.Checked,
                Priority = (Priority)(int)numPriority.Value // Cast numPriority.Value to Priority
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
