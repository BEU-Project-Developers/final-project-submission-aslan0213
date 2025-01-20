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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.KeyPreview = true;  // Make sure the form captures key events
            this.KeyDown += LoginForm_KeyDown;

            txtPassword.KeyPress += TxtPassword_KeyPress; // + goturmesin deye yaratdigim method
            txtLogin.KeyPress += TxtPassword_KeyPress;  // hemen metoddan istifade ederek txtLogin ucun etdim
        }
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)  // + basili oldugunu yoxlayir
            {
                btnLogin.PerformClick();  // Trigger the button's click event
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is the '+' character
            if (e.KeyChar == '+')
            {
                e.Handled = true;  // Prevent the character from being entered into the TextBox
            }
        }

        private void linkLabelLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();

            
            this.Close(); 

        }
    }
}
