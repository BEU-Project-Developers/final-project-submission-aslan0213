namespace WinFormsAppQuiz.Forms
{
    partial class ChangeLoginForm
    {
        private void InitializeComponent()
        {
            txtOldLogin = new TextBox();
            txtOldPassword = new TextBox();
            txtNewLogin = new TextBox();
            txtNewPassword = new TextBox();
            btnSaveChanges = new Button();
            lblOldLogin = new Label();
            lblOldPassword = new Label();
            lblNewLogin = new Label();
            lblNewPassword = new Label();
            SuspendLayout();
            // 
            // txtOldLogin
            // 
            txtOldLogin.Location = new Point(131, 17);
            txtOldLogin.Name = "txtOldLogin";
            txtOldLogin.Size = new Size(178, 27);
            txtOldLogin.TabIndex = 0;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(131, 61);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(178, 27);
            txtOldPassword.TabIndex = 1;
            // 
            // txtNewLogin
            // 
            txtNewLogin.Location = new Point(131, 102);
            txtNewLogin.Name = "txtNewLogin";
            txtNewLogin.Size = new Size(178, 27);
            txtNewLogin.TabIndex = 2;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(131, 148);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(178, 27);
            txtNewPassword.TabIndex = 3;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(109, 201);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(107, 35);
            btnSaveChanges.TabIndex = 4;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += BtnSaveChanges_Click;
            // 
            // lblOldLogin
            // 
            lblOldLogin.Location = new Point(18, 17);
            lblOldLogin.Name = "lblOldLogin";
            lblOldLogin.Size = new Size(108, 26);
            lblOldLogin.TabIndex = 5;
            lblOldLogin.Text = "Old Login:";
            // 
            // lblOldPassword
            // 
            lblOldPassword.Location = new Point(18, 61);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(108, 26);
            lblOldPassword.TabIndex = 6;
            lblOldPassword.Text = "Old Password:";
            // 
            // lblNewLogin
            // 
            lblNewLogin.Location = new Point(18, 104);
            lblNewLogin.Name = "lblNewLogin";
            lblNewLogin.Size = new Size(108, 26);
            lblNewLogin.TabIndex = 7;
            lblNewLogin.Text = "New Login:";
            // 
            // lblNewPassword
            // 
            lblNewPassword.Location = new Point(18, 148);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(121, 26);
            lblNewPassword.TabIndex = 8;
            lblNewPassword.Text = "New Password:";
            // 
            // ChangeLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(332, 261);
            Controls.Add(txtOldLogin);
            Controls.Add(txtOldPassword);
            Controls.Add(txtNewLogin);
            Controls.Add(txtNewPassword);
            Controls.Add(btnSaveChanges);
            Controls.Add(lblOldLogin);
            Controls.Add(lblOldPassword);
            Controls.Add(lblNewLogin);
            Controls.Add(lblNewPassword);
            Name = "ChangeLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Login Password";
            Load += ChangeLoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
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

            using (var context = new WinFormsAppQuiz.DataAccess.QuestionDbContext())
            {
                var admin = context.Admins.FirstOrDefault(a => a.Login == oldLogin && a.Password == oldPassword);
                if (admin != null)
                {
                    admin.Login = newLogin;
                    admin.Password = newPassword;
                    context.SaveChanges();

                    MessageBox.Show("Login and password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Old login or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private TextBox txtOldLogin;
        private TextBox txtOldPassword;
        private TextBox txtNewLogin;
        private TextBox txtNewPassword;
        private Button btnSaveChanges;
        private Label lblOldLogin;
        private Label lblOldPassword;
        private Label lblNewLogin;
        private Label lblNewPassword;
    }
}