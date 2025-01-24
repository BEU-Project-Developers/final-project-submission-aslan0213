using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsAppQuiz.Forms.LoginForm;
using WinFormsAppQuiz.DataAccess;
using WinFormsAppQuiz.Entitys;

namespace WinFormsAppQuiz.Forms
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string full_name = txtFullName.Text;
            string login = txtLogin.Text;
            string password = txtPassword.Text;         
            
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrEmpty(full_name))
            {
                MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
         

            // Authenticate admin
            bool isAdminAuthenticated = WinFormsAppQuiz.Services.LoginService.AdminAuthenticate(full_name,login, password);

            if (!isAdminAuthenticated)
            {
                MessageBox.Show("Invalid login credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
                MessageBox.Show($"Welcome, {full_name}!\nLogin successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminDataViiew adminData = new AdminDataViiew();
                adminData.Show();
                this.Close();
            }
            
        
    }
}
