using System;
using System.Collections.Generic;
using System.Data.SQLite;
using TaskPalApp.Models;

namespace TaskPalApp.Repositories
{
    public class UserRepository
    {
        private string connectionString;

        public UserRepository(string dbPath)
        {
            connectionString = $"Data Source={dbPath};Version=3;";
        }

        public void AddUser(User user)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO users (Username, Password, Email) VALUES (@Username, @Password, @Email)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.ExecuteNonQuery();
                }
            }
        }

        public User GetUser(string username, string password)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM users WHERE Username = @Username AND Password = @Password";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = reader.GetInt32(0),
                                Username = reader.GetString(1),
                                Password = reader.GetString(2),
                                Email = reader.GetString(3),
                                CreatedAt = DateTime.Parse(reader.GetString(4))
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
