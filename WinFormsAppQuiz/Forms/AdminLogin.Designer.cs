namespace WinFormsAppQuiz.Forms
{
    partial class AdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            pictureBoxLogin = new PictureBox();
            lblBasliq = new Label();
            txtFullName = new TextBox();
            btnLogin = new Button();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = Properties.Resources.istockphoto_1414711883_612x612;
            pictureBoxLogin.Location = new Point(0, 0);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(425, 333);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogin.TabIndex = 16;
            pictureBoxLogin.TabStop = false;
            // 
            // lblBasliq
            // 
            lblBasliq.AutoSize = true;
            lblBasliq.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBasliq.Location = new Point(474, 19);
            lblBasliq.Name = "lblBasliq";
            lblBasliq.Size = new Size(319, 41);
            lblBasliq.TabIndex = 15;
            lblBasliq.Text = "Driver's License Exam";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(501, 86);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "  Full name";
            txtFullName.Size = new Size(267, 42);
            txtFullName.TabIndex = 11;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSkyBlue;
            btnLogin.Location = new Point(569, 285);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 36);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.Location = new Point(501, 144);
            txtLogin.Multiline = true;
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "  Username";
            txtLogin.Size = new Size(267, 42);
            txtLogin.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(501, 206);
            txtPassword.Multiline = true;
            txtPassword.PasswordChar = '*';
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "  Password";
            txtPassword.Size = new Size(267, 42);
            txtPassword.TabIndex = 18;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 333);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(pictureBoxLogin);
            Controls.Add(lblBasliq);
            Controls.Add(txtFullName);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(858, 380);
            MinimumSize = new Size(858, 380);
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxLogin;
        private Label lblBasliq;
        private TextBox txtFullName;
        private Button btnLogin;
        private TextBox txtLogin;
        private TextBox txtPassword;
    }
}