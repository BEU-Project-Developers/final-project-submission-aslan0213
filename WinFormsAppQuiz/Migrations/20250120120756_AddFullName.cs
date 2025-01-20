using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsAppQuiz.Migrations
{
    /// <inheritdoc />
    public partial class AddFullName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Full_Name",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "unknown");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Full_Name",
                value: "System_Administrator");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Full_Name",
                table: "Admins");
        }
    }
}
