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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            txtFullNameSignUp = new TextBox();
            txtUsernameSignUp = new TextBox();
            btnSignUp = new Button();
            toolTip = new ToolTip(components);
            txtPasswordSignUp = new TextBox();
            txtConfirmPasswordSignUp = new TextBox();
            linkLabelSignUp = new LinkLabel();
            lblSignUpbasliq = new Label();
            SuspendLayout();
            // 
            // txtFullNameSignUp
            // 
            txtFullNameSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullNameSignUp.Location = new Point(299, 116);
            txtFullNameSignUp.Name = "txtFullNameSignUp";
            txtFullNameSignUp.PlaceholderText = "Full Name";
            txtFullNameSignUp.Size = new Size(250, 34);
            txtFullNameSignUp.TabIndex = 11;
            toolTip.SetToolTip(txtFullNameSignUp, "Please enter your full name");
            // 
            // txtUsernameSignUp
            // 
            txtUsernameSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsernameSignUp.Location = new Point(567, 116);
            txtUsernameSignUp.Name = "txtUsernameSignUp";
            txtUsernameSignUp.PlaceholderText = "Username";
            txtUsernameSignUp.Size = new Size(250, 34);
            txtUsernameSignUp.TabIndex = 13;
            toolTip.SetToolTip(txtUsernameSignUp, "Please enter your username");
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.LightSkyBlue;
            btnSignUp.Location = new Point(483, 240);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(141, 36);
            btnSignUp.TabIndex = 14;
            btnSignUp.Text = "Sign Up";
            toolTip.SetToolTip(btnSignUp, "click to save");
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click_1;
            // 
            // txtPasswordSignUp
            // 
            txtPasswordSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasswordSignUp.Location = new Point(299, 182);
            txtPasswordSignUp.Name = "txtPasswordSignUp";
            txtPasswordSignUp.PasswordChar = '*';
            txtPasswordSignUp.PlaceholderText = "Password";
            txtPasswordSignUp.Size = new Size(250, 34);
            txtPasswordSignUp.TabIndex = 21;
            toolTip.SetToolTip(txtPasswordSignUp, "Please enter your password");
            // 
            // txtConfirmPasswordSignUp
            // 
            txtConfirmPasswordSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPasswordSignUp.Location = new Point(567, 182);
            txtConfirmPasswordSignUp.Name = "txtConfirmPasswordSignUp";
            txtConfirmPasswordSignUp.PasswordChar = '*';
            txtConfirmPasswordSignUp.PlaceholderText = "Confirm password";
            txtConfirmPasswordSignUp.Size = new Size(250, 34);
            txtConfirmPasswordSignUp.TabIndex = 23;
            toolTip.SetToolTip(txtConfirmPasswordSignUp, "Please enter your password");
            // 
            // linkLabelSignUp
            // 
            linkLabelSignUp.AutoSize = true;
            linkLabelSignUp.Location = new Point(419, 294);
            linkLabelSignUp.Name = "linkLabelSignUp";
            linkLabelSignUp.Size = new Size(276, 20);
            linkLabelSignUp.TabIndex = 19;
            linkLabelSignUp.TabStop = true;
            linkLabelSignUp.Text = "Already have an account? Click to Log in";
            toolTip.SetToolTip(linkLabelSignUp, "click to log in");
            linkLabelSignUp.LinkClicked += linkLabelSignUp_LinkClicked;
            // 
            // lblSignUpbasliq
            // 
            lblSignUpbasliq.AutoSize = true;
            lblSignUpbasliq.BorderStyle = BorderStyle.Fixed3D;
            lblSignUpbasliq.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignUpbasliq.ForeColor = Color.DodgerBlue;
            lblSignUpbasliq.Location = new Point(400, 35);
            lblSignUpbasliq.Name = "lblSignUpbasliq";
            lblSignUpbasliq.Size = new Size(321, 43);
            lblSignUpbasliq.TabIndex = 15;
            lblSignUpbasliq.Text = "Driver's License Exam";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wa_road_rules_australia;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(840, 333);
            Controls.Add(txtConfirmPasswordSignUp);
            Controls.Add(txtPasswordSignUp);
            Controls.Add(txtFullNameSignUp);
            Controls.Add(txtUsernameSignUp);
            Controls.Add(btnSignUp);
            Controls.Add(linkLabelSignUp);
            Controls.Add(lblSignUpbasliq);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(858, 380);
            MinimumSize = new Size(858, 380);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFullNameSignUp;
        private ToolTip toolTip;
        private TextBox txtUsernameSignUp;
        private Button btnSignUp;
        private Label lblSignUpbasliq;
        private LinkLabel linkLabelSignUp;
        private TextBox txtPasswordSignUp;
        private TextBox txtConfirmPasswordSignUp;
    }
}