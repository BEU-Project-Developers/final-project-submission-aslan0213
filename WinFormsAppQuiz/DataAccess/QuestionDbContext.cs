using Microsoft.EntityFrameworkCore;
using WinFormsAppQuiz.Entitys;

namespace WinFormsAppQuiz.DataAccess
{
    public class QuestionDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Question> Questions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QuestionDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(new Admin
            {
                Id = 1,
                Login = "admin",
                Password = "12345",
                Full_Name="System_Administrator"
                
            });

            modelBuilder.Entity<Question>().HasData(
                new Question { Id = 1, Text = "What is 2 + 2?", Score = 5, CorrectAnswer = "4", WrongAnswerOne = "3", WrongAnswerTwo = "5", WrongAnswerThree = "6" },
                new Question { Id = 2, Text = "What is the capital of France?", Score = 5, CorrectAnswer = "Paris", WrongAnswerOne = "London", WrongAnswerTwo = "Berlin", WrongAnswerThree = "Madrid" },
                new Question { Id = 3, Text = "Which planet is known as the Red Planet?", Score = 5, CorrectAnswer = "Mars", WrongAnswerOne = "Earth", WrongAnswerTwo = "Venus", WrongAnswerThree = "Jupiter" },
                new Question { Id = 4, Text = "What is the largest mammal?", Score = 5, CorrectAnswer = "Blue Whale", WrongAnswerOne = "Elephant", WrongAnswerTwo = "Giraffe", WrongAnswerThree = "Whale Shark" },
                new Question { Id = 5, Text = "What is the boiling point of water?", Score = 5, CorrectAnswer = "100°C", WrongAnswerOne = "90°C", WrongAnswerTwo = "80°C", WrongAnswerThree = "120°C" },
                new Question { Id = 6, Text = "Who wrote 'Romeo and Juliet'?", Score = 5, CorrectAnswer = "William Shakespeare", WrongAnswerOne = "Charles Dickens", WrongAnswerTwo = "Leo Tolstoy", WrongAnswerThree = "Mark Twain" },
                new Question { Id = 7, Text = "What is the square root of 64?", Score = 5, CorrectAnswer = "8", WrongAnswerOne = "6", WrongAnswerTwo = "7", WrongAnswerThree = "9" },
                new Question { Id = 8, Text = "What is the chemical symbol for water?", Score = 5, CorrectAnswer = "H2O", WrongAnswerOne = "HO2", WrongAnswerTwo = "O2H", WrongAnswerThree = "OH2" },
                new Question { Id = 9, Text = "Who painted the Mona Lisa?", Score = 5, CorrectAnswer = "Leonardo da Vinci", WrongAnswerOne = "Vincent van Gogh", WrongAnswerTwo = "Pablo Picasso", WrongAnswerThree = "Claude Monet" },
                new Question { Id = 10, Text = "What is the largest continent?", Score = 5, CorrectAnswer = "Asia", WrongAnswerOne = "Africa", WrongAnswerTwo = "Europe", WrongAnswerThree = "Antarctica" }
            );
        }
    }
}
