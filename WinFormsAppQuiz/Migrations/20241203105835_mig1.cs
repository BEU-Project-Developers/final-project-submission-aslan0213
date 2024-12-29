using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WinFormsAppQuiz.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: false),
                    CorrectAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WrongAnswerOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WrongAnswerTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WrongAnswerThree = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Login", "Password" },
                values: new object[] { 1, "admin", "12345" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswer", "Score", "Text", "WrongAnswerOne", "WrongAnswerThree", "WrongAnswerTwo" },
                values: new object[,]
                {
                    { 1, "4", 5.0, "What is 2 + 2?", "3", "6", "5" },
                    { 2, "Paris", 5.0, "What is the capital of France?", "London", "Madrid", "Berlin" },
                    { 3, "Mars", 5.0, "Which planet is known as the Red Planet?", "Earth", "Jupiter", "Venus" },
                    { 4, "Blue Whale", 5.0, "What is the largest mammal?", "Elephant", "Whale Shark", "Giraffe" },
                    { 5, "100°C", 5.0, "What is the boiling point of water?", "90°C", "120°C", "80°C" },
                    { 6, "William Shakespeare", 5.0, "Who wrote 'Romeo and Juliet'?", "Charles Dickens", "Mark Twain", "Leo Tolstoy" },
                    { 7, "8", 5.0, "What is the square root of 64?", "6", "9", "7" },
                    { 8, "H2O", 5.0, "What is the chemical symbol for water?", "HO2", "OH2", "O2H" },
                    { 9, "Leonardo da Vinci", 5.0, "Who painted the Mona Lisa?", "Vincent van Gogh", "Claude Monet", "Pablo Picasso" },
                    { 10, "Asia", 5.0, "What is the largest continent?", "Africa", "Antarctica", "Europe" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
