using System;
using System.Windows.Forms;

namespace TaskPalApp
{
    public partial class TaskForm : Form
    {
        public TaskItem Task { get; private set; }

        public TaskForm(TaskItem task = null)
        {
            InitializeComponent();

            if (task != null)
            {
                txtTitle.Text = task.Title;
                chkIsCompleted.Checked = task.IsCompleted;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Task = new TaskItem
            {
                Title = txtTitle.Text,
                IsCompleted = chkIsCompleted.Checked,
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
    }
}
