namespace WinFormsAppQuiz.Forms
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            lblGoToExam = new Label();
            pictureBoxGoToExam = new PictureBox();
            button1 = new Button();
            lblBasliqMainPage = new Label();
            pictureBoxAbout = new PictureBox();
            pictureBoxYourLastResult = new PictureBox();
            lblLastReasult = new Label();
            label1 = new Label();
            btnChangeLoginMainPage = new Button();
            btnFinishExamMainPage = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoToExam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYourLastResult).BeginInit();
            SuspendLayout();
            // 
            // lblGoToExam
            // 
            lblGoToExam.AutoSize = true;
            lblGoToExam.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGoToExam.Location = new Point(94, 94);
            lblGoToExam.Name = "lblGoToExam";
            lblGoToExam.Size = new Size(75, 27);
            lblGoToExam.TabIndex = 1;
            lblGoToExam.Text = "Go To ";
            // 
            // pictureBoxGoToExam
            // 
            pictureBoxGoToExam.Image = Properties.Resources.images1;
            pictureBoxGoToExam.Location = new Point(49, 140);
            pictureBoxGoToExam.Name = "pictureBoxGoToExam";
            pictureBoxGoToExam.Size = new Size(193, 198);
            pictureBoxGoToExam.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGoToExam.TabIndex = 2;
            pictureBoxGoToExam.TabStop = false;
            pictureBoxGoToExam.Click += pictureBoxGoToExam_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(341, 378);
            button1.Name = "button1";
            button1.Size = new Size(127, 37);
            button1.TabIndex = 3;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblBasliqMainPage
            // 
            lblBasliqMainPage.AutoSize = true;
            lblBasliqMainPage.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBasliqMainPage.Location = new Point(155, 9);
            lblBasliqMainPage.Name = "lblBasliqMainPage";
            lblBasliqMainPage.Size = new Size(519, 45);
            lblBasliqMainPage.TabIndex = 4;
            lblBasliqMainPage.Text = "Welcome to Driver's license exam";
            // 
            // pictureBoxAbout
            // 
            pictureBoxAbout.Image = Properties.Resources._189664;
            pictureBoxAbout.Location = new Point(311, 140);
            pictureBoxAbout.Name = "pictureBoxAbout";
            pictureBoxAbout.Size = new Size(184, 198);
            pictureBoxAbout.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAbout.TabIndex = 5;
            pictureBoxAbout.TabStop = false;
            pictureBoxAbout.Click += pictureBoxAbout_Click;
            // 
            // pictureBoxYourLastResult
            // 
            pictureBoxYourLastResult.Image = Properties.Resources.images__1_;
            pictureBoxYourLastResult.Location = new Point(571, 140);
            pictureBoxYourLastResult.Name = "pictureBoxYourLastResult";
            pictureBoxYourLastResult.Size = new Size(186, 198);
            pictureBoxYourLastResult.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxYourLastResult.TabIndex = 6;
            pictureBoxYourLastResult.TabStop = false;
            pictureBoxYourLastResult.Click += pictureBoxYourLastResult_Click;
            // 
            // lblLastReasult
            // 
            lblLastReasult.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastReasult.Location = new Point(555, 78);
            lblLastReasult.Name = "lblLastReasult";
            lblLastReasult.Size = new Size(213, 59);
            lblLastReasult.TabIndex = 7;
            lblLastReasult.Text = "Click to see your last session's result";
            lblLastReasult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 86);
            label1.Name = "label1";
            label1.Size = new Size(213, 43);
            label1.TabIndex = 8;
            label1.Text = "Go to About Page";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnChangeLoginMainPage
            // 
            btnChangeLoginMainPage.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnChangeLoginMainPage.Location = new Point(71, 378);
            btnChangeLoginMainPage.Name = "btnChangeLoginMainPage";
            btnChangeLoginMainPage.Size = new Size(142, 37);
            btnChangeLoginMainPage.TabIndex = 9;
            btnChangeLoginMainPage.Text = "Change login";
            btnChangeLoginMainPage.UseVisualStyleBackColor = true;
            btnChangeLoginMainPage.Click += btnChangeLoginMainPage_Click;
            // 
            // btnFinishExamMainPage
            // 
            btnFinishExamMainPage.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFinishExamMainPage.Location = new Point(595, 378);
            btnFinishExamMainPage.Name = "btnFinishExamMainPage";
            btnFinishExamMainPage.Size = new Size(142, 37);
            btnFinishExamMainPage.TabIndex = 10;
            btnFinishExamMainPage.Text = "Exit";
            btnFinishExamMainPage.UseVisualStyleBackColor = true;
            btnFinishExamMainPage.Click += btnFinishExamMainPage_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFinishExamMainPage);
            Controls.Add(btnChangeLoginMainPage);
            Controls.Add(label1);
            Controls.Add(lblLastReasult);
            Controls.Add(pictureBoxYourLastResult);
            Controls.Add(pictureBoxAbout);
            Controls.Add(lblBasliqMainPage);
            Controls.Add(button1);
            Controls.Add(pictureBoxGoToExam);
            Controls.Add(lblGoToExam);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoToExam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYourLastResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblGoToExam;
        private PictureBox pictureBoxGoToExam;
        private Button button1;
        private Label lblBasliqMainPage;
        private PictureBox pictureBoxAbout;
        private PictureBox pictureBoxYourLastResult;
        private Label lblLastReasult;
        private Label label1;
        private Button btnChangeLoginMainPage;
        private Button btnFinishExamMainPage;
    }
}