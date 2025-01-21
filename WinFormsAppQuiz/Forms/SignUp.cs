using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppQuiz.DataAccess;
using WinFormsAppQuiz.Entitys;
using WinFormsAppQuiz.Forms;

namespace WinFormsAppQuiz
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();


            this.Close();

        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            // yazdigimizi qebul edir
            string fullName = txtFullNameSignUp.Text.Trim();
            string username = txtUsernameSignUp.Text.Trim();
            string password = txtPasswordSignUp.Text;
            string confirmPassword = txtConfirmPasswordSignUp.Text;


            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save to the database
            using (var context = new QuestionDbContext())
            {
                // Check if username already exists
                if (context.Admins.Any(a => a.Login == username))
                {
                    MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newAdmin = new Admin
                {
                    Full_Name = fullName,
                    Login = username,
                    Password = password
                };
                try
                {
                    context.Admins.Add(newAdmin);
                    context.SaveChanges();

                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                this.Close();
                var loginForm = new LoginForm();
                loginForm.Show();
            }
        }

     
    }
}
