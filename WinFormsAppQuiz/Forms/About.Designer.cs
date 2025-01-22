namespace WinFormsAppQuiz.Forms
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            txtAbout = new TextBox();
            lblAboutPage = new Label();
            pictureBoxBackToMainPage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackToMainPage).BeginInit();
            SuspendLayout();
            // 
            // txtAbout
            // 
            txtAbout.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAbout.Location = new Point(31, 86);
            txtAbout.Multiline = true;
            txtAbout.Name = "txtAbout";
            txtAbout.ReadOnly = true;
            txtAbout.ScrollBars = ScrollBars.Vertical;
            txtAbout.Size = new Size(742, 352);
            txtAbout.TabIndex = 0;
            txtAbout.Text = resources.GetString("txtAbout.Text");
            // 
            // lblAboutPage
            // 
            lblAboutPage.AutoSize = true;
            lblAboutPage.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAboutPage.ForeColor = Color.DodgerBlue;
            lblAboutPage.Location = new Point(31, 24);
            lblAboutPage.Name = "lblAboutPage";
            lblAboutPage.Size = new Size(734, 39);
            lblAboutPage.TabIndex = 1;
            lblAboutPage.Text = "Welcome to the Driver’s License Exam Practice App!";
            // 
            // pictureBoxBackToMainPage
            // 
            pictureBoxBackToMainPage.Image = Properties.Resources.images__1_1;
            pictureBoxBackToMainPage.Location = new Point(0, 0);
            pictureBoxBackToMainPage.Name = "pictureBoxBackToMainPage";
            pictureBoxBackToMainPage.Size = new Size(39, 30);
            pictureBoxBackToMainPage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBackToMainPage.TabIndex = 2;
            pictureBoxBackToMainPage.TabStop = false;
            pictureBoxBackToMainPage.Click += pictureBoxBackToMainPage_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxBackToMainPage);
            Controls.Add(lblAboutPage);
            Controls.Add(txtAbout);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackToMainPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAbout;
        private Label lblAboutPage;
        private PictureBox pictureBoxBackToMainPage;
    }
}