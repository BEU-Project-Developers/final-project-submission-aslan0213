using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using WinFormsAppQuiz.DataAccess;
using WinFormsAppQuiz.Entitys;
using WinFormsAppQuiz.Forms;

namespace WinFormsAppQuiz
{
    public partial class Form1 : Form
    {
        private QuestionDbContext _dbContext;
        private List<Question> _questions;
        private int _currentQuestionIndex;       
        private int _worth;
        private List<string> _currentAnswers;
        

        public Form1()
        {
            InitializeComponent();
            _dbContext = new QuestionDbContext();
            StartGame();
        }



        private void StartGame()
        {
            _questions = _dbContext.Questions.OrderBy(q => Guid.NewGuid()).Take(5).ToList();
            _currentQuestionIndex = 0;
            _worth = 0;
            LoadNextQuestion();
        }
        private void UpdateLastUserSession()
        {
            try
            {
                using (var context = new QuestionDbContext())
                {
                    // Get the last row based on Id (assuming Id is auto-incrementing)
                    var lastSession = context.UserSession.OrderByDescending(us => us.Id).FirstOrDefault();


                    // Update fields
                    if (_worth < 4)
                    {
                        lastSession.PassOrFail = "Fail";
                    }
                    else
                    {
                        lastSession.PassOrFail = "Pass";
                    }
                        lastSession.worth = _worth;

                        // Save changes to the database
                        context.SaveChanges();
                        //MessageBox.Show("Last row updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\nInner Exception: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNextQuestion()
        {
            if (_currentQuestionIndex >= _questions.Count)
            {    
                // suallar bitibse bu metodlar ise dusur 
                ShowScore();
                UpdateLastUserSession();
                return;
            }

            var question = _questions[_currentQuestionIndex];
            _currentAnswers = new List<string>
    {
        question.CorrectAnswer,
        question.WrongAnswerOne,
        question.WrongAnswerTwo
    };

            _currentAnswers = _currentAnswers.OrderBy(a => Guid.NewGuid()).ToList();

            Controls.Clear();

            // sualimiz
            var questionLabel = new Label
            {
                Text = question.Text,
                Font = new Font("Arial", 14),
                Location = new Point(50, 50),
                AutoSize = true
            };

            Controls.Add(questionLabel);

            // suala aid sekil
            if (!string.IsNullOrWhiteSpace(question.PicturePath))
            {
                var basePath = @"C:\Users\lenovo\OneDrive\Desktop\my c# project\WinFormsAppQuiz"; 
                var fullPath = Path.Combine(basePath, question.PicturePath); 

                if (File.Exists(fullPath))
                {
                    var pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(fullPath),
                        Location = new Point(480, 170),
                        Size = new Size(300, 200),
                        SizeMode = PictureBoxSizeMode.Zoom
                    };

                    Controls.Add(pictureBox);
                }
                else
                {
                    MessageBox.Show($"Image not found: {fullPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            
            
            for (int i = 0; i < _currentAnswers.Count; i++)
            {
                var answerButton = new Button
                {
                    Text = $"{(char)('A' + i)}. {_currentAnswers[i]}",
                    Location = new Point(50, 200 + i * 60),
                    Width = 300,
                    Height = 50,
                    Tag = _currentAnswers[i]
                };
                answerButton.Click += AnswerButton_Click;
                Controls.Add(answerButton);
            }
        }



        private void AnswerButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var selectedAnswer = button?.Tag.ToString();

            if (_questions[_currentQuestionIndex].CorrectAnswer == selectedAnswer)
            {
                _worth++;
            }

            _currentQuestionIndex++;
            LoadNextQuestion();
        }
        private string passorfailexam()
        {
            if (_worth<4)
            {
              return  "You did not pass the exam. Try again!";
            }
            return "Congratulations! You Passed the Exam! ";
        }

        private void ShowScore()
        {
            //sehifede olan duymeleri ve s. tamamile silir
            Controls.Clear();

            var passorfailLabel = new Label
            {
                Text = passorfailexam(),
                Font = new Font("Arial", 24, FontStyle.Bold),
                ForeColor = Color.Green,
                Location = new Point(50, 50),
                AutoSize = true
            };
            

            var worthLabel = new Label
            {
                Text = $"Your Worth: {_worth}",
                Font = new Font("Arial", 20),
                Location = new Point(50, 110),
                AutoSize = true
            };

            var wrongLabel = new Label
            {
                Text = $"Your Wrong: {5 - _worth}",
                Font = new Font("Arial", 20),
                Location = new Point(300, 110),
                AutoSize = true
            };

            var restartButton = new Button
            {
                Text = "Restart",
                Location = new Point(200, 210),
                Width = 200,
                Height = 50,
            };
            restartButton.Click += (s, e) => StartGame();
            var backtoMainpageButton = new Button
            {
                Text = "Back to main page",
                Location = new Point(275, 270),
                Width = 290,
                Height = 50,
                BackColor = Color.Black,
                ForeColor = Color.White,
            };
            backtoMainpageButton.Click += (s, e) =>
            {
                this.Close();
                MainPage mainPage = new MainPage();
                mainPage.Show();

            };

            //var addQuestionButton = new Button
            //{
            //    Text = "Add Question",
            //    Location = new Point(200, 200),
            //    Width = 200,
            //    Height = 50,
            //};
            //addQuestionButton.Click += (s, e) => ShowAddQuestionForm();
            var FinishExamButton = new Button
            {
                Text = "Finish Exam",
                Location = new Point(450, 210),
                Width = 200,
                Height = 50,

            };
            FinishExamButton.Click += (s, e) =>
            {
                Application.Exit();
            };
            //var changeLoginButton = new Button
            //{
            //    Text = "Change Login",
            //    Location = new Point(450, 200),
            //    Width = 200,
            //    Height = 50
            //};
            //changeLoginButton.Click += (s, e) =>
            //{
            //    var changeLoginForm = new Forms.ChangeLoginForm();

            //    changeLoginForm.Show();
            //    this.Close();
            //};

            //Controls.Add(scoreLabel);
            Controls.Add(worthLabel);
            Controls.Add(wrongLabel);
            Controls.Add(restartButton);
            //Controls.Add(addQuestionButton);
           // Controls.Add(changeLoginButton);
            Controls.Add(FinishExamButton);
            Controls.Add(passorfailLabel);
            Controls.Add(backtoMainpageButton);
        }

        //private void ShowAddQuestionForm()
        //{
        //    Controls.Clear();

        //    var questionTextBox = new TextBox { PlaceholderText = "Question Text", Location = new Point(50, 50), Width = 300 };
        //    var correctAnswerTextBox = new TextBox { PlaceholderText = "Correct Answer", Location = new Point(50, 100), Width = 300 };
        //    var wrongAnswerOneTextBox = new TextBox { PlaceholderText = "Wrong Answer 1", Location = new Point(50, 150), Width = 300 };
        //    var wrongAnswerTwoTextBox = new TextBox { PlaceholderText = "Wrong Answer 2", Location = new Point(50, 200), Width = 300 };

        //   // var scoreTextBox = new TextBox { PlaceholderText = "Score (numeric)", Location = new Point(50, 300), Width = 300 };
        //    var BacktoMainpageButtonAddquestion = new Button
        //    {
        //        Text = "Back to main page",
        //        Location = new Point(275, 300),
        //        Width = 290,
        //        Height = 50,
        //        BackColor = Color.Black,
        //        ForeColor = Color.White,
        //    };
        //    BacktoMainpageButtonAddquestion.Click += (s, e) =>
        //    {
        //        this.Close();
        //        MainPage mainPage = new MainPage();
        //        mainPage.Show();

        //    };
        //    var addButton = new Button
        //    {
        //        Text = "Add",
        //        Location = new Point(420, 125),
        //        Width = 300,
        //        Height = 50,
        //    };
        //    addButton.Click += (s, e) =>
        //    {
        //        if (string.IsNullOrWhiteSpace(questionTextBox.Text) ||
        //            string.IsNullOrWhiteSpace(correctAnswerTextBox.Text) ||
        //            string.IsNullOrWhiteSpace(wrongAnswerOneTextBox.Text) ||
        //            string.IsNullOrWhiteSpace(wrongAnswerTwoTextBox.Text) 
        //           // || string.IsNullOrWhiteSpace(scoreTextBox.Text)
        //           )
        //        {
        //            MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        //if (!int.TryParse(scoreTextBox.Text, out int score) || score <= 0)
        //        //{
        //        //    MessageBox.Show("Score must be a positive integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        //    return;
        //        //}

        //        var newQuestion = new Question
        //        {
        //            Text = questionTextBox.Text,
        //            CorrectAnswer = correctAnswerTextBox.Text,
        //            WrongAnswerOne = wrongAnswerOneTextBox.Text,
        //            WrongAnswerTwo = wrongAnswerTwoTextBox.Text,

        //           // Score = score
        //        };
               

        //        _dbContext.Questions.Add(newQuestion);
        //        _dbContext.SaveChanges();
        //        StartGame();

        //    };

            //Controls.Add(questionTextBox);
            //Controls.Add(correctAnswerTextBox);
            //Controls.Add(wrongAnswerOneTextBox);
            //Controls.Add(wrongAnswerTwoTextBox);
            // Controls.Add(scoreTextBox);
            //Controls.Add(addButton);
            //Controls.Add(BacktoMainpageButtonAddquestion);
       // }

       
    }
}



