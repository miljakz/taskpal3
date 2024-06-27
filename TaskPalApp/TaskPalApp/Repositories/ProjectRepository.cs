using System;
using System.Collections.Generic;
using System.Data.SQLite;
using TaskPalApp.Models;

namespace TaskPalApp.Data
{
    public class ProjectRepository
    {
        private string connectionString = "Data Source=taskpal.db;Version=3;";

        public List<ProjectItem> GetAllProjects()
        {
            List<ProjectItem> projects = new List<ProjectItem>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Projects", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        projects.Add(new ProjectItem
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Title = reader["Title"].ToString(),
                            Description = reader["Description"].ToString(),
                            IsUrgent = Convert.ToBoolean(reader["IsUrgent"]),
                            DueDate = Convert.ToDateTime(reader["DueDate"])
                        });
                    }
                }
            }
            return projects;
        }

        public void AddProject(ProjectItem project)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("INSERT INTO Projects (Title, Description, IsUrgent, DueDate) VALUES (@Title, @Description, @IsUrgent, @DueDate)", connection);
                command.Parameters.AddWithValue("@Title", project.Title);
                command.Parameters.AddWithValue("@Description", project.Description);
                command.Parameters.AddWithValue("@IsUrgent", project.IsUrgent);
                command.Parameters.AddWithValue("@DueDate", project.DueDate);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateProject(ProjectItem project)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("UPDATE Projects SET Title = @Title, Description = @Description, IsUrgent = @IsUrgent, DueDate = @DueDate WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Title", project.Title);
                command.Parameters.AddWithValue("@Description", project.Description);
                command.Parameters.AddWithValue("@IsUrgent", project.IsUrgent);
                command.Parameters.AddWithValue("@DueDate", project.DueDate);
                command.Parameters.AddWithValue("@Id", project.Id);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteProject(int projectId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("DELETE FROM Projects WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", projectId);
                command.ExecuteNonQuery();
            }
        }
    }
}
