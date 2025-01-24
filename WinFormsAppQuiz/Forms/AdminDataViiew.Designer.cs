namespace WinFormsAppQuiz.Forms
{
    partial class AdminDataViiew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDataViiew));
            lblBasliq = new Label();
            lblGoToAdd = new Label();
            pictureBoxGoToAdd = new PictureBox();
            dataGridViewUsersInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoToAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsersInfo).BeginInit();
            SuspendLayout();
            // 
            // lblBasliq
            // 
            lblBasliq.AutoSize = true;
            lblBasliq.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBasliq.Location = new Point(22, 33);
            lblBasliq.Name = "lblBasliq";
            lblBasliq.Size = new Size(525, 30);
            lblBasliq.TabIndex = 0;
            lblBasliq.Text = "Information about members that compleate exam ";
            // 
            // lblGoToAdd
            // 
            lblGoToAdd.AutoSize = true;
            lblGoToAdd.Location = new Point(644, 9);
            lblGoToAdd.Name = "lblGoToAdd";
            lblGoToAdd.Size = new Size(101, 40);
            lblGoToAdd.TabIndex = 1;
            lblGoToAdd.Text = "Go to adding \r\nquestion ";
            // 
            // pictureBoxGoToAdd
            // 
            pictureBoxGoToAdd.Image = Properties.Resources.toward;
            pictureBoxGoToAdd.Location = new Point(738, 4);
            pictureBoxGoToAdd.Name = "pictureBoxGoToAdd";
            pictureBoxGoToAdd.Size = new Size(50, 45);
            pictureBoxGoToAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGoToAdd.TabIndex = 2;
            pictureBoxGoToAdd.TabStop = false;
            pictureBoxGoToAdd.Click += pictureBoxGoToAdd_Click;
            // 
            // dataGridViewUsersInfo
            // 
            dataGridViewUsersInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsersInfo.Location = new Point(12, 79);
            dataGridViewUsersInfo.Name = "dataGridViewUsersInfo";
            dataGridViewUsersInfo.RowHeadersWidth = 51;
            dataGridViewUsersInfo.Size = new Size(776, 359);
            dataGridViewUsersInfo.TabIndex = 3;
            dataGridViewUsersInfo.CellContentClick += dataGridViewUsersInfo_CellContentClick;
            // 
            // AdminDataViiew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewUsersInfo);
            Controls.Add(pictureBoxGoToAdd);
            Controls.Add(lblGoToAdd);
            Controls.Add(lblBasliq);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminDataViiew";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDataViiew";
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoToAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsersInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBasliq;
        private Label lblGoToAdd;
        private PictureBox pictureBoxGoToAdd;
        private DataGridView dataGridViewUsersInfo;
    }
}