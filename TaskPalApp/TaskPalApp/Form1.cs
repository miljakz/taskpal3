using System;
using System.Windows.Forms;
using TaskPalApp.Data;
using TaskPalApp.Models;

namespace TaskPalApp
{
    public partial class Form1 : Form
    {
        private TaskRepository taskRepository;
        private ProjectRepository projectRepository;

        public Form1()
        {
            InitializeComponent();
            taskRepository = new TaskRepository(); // Initialize repositories
            projectRepository = new ProjectRepository();
            InitializeListView(); // Initialize ListView
            InitializePriorityComboBox(); // Initialize priority combo box
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var taskForm = new TaskForm();
            if (taskForm.ShowDialog() == DialogResult.OK)
            {
                taskRepository.AddTask(taskForm.Task);
                UpdateTaskListBox();
                UpdateCalendar();
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            // Implementation for editing a task
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            // Implementation for deleting a task
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            // Implementation for marking a task as complete
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            // Implementation for adding a project
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Implementation for logging out
        }

        private void UpdateTaskListBox()
        {
            // Update the task list box with the tasks
            lstTasks.Items.Clear();
            foreach (var task in taskRepository.GetAllTasks())
            {
                lstTasks.Items.Add(task.Title); // Adjust this based on what you want to display
            }
        }

        private void UpdateCalendar()
        {
            // Update the calendar with the tasks
            monthCalendar1.RemoveAllBoldedDates();
            foreach (var task in taskRepository.GetAllTasks())
            {
                monthCalendar1.AddBoldedDate(task.DueDate);
            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void InitializeListView()
        {
            // Initialize ListView properties and columns
            listView1.View = View.Details;
            listView1.Columns.Add("Title", 150);
            listView1.Columns.Add("Due Date", 100);
            listView1.Columns.Add("Priority", 100); // Add Priority column
        }

        private void InitializePriorityComboBox()
        {
            cmbPriority.Items.Add(Priority.Low.ToString());
            cmbPriority.Items.Add(Priority.Medium.ToString());
            cmbPriority.Items.Add(Priority.High.ToString());
            cmbPriority.SelectedIndex = 1; // Default to Medium
        }

        private void UpdateListViewForDate(DateTime selectedDate)
        {
            listView1.Items.Clear();

            foreach (var task in taskRepository.GetAllTasks())
            {
                if (task.DueDate.Date == selectedDate.Date)
                {
                    ListViewItem item = new ListViewItem(task.Title);
                    item.SubItems.Add(task.DueDate.ToShortDateString());
                    item.SubItems.Add(task.Priority.ToString()); // Add Priority to ListView as string
                    listView1.Items.Add(item);
                }
            }

            foreach (var project in projectRepository.GetAllProjects())
            {
                if (project.DueDate.Date == selectedDate.Date)
                {
                    ListViewItem item = new ListViewItem(project.Title);
                    item.SubItems.Add(project.DueDate.ToShortDateString());
                    listView1.Items.Add(item);
                }
            }
        }

        // Other methods for handling UI updates, validations, etc.
    }
}
