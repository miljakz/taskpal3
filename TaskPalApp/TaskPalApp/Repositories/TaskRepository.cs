using System;
using System.Collections.Generic;
using System.Data.SQLite;
using TaskPalApp.Models;

namespace TaskPalApp.Data
{
    public class TaskRepository
    {
        private string connectionString = "Data Source=taskpal.db;Version=3;";

        public List<TaskItem> GetAllTasks()
        {
            List<TaskItem> tasks = new List<TaskItem>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Tasks", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tasks.Add(new TaskItem
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Title = reader["Title"].ToString(),
                            Description = reader["Description"].ToString(),
                            IsCompleted = Convert.ToBoolean(reader["IsCompleted"]),
                            DueDate = Convert.ToDateTime(reader["DueDate"]),
                            Priority = (Priority)Convert.ToInt32(reader["Priority"]),
                            ProjectId = Convert.ToInt32(reader["ProjectId"])
                        });
                    }
                }
            }
            return tasks;
        }

        public void AddTask(TaskItem task)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("INSERT INTO Tasks (Title, Description, IsCompleted, DueDate, Priority, ProjectId) VALUES (@Title, @Description, @IsCompleted, @DueDate, @Priority, @ProjectId)", connection);
                command.Parameters.AddWithValue("@Title", task.Title);
                command.Parameters.AddWithValue("@Description", task.Description);
                command.Parameters.AddWithValue("@IsCompleted", task.IsCompleted);
                command.Parameters.AddWithValue("@DueDate", task.DueDate);
                command.Parameters.AddWithValue("@Priority", task.Priority);
                command.Parameters.AddWithValue("@ProjectId", task.ProjectId);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateTask(TaskItem task)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("UPDATE Tasks SET Title = @Title, Description = @Description, IsCompleted = @IsCompleted, DueDate = @DueDate, Priority = @Priority, ProjectId = @ProjectId WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Title", task.Title);
                command.Parameters.AddWithValue("@Description", task.Description);
                command.Parameters.AddWithValue("@IsCompleted", task.IsCompleted);
                command.Parameters.AddWithValue("@DueDate", task.DueDate);
                command.Parameters.AddWithValue("@Priority", task.Priority);
                command.Parameters.AddWithValue("@ProjectId", task.ProjectId);
                command.Parameters.AddWithValue("@Id", task.Id);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteTask(int taskId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("DELETE FROM Tasks WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", taskId);
                command.ExecuteNonQuery();
            }
        }
    }
}
