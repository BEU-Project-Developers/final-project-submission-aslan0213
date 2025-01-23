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

namespace WinFormsAppQuiz.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void linkLabelLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Close();
        }

        // i use it for pictureBoxYourLastResult_Click in MainPage.cs
        public static class Session
        {
            public static string CurrentLogin { get; set; }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            string areyourobot = textBoxAreYouRobot.Text;
            Session.CurrentLogin = login;
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Login and Password cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(areyourobot))
            {
                MessageBox.Show("Human verification field cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Authenticate user
            bool isAuthenticated = WinFormsAppQuiz.Services.LoginService.Authenticate(login, password);

            if (!isAuthenticated)
            {
                MessageBox.Show("Invalid login credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (areyourobot != "1227")
            {
                MessageBox.Show("Please answer the question correctly to prove you are not a robot.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // bu hal hazirda programa giren userin melumatlarini saxlayir
                using (var context = new QuestionDbContext())
                {
                    var admin = context.Admins.FirstOrDefault(a => a.Login == login && a.Password == password);

                    if (admin != null)
                    {

                        var userSession = new UserSession
                        {
                            Login = admin.Login,
                            Full_Name = admin.Full_Name,
                            worth = 0, // Set this value as required
                            PassOrFail = "You did not compleate exam yet", // Example value
                            LoginTime = DateTime.Now
                        };

                        context.UserSession.Add(userSession);
                        context.SaveChanges();

                        MessageBox.Show($"Welcome, {admin.Full_Name}!\nLogin successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MainPage mainPage = new MainPage();
                        mainPage.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Admin information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\nInner Exception: {ex.InnerException?.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









    }
}
