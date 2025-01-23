using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppQuiz.Forms
{
    public partial class ChangeLoginForm : Form
    {
        public ChangeLoginForm()
        {
            InitializeComponent();
        }


    
        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            string oldLogin = txtOldLogin.Text;
            string oldPassword = txtOldPassword.Text;
            string newLogin = txtNewLogin.Text;
            string newPassword = txtNewPassword.Text;

            if (string.IsNullOrWhiteSpace(oldLogin) || string.IsNullOrWhiteSpace(oldPassword) ||
                string.IsNullOrWhiteSpace(newLogin) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // for saving changes in my db
            try
            {
                using (var context = new WinFormsAppQuiz.DataAccess.QuestionDbContext())
                {
                    var admin = context.Admins.FirstOrDefault(a => a.Login == oldLogin && a.Password == oldPassword);
                    if (admin != null)
                    {
                        admin.Login = newLogin;
                        admin.Password = newPassword;
                        context.SaveChanges();

                        MessageBox.Show("Login and password updated successfully! Please log in again", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Old login or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                var errorMessage = $"An error occurred while updating the login and password. Details: {ex.Message}";

                if (ex.InnerException != null)
                {
                    errorMessage += $"\nInner Exception: {ex.InnerException.Message}";
                }

                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
