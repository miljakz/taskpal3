using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskPalApp
{
    public partial class LoginForm : Form
    {
        private List<User> users = new List<User>();

        public LoginForm()
        {
            InitializeComponent();
            InitializeDummyUsers(); // For testing purposes
        }

        private void InitializeDummyUsers()
        {
            // Add some dummy users
            users.Add(new User { Username = "user1", Password = "password1" });
            users.Add(new User { Username = "user2", Password = "password2" });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check if the user exists
            User user = users.Find(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                OpenMainForm();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var signUpForm = new SignUpForm();

            if (signUpForm.ShowDialog() == DialogResult.OK)
            {
                // Add the new user to the list
                users.Add(new User { Username = signUpForm.Username, Password = signUpForm.Password });

                // Automatically log in the newly signed up user
                OpenMainForm();
            }
        }

        private void OpenMainForm()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
