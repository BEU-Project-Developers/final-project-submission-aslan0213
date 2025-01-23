using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppQuiz.DataAccess;

namespace WinFormsAppQuiz.Forms
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void pictureBoxGoToExam_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void pictureBoxAbout_Click(object sender, EventArgs e)
        {
            
            About about = new About();
            about.Show();
            this.Close();
        }

        private void btnChangeLoginMainPage_Click(object sender, EventArgs e)
        {
            
            ChangeLoginForm changeLoginForm = new ChangeLoginForm();
            changeLoginForm.Show();
            this.Close();
        }

        private void btnFinishExamMainPage_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        private void pictureBoxYourLastResult_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new QuestionDbContext())
                {
                    
                    //hal hazirda sistemde olan userin Login
                    string currentLogin = LoginForm.Session.CurrentLogin; // Or retrieve it from a global/session variable

                    // Get the last row for the logged-in user where PassOrFail is valid
                    var lastResult = context.UserSession
                                             .Where(us => us.Login == currentLogin &&
                                                          us.PassOrFail != "You did not compleate exam yet" &&
                                                          !string.IsNullOrWhiteSpace(us.PassOrFail))
                                             .OrderByDescending(us => us.Id)
                                             .FirstOrDefault();

                    if (lastResult != null)
                    {
                        
                        MessageBox.Show(
                            $"Your last exam Result:\n\n" +
                            $"Login: {lastResult.Login}\n" +
                            $"Full Name: {lastResult.Full_Name}\n" +
                            $"Worth: {lastResult.worth?.ToString() ?? "N/A"}\n" +
                            $"Pass/Fail: {lastResult.PassOrFail}\n" +
                            $"Exam Date: {lastResult.LoginTime}",
                            "Your Last Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("You did not complete exam yet",
                                        "Information",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\nInner Exception: {ex.InnerException?.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

    }
}
