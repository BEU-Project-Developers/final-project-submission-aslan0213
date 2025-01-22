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

        }
    }
}
