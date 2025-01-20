using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsAppQuiz.DataAccess;
using WinFormsAppQuiz.Entitys;

namespace WinFormsAppQuiz
{
    public partial class Form1 : Form
    {
        private QuestionDbContext _dbContext;
        private List<Question> _questions;
        private int _currentQuestionIndex;
        private int _score;
        private int _worth;
        private List<string> _currentAnswers;

        public Form1()
        {
            InitializeComponent();
            _dbContext = new QuestionDbContext();
            StartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartGame()
        {
            _questions = _dbContext.Questions.OrderBy(q => Guid.NewGuid()).Take(5).ToList();
            _currentQuestionIndex = 0;
            _score = 0;
            _worth = 0;
            LoadNextQuestion();
        }

        private void LoadNextQuestion()
        {
            if (_currentQuestionIndex >= _questions.Count)
            {
                ShowScore();
                return;
            }

            var question = _questions[_currentQuestionIndex];
            _currentAnswers = new List<string>
            {
                question.CorrectAnswer,
                question.WrongAnswerOne,
                question.WrongAnswerTwo,
                question.WrongAnswerThree
            };

            _currentAnswers = _currentAnswers.OrderBy(a => Guid.NewGuid()).ToList();

            Controls.Clear();

            var questionLabel = new Label
            {
                Text = question.Text + $"   ( {question.Score} Worth )",
                Font = new Font("Arial", 16),
                Location = new Point(50, 50),
                AutoSize = true
            };

            Controls.Add(questionLabel);

            for (int i = 0; i < _currentAnswers.Count; i++)
            {
                var answerButton = new Button
                {
                    Text = $"{(char)('A' + i)}. {_currentAnswers[i]}",
                    Location = new Point(50, 100 + i * 60),
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
                _score += (int)_questions[_currentQuestionIndex].Score;
                _worth++;
            }

            _currentQuestionIndex++;
            LoadNextQuestion();
        }

        private void ShowScore()
        {
            Controls.Clear();

            var scoreLabel = new Label
            {
                Text = $"Your Score: {_score}",
                Font = new Font("Arial", 20),
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
                Location = new Point(50, 260),
                Width = 200,
                Height = 50,
            };
            restartButton.Click += (s, e) => StartGame();

            var addQuestionButton = new Button
            {
                Text = "Add Question",
                Location = new Point(50, 200),
                Width = 200,
                Height = 50,
            };
            addQuestionButton.Click += (s, e) => ShowAddQuestionForm();

            var changeLoginButton = new Button
            {
                Text = "Change Login",
                Location = new Point(300, 200),
                Width = 200,
                Height = 50
            };
            changeLoginButton.Click += (s, e) =>
            {
                var changeLoginForm = new Forms.ChangeLoginForm();
                
                changeLoginForm.Show();
            };

            Controls.Add(scoreLabel);
            Controls.Add(worthLabel);
            Controls.Add(wrongLabel);
            Controls.Add(restartButton);
            Controls.Add(addQuestionButton);
            Controls.Add(changeLoginButton);
        }

        private void ShowAddQuestionForm()
        {
            Controls.Clear();

            var questionTextBox = new TextBox { PlaceholderText = "Question Text", Location = new Point(50, 50), Width = 300 };
            var correctAnswerTextBox = new TextBox { PlaceholderText = "Correct Answer", Location = new Point(50, 100), Width = 300 };
            var wrongAnswerOneTextBox = new TextBox { PlaceholderText = "Wrong Answer 1", Location = new Point(50, 150), Width = 300 };
            var wrongAnswerTwoTextBox = new TextBox { PlaceholderText = "Wrong Answer 2", Location = new Point(50, 200), Width = 300 };
            var wrongAnswerThreeTextBox = new TextBox { PlaceholderText = "Wrong Answer 3", Location = new Point(50, 250), Width = 300 };
            var scoreTextBox = new TextBox { PlaceholderText = "Score (numeric)", Location = new Point(50, 300), Width = 300 };

            var addButton = new Button
            {
                Text = "Add",
                Location = new Point(50, 350),
                Width = 300,
                Height = 50,
            };
            addButton.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(questionTextBox.Text) ||
                    string.IsNullOrWhiteSpace(correctAnswerTextBox.Text) ||
                    string.IsNullOrWhiteSpace(wrongAnswerOneTextBox.Text) ||
                    string.IsNullOrWhiteSpace(wrongAnswerTwoTextBox.Text) ||
                    string.IsNullOrWhiteSpace(wrongAnswerThreeTextBox.Text) ||
                    string.IsNullOrWhiteSpace(scoreTextBox.Text))
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(scoreTextBox.Text, out int score) || score <= 0)
                {
                    MessageBox.Show("Score must be a positive integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newQuestion = new Question
                {
                    Text = questionTextBox.Text,
                    CorrectAnswer = correctAnswerTextBox.Text,
                    WrongAnswerOne = wrongAnswerOneTextBox.Text,
                    WrongAnswerTwo = wrongAnswerTwoTextBox.Text,
                    WrongAnswerThree = wrongAnswerThreeTextBox.Text,
                    Score = score
                };

                _dbContext.Questions.Add(newQuestion);
                _dbContext.SaveChanges();
                StartGame();
            };

            Controls.Add(questionTextBox);
            Controls.Add(correctAnswerTextBox);
            Controls.Add(wrongAnswerOneTextBox);
            Controls.Add(wrongAnswerTwoTextBox);
            Controls.Add(wrongAnswerThreeTextBox);
            Controls.Add(scoreTextBox);
            Controls.Add(addButton);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}



