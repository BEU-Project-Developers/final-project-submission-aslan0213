﻿using Microsoft.EntityFrameworkCore;
using WinFormsAppQuiz.DataAccess;
using WinFormsAppQuiz.Entitys;

namespace WinFormsAppQuiz.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblLogin;
        private TextBox txtLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private ToolTip toolTip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            toolTip = new ToolTip(components);
            textBoxAreYouRobot = new TextBox();
            linkLabelLogIn = new LinkLabel();
            label1 = new Label();
            pictureBoxLogin = new PictureBox();
            labelAreYouRobot = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(438, 99);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(49, 20);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(512, 92);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(267, 27);
            txtLogin.TabIndex = 1;
            toolTip.SetToolTip(txtLogin, "Please enter your username");
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(438, 151);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(512, 144);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(267, 27);
            txtPassword.TabIndex = 3;
            toolTip.SetToolTip(txtPassword, "Please enter your password");
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSkyBlue;
            btnLogin.Location = new Point(556, 229);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 36);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            toolTip.SetToolTip(btnLogin, "click to enter");
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // textBoxAreYouRobot
            // 
            textBoxAreYouRobot.Location = new Point(628, 186);
            textBoxAreYouRobot.Name = "textBoxAreYouRobot";
            textBoxAreYouRobot.Size = new Size(151, 27);
            textBoxAreYouRobot.TabIndex = 8;
            toolTip.SetToolTip(textBoxAreYouRobot, "please enter your answer");
            // 
            // linkLabelLogIn
            // 
            linkLabelLogIn.AutoSize = true;
            linkLabelLogIn.Location = new Point(503, 279);
            linkLabelLogIn.Name = "linkLabelLogIn";
            linkLabelLogIn.Size = new Size(260, 20);
            linkLabelLogIn.TabIndex = 9;
            linkLabelLogIn.TabStop = true;
            linkLabelLogIn.Text = "Don't have an account? Go to Sign Up";
            toolTip.SetToolTip(linkLabelLogIn, "click to sign up");
            linkLabelLogIn.LinkClicked += linkLabelLogIn_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(481, 21);
            label1.Name = "label1";
            label1.Size = new Size(319, 41);
            label1.TabIndex = 5;
            label1.Text = "Driver's License Exam";
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = Properties.Resources.istockphoto_1414711883_612x612;
            pictureBoxLogin.Location = new Point(7, 2);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(425, 333);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogin.TabIndex = 6;
            pictureBoxLogin.TabStop = false;
            // 
            // labelAreYouRobot
            // 
            labelAreYouRobot.AutoSize = true;
            labelAreYouRobot.Location = new Point(438, 189);
            labelAreYouRobot.Name = "labelAreYouRobot";
            labelAreYouRobot.Size = new Size(184, 20);
            labelAreYouRobot.TabIndex = 7;
            labelAreYouRobot.Text = "Are you robot: 1237-ten=?";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(840, 333);
            Controls.Add(linkLabelLogIn);
            Controls.Add(textBoxAreYouRobot);
            Controls.Add(labelAreYouRobot);
            Controls.Add(pictureBoxLogin);
            Controls.Add(label1);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(858, 380);
            MinimumSize = new Size(858, 380);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
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






















        //private void BtnLogin_Click(object sender, EventArgs e)
        //{
        //    string login = txtLogin.Text;
        //    string password = txtPassword.Text;
        //    string areyourobot = textBoxAreYouRobot.Text;

        //    // проверяет наличие пустых строк 
        //    if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
        //    {
        //        MessageBox.Show("Login and Password cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    if (string.IsNullOrWhiteSpace(areyourobot))
        //    {
        //        MessageBox.Show("Human verification field cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    // проверяет имя и пароль и робот ли ты
        //    bool isAuthenticated = WinFormsAppQuiz.Services.LoginService.Authenticate(login, password);

        //    if (!isAuthenticated)
        //    {
        //        MessageBox.Show("Invalid login credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    if (areyourobot != "1227")
        //    {
        //        MessageBox.Show("Please answer the question correctly to prove you are not a robot.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    MessageBox.Show($"Welcome!\nLogin successful.",
        //                  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    MainPage mainPage = new MainPage();
        //               mainPage.Show();

        //    this.Close();

        //}

        private Label label1;
        private PictureBox pictureBoxLogin;
        private Label labelAreYouRobot;
        private TextBox textBoxAreYouRobot;
        private LinkLabel linkLabelLogIn;
    }
}