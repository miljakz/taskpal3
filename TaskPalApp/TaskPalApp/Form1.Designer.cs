namespace TaskPalApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnMarkComplete;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cmbPriority; // Declare the priority ComboBox

        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnMarkComplete = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(253, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 200);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.Location = new System.Drawing.Point(18, 192);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(200, 95);
            this.lstTasks.TabIndex = 2;
            // 
            // lstProjects
            // 
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.Location = new System.Drawing.Point(18, 300);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(200, 95);
            this.lstProjects.TabIndex = 3;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(253, 222);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 4;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(253, 251);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(75, 23);
            this.btnEditTask.TabIndex = 5;
            this.btnEditTask.Text = "Edit Task";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(253, 280);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTask.TabIndex = 6;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnMarkComplete
            // 
            this.btnMarkComplete.Location = new System.Drawing.Point(553, 251);
            this.btnMarkComplete.Name = "btnMarkComplete";
            this.btnMarkComplete.Size = new System.Drawing.Size(100, 23);
            this.btnMarkComplete.TabIndex = 7;
            this.btnMarkComplete.Text = "Mark Complete";
            this.btnMarkComplete.UseVisualStyleBackColor = true;
            this.btnMarkComplete.Click += new System.EventHandler(this.btnMarkComplete_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(225, 372);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(75, 23);
            this.btnAddProject.TabIndex = 8;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(578, 372);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cmbPriority.Location = new System.Drawing.Point(532, 224);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 21);
            this.cmbPriority.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.btnMarkComplete);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lstProjects);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "TaskPalApp";
            this.ResumeLayout(false);

        }
    }
}
