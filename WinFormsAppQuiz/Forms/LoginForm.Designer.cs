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
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            toolTip = new ToolTip(components);
            label1 = new Label();
            pictureBoxLogin = new PictureBox();
            labelAreYouRobot = new Label();
            textBoxAreYouRobot = new TextBox();
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
            toolTip.SetToolTip(txtLogin, "Lütfen kullanıcı adınızı girin");
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
            toolTip.SetToolTip(txtPassword, "Lütfen şifrenizi girin");
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSkyBlue;
            btnLogin.Location = new Point(573, 262);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 36);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            toolTip.SetToolTip(btnLogin, "Giriş yap");
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(428, 21);
            label1.Name = "label1";
            label1.Size = new Size(403, 41);
            label1.TabIndex = 5;
            label1.Text = "Online Examination System";
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = Properties.Resources._011;
            pictureBoxLogin.Location = new Point(1, 0);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(421, 333);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogin.TabIndex = 6;
            pictureBoxLogin.TabStop = false;
            // 
            // labelAreYouRobot
            // 
            labelAreYouRobot.AutoSize = true;
            labelAreYouRobot.Location = new Point(438, 189);
            labelAreYouRobot.Name = "labelAreYouRobot";
            labelAreYouRobot.Size = new Size(210, 20);
            labelAreYouRobot.TabIndex = 7;
            labelAreYouRobot.Text = "Answer the question: 10-ten=?";
            // 
            // textBoxAreYouRobot
            // 
            textBoxAreYouRobot.Location = new Point(512, 212);
            textBoxAreYouRobot.Name = "textBoxAreYouRobot";
            textBoxAreYouRobot.PasswordChar = '*';
            textBoxAreYouRobot.Size = new Size(267, 27);
            textBoxAreYouRobot.TabIndex = 8;
            toolTip.SetToolTip(textBoxAreYouRobot, "Lütfen şifrenizi girin");
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(840, 333);
            Controls.Add(textBoxAreYouRobot);
            Controls.Add(labelAreYouRobot);
            Controls.Add(pictureBoxLogin);
            Controls.Add(label1);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        // this is login button

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Login and Password cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool isAuthenticated = WinFormsAppQuiz.Services.LoginService.Authenticate(login, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 mainForm = new Form1();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Label label1;
        private PictureBox pictureBoxLogin;
        private Label labelAreYouRobot;
        private TextBox textBoxAreYouRobot;
    }
}