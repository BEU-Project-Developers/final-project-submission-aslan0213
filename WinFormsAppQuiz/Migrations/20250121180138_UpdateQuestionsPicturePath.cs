using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsAppQuiz.Migrations
{
    /// <inheritdoc />
    public partial class UpdateQuestionsPicturePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "PicturePath",
                value: "Images\\Screenshot 2025-01-21 195447.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "PicturePath",
                value: "Images\\Screenshot 2025-01-21 201128.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "PicturePath",
                value: "Images\\Screenshot 2025-01-21 201522.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "PicturePath",
                value: "Images\\Screenshot 2025-01-21 202446.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "PicturePath",
                value: "Images\\Screenshot 2025-01-21 203045.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "PicturePath",
                value: "\"C:\\Users\\lenovo\\OneDrive\\Pictures\\Screenshots\\Screenshot 2025-01-21 195447.png\"");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "PicturePath",
                value: "\"C:\\Users\\lenovo\\OneDrive\\Pictures\\Screenshots\\Screenshot 2025-01-21 201128.png\"");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "PicturePath",
                value: "\"C:\\Users\\lenovo\\OneDrive\\Pictures\\Screenshots\\Screenshot 2025-01-21 201522.png\"");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "PicturePath",
                value: "\"C:\\Users\\lenovo\\OneDrive\\Pictures\\Screenshots\\Screenshot 2025-01-21 202446.png\"");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "PicturePath",
                value: "\"C:\\Users\\lenovo\\OneDrive\\Pictures\\Screenshots\\Screenshot 2025-01-21 203045.png\"");
        }
    }
}
