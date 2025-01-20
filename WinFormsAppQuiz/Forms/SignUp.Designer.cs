namespace WinFormsAppQuiz
{
    partial class SignUp
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
            components = new System.ComponentModel.Container();
            lblFullNameSignUp = new Label();
            txtFullNameSignUp = new TextBox();
            lblPasswordSignUp = new Label();
            txtUsernameSignUp = new TextBox();
            btnSignUp = new Button();
            toolTip = new ToolTip(components);
            txtPasswordSignUp = new TextBox();
            txtConfirmPasswordSignUp = new TextBox();
            lblSignUpbasliq = new Label();
            linkLabelSignUp = new LinkLabel();
            lblUsernameSignUp = new Label();
            lblConfirmPasswordSignUp = new Label();
            SuspendLayout();
            // 
            // lblFullNameSignUp
            // 
            lblFullNameSignUp.AutoSize = true;
            lblFullNameSignUp.ForeColor = Color.Black;
            lblFullNameSignUp.Location = new Point(248, 82);
            lblFullNameSignUp.Name = "lblFullNameSignUp";
            lblFullNameSignUp.Size = new Size(79, 20);
            lblFullNameSignUp.TabIndex = 10;
            lblFullNameSignUp.Text = "Full Name:";
            // 
            // txtFullNameSignUp
            // 
            txtFullNameSignUp.Location = new Point(352, 75);
            txtFullNameSignUp.Name = "txtFullNameSignUp";
            txtFullNameSignUp.Size = new Size(250, 27);
            txtFullNameSignUp.TabIndex = 11;
            toolTip.SetToolTip(txtFullNameSignUp, "Please enter your username");
            // 
            // lblPasswordSignUp
            // 
            lblPasswordSignUp.AutoSize = true;
            lblPasswordSignUp.Location = new Point(248, 167);
            lblPasswordSignUp.Name = "lblPasswordSignUp";
            lblPasswordSignUp.Size = new Size(73, 20);
            lblPasswordSignUp.TabIndex = 12;
            lblPasswordSignUp.Text = "Password:";
            // 
            // txtUsernameSignUp
            // 
            txtUsernameSignUp.Location = new Point(352, 117);
            txtUsernameSignUp.Name = "txtUsernameSignUp";
            txtUsernameSignUp.PasswordChar = '*';
            txtUsernameSignUp.Size = new Size(250, 27);
            txtUsernameSignUp.TabIndex = 13;
            toolTip.SetToolTip(txtUsernameSignUp, "Please enter your password");
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.LightSkyBlue;
            btnSignUp.Location = new Point(365, 239);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(141, 36);
            btnSignUp.TabIndex = 14;
            btnSignUp.Text = "Sign Up";
            toolTip.SetToolTip(btnSignUp, "Giriş yap");
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // txtPasswordSignUp
            // 
            txtPasswordSignUp.Location = new Point(352, 160);
            txtPasswordSignUp.Name = "txtPasswordSignUp";
            txtPasswordSignUp.PasswordChar = '*';
            txtPasswordSignUp.Size = new Size(250, 27);
            txtPasswordSignUp.TabIndex = 21;
            toolTip.SetToolTip(txtPasswordSignUp, "Please enter your password");
            // 
            // txtConfirmPasswordSignUp
            // 
            txtConfirmPasswordSignUp.Location = new Point(352, 203);
            txtConfirmPasswordSignUp.Name = "txtConfirmPasswordSignUp";
            txtConfirmPasswordSignUp.PasswordChar = '*';
            txtConfirmPasswordSignUp.Size = new Size(250, 27);
            txtConfirmPasswordSignUp.TabIndex = 23;
            toolTip.SetToolTip(txtConfirmPasswordSignUp, "Please enter your password");
            // 
            // lblSignUpbasliq
            // 
            lblSignUpbasliq.AutoSize = true;
            lblSignUpbasliq.BorderStyle = BorderStyle.Fixed3D;
            lblSignUpbasliq.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignUpbasliq.ForeColor = Color.DodgerBlue;
            lblSignUpbasliq.Location = new Point(267, 18);
            lblSignUpbasliq.Name = "lblSignUpbasliq";
            lblSignUpbasliq.Size = new Size(321, 43);
            lblSignUpbasliq.TabIndex = 15;
            lblSignUpbasliq.Text = "Driver's License Exam";
            // 
            // linkLabelSignUp
            // 
            linkLabelSignUp.AutoSize = true;
            linkLabelSignUp.Location = new Point(296, 293);
            linkLabelSignUp.Name = "linkLabelSignUp";
            linkLabelSignUp.Size = new Size(276, 20);
            linkLabelSignUp.TabIndex = 19;
            linkLabelSignUp.TabStop = true;
            linkLabelSignUp.Text = "Already have an account? Click to Log in";
            // 
            // lblUsernameSignUp
            // 
            lblUsernameSignUp.AutoSize = true;
            lblUsernameSignUp.Location = new Point(248, 124);
            lblUsernameSignUp.Name = "lblUsernameSignUp";
            lblUsernameSignUp.Size = new Size(78, 20);
            lblUsernameSignUp.TabIndex = 20;
            lblUsernameSignUp.Text = "Username:";
            // 
            // lblConfirmPasswordSignUp
            // 
            lblConfirmPasswordSignUp.AutoSize = true;
            lblConfirmPasswordSignUp.Location = new Point(224, 206);
            lblConfirmPasswordSignUp.Name = "lblConfirmPasswordSignUp";
            lblConfirmPasswordSignUp.Size = new Size(132, 20);
            lblConfirmPasswordSignUp.TabIndex = 22;
            lblConfirmPasswordSignUp.Text = "Confirm password:";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wa_road_rules_australia;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(840, 333);
            Controls.Add(txtConfirmPasswordSignUp);
            Controls.Add(lblConfirmPasswordSignUp);
            Controls.Add(txtPasswordSignUp);
            Controls.Add(lblUsernameSignUp);
            Controls.Add(lblFullNameSignUp);
            Controls.Add(txtFullNameSignUp);
            Controls.Add(lblPasswordSignUp);
            Controls.Add(txtUsernameSignUp);
            Controls.Add(btnSignUp);
            Controls.Add(linkLabelSignUp);
            Controls.Add(lblSignUpbasliq);
            MaximumSize = new Size(858, 380);
            MinimumSize = new Size(858, 380);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullNameSignUp;
        private TextBox txtFullNameSignUp;
        private ToolTip toolTip;
        private Label lblPasswordSignUp;
        private TextBox txtUsernameSignUp;
        private Button btnSignUp;
        private Label lblSignUpbasliq;
        private LinkLabel linkLabelSignUp;
        private Label lblUsernameSignUp;
        private TextBox txtPasswordSignUp;
        private Label lblConfirmPasswordSignUp;
        private TextBox txtConfirmPasswordSignUp;
    }
}