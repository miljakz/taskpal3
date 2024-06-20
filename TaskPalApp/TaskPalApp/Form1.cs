using System;
using System.Collections.Generic;
using System.Drawing; // Required for Image class
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskPalApp
{
    public partial class Form1 : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        private List<ProjectItem> projects = new List<ProjectItem>();

        private PictureBox pictureBox1; // Declare PictureBox

        public Form1()
        {
            InitializeComponent();
            InitializeDummyData();
            InitializeBackgroundImage(); // Initialize background image

            // Initialize the calendar and other controls
            InitializeCalendar();
            InitializeListView();
            UpdateCalendar(); // Initial update
        }

        private void InitializeDummyData()
        {
            // Dummy data initialization for tasks and projects
            tasks.Add(new TaskItem { Id = 1, Title = "Task 1", IsCompleted = false, DueDate = DateTime.Today.AddDays(1) });
            tasks.Add(new TaskItem { Id = 2, Title = "Task 2", IsCompleted = true, DueDate = DateTime.Today.AddDays(3) });

            projects.Add(new ProjectItem { Id = 1, Title = "Project 1", DueDate = DateTime.Today.AddDays(5) });
            projects.Add(new ProjectItem { Id = 2, Title = "Project 2", DueDate = DateTime.Today.AddDays(7) });

            UpdateTaskListBox();
            UpdateProjectListBox();
            UpdateCalendar();
        }

        private void InitializeCalendar()
        {
            // Set up the calendar
            monthCalendar1.DateSelected += OnDateSelected;
        }

        private void InitializeListView()
        {
            // Set up the ListView
            listView1.View = View.Details;
            listView1.Columns.Add("Title", 150);
            listView1.Columns.Add("Due Date", 100);
        }

        private void UpdateTaskListBox()
        {
            // Update the task list box
            lstTasks.Items.Clear();
            foreach (var task in tasks)
            {
                lstTasks.Items.Add(task);
            }
        }

        private void UpdateProjectListBox()
        {
            // Update the project list box
            lstProjects.Items.Clear();
            foreach (var project in projects)
            {
                lstProjects.Items.Add(project);
            }
        }

        private void UpdateCalendar()
        {
            // Clear existing bolded dates
            monthCalendar1.RemoveAllBoldedDates();

            // Bold the dates with tasks or projects
            foreach (var task in tasks)
            {
                monthCalendar1.AddBoldedDate(task.DueDate);
            }

            foreach (var project in projects)
            {
                monthCalendar1.AddBoldedDate(project.DueDate);
            }

            // Update the calendar display
            monthCalendar1.UpdateBoldedDates();
        }

        private void OnDateSelected(object sender, DateRangeEventArgs e)
        {
            // Handle date selection, update the ListView with tasks and projects for the selected date
            DateTime selectedDate = e.Start;
            UpdateListViewForDate(selectedDate);
        }

        private void UpdateListViewForDate(DateTime selectedDate)
        {
            // Clear existing items
            listView1.Items.Clear();

            // Add tasks for the selected date
            foreach (var task in tasks)
            {
                if (task.DueDate.Date == selectedDate.Date)
                {
                    ListViewItem item = new ListViewItem(task.Title);
                    item.SubItems.Add(task.DueDate.ToShortDateString());
                    listView1.Items.Add(item);
                }
            }

            // Add projects for the selected date
            foreach (var project in projects)
            {
                if (project.DueDate.Date == selectedDate.Date)
                {
                    ListViewItem item = new ListViewItem(project.Title);
                    item.SubItems.Add(project.DueDate.ToShortDateString());
                    listView1.Items.Add(item);
                }
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var newTaskForm = new TaskForm();
            if (newTaskForm.ShowDialog() == DialogResult.OK)
            {
                tasks.Add(newTaskForm.Task);
                UpdateTaskListBox();
                UpdateCalendar();
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                var selectedTask = (TaskItem)lstTasks.SelectedItem;
                var editTaskForm = new TaskForm(selectedTask);
                if (editTaskForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the task in the list
                    selectedTask.Title = editTaskForm.Task.Title;
                    selectedTask.IsCompleted = editTaskForm.Task.IsCompleted;
                    selectedTask.DueDate = editTaskForm.Task.DueDate;

                    UpdateTaskListBox();
                    UpdateCalendar();
                }
            }
            else
            {
                MessageBox.Show("Please select a task to edit.");
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                var selectedTask = (TaskItem)lstTasks.SelectedItem;
                tasks.Remove(selectedTask);
                UpdateTaskListBox();
                UpdateCalendar();
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                var selectedTask = (TaskItem)lstTasks.SelectedItem;
                selectedTask.IsCompleted = true;
                UpdateTaskListBox();
                UpdateCalendar();
            }
            else
            {
                MessageBox.Show("Please select a task to mark as complete.");
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            var newProjectForm = new ProjectForm();
            if (newProjectForm.ShowDialog() == DialogResult.OK)
            {
                projects.Add(newProjectForm.Project);
                UpdateProjectListBox();
                UpdateCalendar();
            }
        }

        private void InitializeBackgroundImage()
        {
            // Initialize PictureBox for background image
            pictureBox1 = new PictureBox();
            pictureBox1.Image = Image.FromFile(@"C:/Users/zmiljak/OneDrive%20-%20Adris%20Grupa%20d.d/Dokumenti/PRojekt%20Task/TaskPalApp/TaskPalApp/Images/background.jpg"); // image file path
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Set PictureBox size to match the form and dock it to fill the form
            pictureBox1.Size = this.ClientSize;
            pictureBox1.Dock = DockStyle.Fill;

            // Add PictureBox to the back of the form's controls so it's behind everything
            this.Controls.Add(pictureBox1);
            this.Controls.SetChildIndex(pictureBox1, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
