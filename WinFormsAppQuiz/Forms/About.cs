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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void pictureBoxBackToMainPage_Click(object sender, EventArgs e)
        {
            
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }
    }
}
