using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsAppQuiz.Migrations
{
    /// <inheritdoc />
    public partial class UpdateQuestionsSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CorrectAnswer", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "- Take the child with you.", "You have a six year old child with you in your car. You have just parked so you\n can collect a prescription from the chemist. You should -", "- Leave the child in the car.", "- Ask an older person sitting nearby to watch the child." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CorrectAnswer", "PicturePath", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "- No, not at any time.", "\"C:\\Users\\lenovo\\OneDrive\\Pictures\\Screenshots\\Screenshot 2025-01-21 195447.png\"", "You have just passed this sign. Can you park on this road ?", "- Yes.", "- Yes, but only in daylight hours." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CorrectAnswer", "PicturePath", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "- Move into the left lane.", "\"C:\\Users\\lenovo\\OneDrive\\Pictures\\Screenshots\\Screenshot 2025-01-21 201128.png\"", "You hear the siren of an ambulance approaching you from behind. You should -", "- Slow down to the speed of other traffic.", "- Continue at the same speed." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CorrectAnswer", "PicturePath", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "- You must obey the signs that are displayed at all times.", "\"C:\\Users\\lenovo\\OneDrive\\Pictures\\Screenshots\\Screenshot 2025-01-21 201522.png\"", "When you come across roadworks -", "- You only have to obey the signs when there are workers about.", "- You only have to obey the signs during working hours." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CorrectAnswer", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "- No.", "Are you allowed to use a hand-held mobile phone while driving a car?", "- Yes, but only when you stop at intersections", "- Yes, but you must hold the steering wheel with at least one hand" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CorrectAnswer", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "- at least 1 metre.", "You are driving on a road with a speed limit of 60km/h or less. How much space must you leave\nwhen passing a bicycle rider?-", "at least 1.5 metres", "- as much as you think is safe" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CorrectAnswer", "PicturePath", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "- 3 seconds", "\"C:\\Users\\lenovo\\OneDrive\\Pictures\\Screenshots\\Screenshot 2025-01-21 202446.png\"", "You should leave a gap between your vehicle and the one you are following. In good conditions\r\nthe gap should be -", "- 1 second.", "- 2 seconds." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CorrectAnswer", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "- Only when the gate is up and the lights stop flashing.", "If the boomgates are down and the signals are flashing, at a railway level crossing, you may begin\r\nto cross -", " If you cannot see a train approaching.", "- If you can safely go around the closed gate." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CorrectAnswer", "PicturePath", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "- Continue through the intersection.", "\"C:\\Users\\lenovo\\OneDrive\\Pictures\\Screenshots\\Screenshot 2025-01-21 203045.png\"", "As you drive into an intersection, the lights turn to yellow. You should -\r\n", "- Accelerate as hard as you can", "- Brake immediately to a stop" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CorrectAnswer", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "- Before coming to and as near to the intersection as\r\npossible.", "You drive up to an intersection with a stop sign. There is no painted stop line. Where should you\r\nstop?", "- At least five metres before the intersection.", "- At the point where you can see clearly in both directions." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CorrectAnswer", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "4", "What is 2 + 2?", "3", "5" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CorrectAnswer", "PicturePath", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "Paris", null, "What is the capital of France?", "London", "Berlin" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CorrectAnswer", "PicturePath", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "Mars", null, "Which planet is known as the Red Planet?", "Earth", "Venus" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CorrectAnswer", "PicturePath", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "Blue Whale", null, "What is the largest mammal?", "Elephant", "Giraffe" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CorrectAnswer", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "100°C", "What is the boiling point of water?", "90°C", "80°C" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CorrectAnswer", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "William Shakespeare", "Who wrote 'Romeo and Juliet'?", "Charles Dickens", "Leo Tolstoy" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CorrectAnswer", "PicturePath", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "8", null, "What is the square root of 64?", "6", "7" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CorrectAnswer", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "H2O", "What is the chemical symbol for water?", "HO2", "O2H" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CorrectAnswer", "PicturePath", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "Leonardo da Vinci", null, "Who painted the Mona Lisa?", "Vincent van Gogh", "Pablo Picasso" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CorrectAnswer", "Text", "WrongAnswerOne", "WrongAnswerTwo" },
                values: new object[] { "Asia", "What is the largest continent?", "Africa", "Europe" });
        }
    }
}
