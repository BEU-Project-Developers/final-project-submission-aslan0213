using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppQuiz.DataAccess;
using WinFormsAppQuiz.Entitys;

namespace WinFormsAppQuiz.Forms
{
    public partial class AdminDataViiew : Form
    {
        public AdminDataViiew()
        {
            InitializeComponent();
            LoadFilteredUserSessions();
        }

        private void pictureBoxGoToAdd_Click(object sender, EventArgs e)
        {
            AdminAddQuestrion adminAddQuestrion = new AdminAddQuestrion();
            adminAddQuestrion.Show();
            this.Close();
        }

        private void LoadFilteredUserSessions()
        {
            try
            {
                using (var context = new QuestionDbContext())
                {
                    var filteredSessions = context.UserSession
                        .Where(session => session.PassOrFail != "You did not compleate exam yet")
                        .ToList();

                    dataGridViewUsersInfo.DataSource = filteredSessions;

                    dataGridViewUsersInfo.Columns["Id"].HeaderText = "ID";
                    dataGridViewUsersInfo.Columns["Login"].HeaderText = "Login";
                    dataGridViewUsersInfo.Columns["Full_Name"].HeaderText = "Full Name";
                    dataGridViewUsersInfo.Columns["worth"].HeaderText = "Worth";
                    dataGridViewUsersInfo.Columns["PassOrFail"].HeaderText = "Result";
                    dataGridViewUsersInfo.Columns["LoginTime"].HeaderText = "Login Time";
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"An error occurred while fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewUsersInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    
                    var selectedRow = dataGridViewUsersInfo.Rows[e.RowIndex];

                    
                    string login = selectedRow.Cells["Login"].Value.ToString();
                    string fullName = selectedRow.Cells["Full_Name"].Value.ToString();
                    string passOrFail = selectedRow.Cells["PassOrFail"].Value.ToString();
                    DateTime loginTime = DateTime.Parse(selectedRow.Cells["LoginTime"].Value.ToString());

                   
                    MessageBox.Show($"Login: {login}\nFull Name: {fullName}\nResult: {passOrFail}\nLogin Time: {loginTime}");
                }
            }



        }
    }

