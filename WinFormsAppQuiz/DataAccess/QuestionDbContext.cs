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
                new Question { Id = 1, Text = "You have a six year old child with you in\n your car. You have just parked so you\n can collect a prescription from the \nchemist. You should -", Score = 5, CorrectAnswer = "- Take the child with you.", WrongAnswerOne = "- Leave the child in the car.", WrongAnswerTwo = "- Ask an older person sitting nearby to watch the child.", PicturePath = null },
                new Question { Id = 2, Text = "You have just passed this sign.\n Can you park on this road ?", Score = 5, CorrectAnswer = "- No, not at any time.", WrongAnswerOne = "- Yes.", WrongAnswerTwo = "- Yes, but only in daylight hours.", PicturePath = "Images\\Screenshot 2025-01-21 195447.png" },
                new Question { Id = 3, Text = "You hear the siren of an ambulance\n approaching you from behind. You should -", Score = 5, CorrectAnswer = "- Move into the left lane.", WrongAnswerOne = "- Slow down to the speed of other traffic.", WrongAnswerTwo = "- Continue at the same speed.", PicturePath = "Images\\Screenshot 2025-01-21 201128.png" },
                new Question { Id = 4, Text = "When you come across roadworks -", Score = 5, CorrectAnswer = "- You must obey the signs that are displayed at all times.", WrongAnswerOne = "- You only have to obey the signs when there are workers about.", WrongAnswerTwo = "- You only have to obey the signs during working hours.", PicturePath = "Images\\Screenshot 2025-01-21 201522.png" },
                new Question { Id = 5, Text = "Are you allowed to use a hand-held \nmobile phone while driving a car?", Score = 5, CorrectAnswer = "- No.", WrongAnswerOne = "- Yes, but only when you stop at intersections", WrongAnswerTwo = "- Yes, but you must hold the steering wheel with at least one hand", PicturePath = null },
                new Question { Id = 6, Text = "You are driving on a road with\n a speed limit of 60km/h or less. How much space\n must you leavewhen passing a bicycle rider?-", Score = 5, CorrectAnswer = "- at least 1 metre.", WrongAnswerOne = "at least 1.5 metres", WrongAnswerTwo = "- as much as you think is safe", PicturePath = null },
                new Question { Id = 7, Text = "You should leave a gap between your vehicle and the\n one you are following. In good conditions\r\nthe gap should be -", Score = 5, CorrectAnswer = "- 3 seconds", WrongAnswerOne = "- 1 second.", WrongAnswerTwo = "- 2 seconds.", PicturePath = "Images\\Screenshot 2025-01-21 202446.png" },
                new Question { Id = 8, Text = "If the boomgates are down and the signals are flashing,\n at a railway level crossing, you may begin\r\nto cross -", Score = 5, CorrectAnswer = "- Only when the gate is up and the lights stop flashing.", WrongAnswerOne = " If you cannot see a train approaching.", WrongAnswerTwo = "- If you can safely go around the closed gate.", PicturePath = null },
                new Question { Id = 9, Text = "As you drive into an intersection, the lights turn to yellow. You should -\r\n", Score = 5, CorrectAnswer = "- Continue through the intersection.", WrongAnswerOne = "- Accelerate as hard as you can", WrongAnswerTwo = "- Brake immediately to a stop", PicturePath = "Images\\Screenshot 2025-01-21 203045.png" },
                new Question { Id = 10, Text = "You drive up to an intersection with a stop sign.\n There is no painted stop line. Where should you\r\nstop?", Score = 5, CorrectAnswer = "- Before coming to and as near to the intersection as\r\npossible.", WrongAnswerOne = "- At least five metres before the intersection.", WrongAnswerTwo = "- At the point where you can see clearly in both directions.", PicturePath = null }
            );
        }
    }
}
