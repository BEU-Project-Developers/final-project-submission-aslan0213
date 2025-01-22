using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsAppQuiz.Migrations
{
    /// <inheritdoc />
    public partial class AddUserInformationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Full_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    worth = table.Column<int>(type: "int", nullable: false),
                    PassOrFail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersInformation_Admins_Id",
                        column: x => x.Id,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UsersInformation",
                columns: new[] { "Id", "Full_Name", "Login", "PassOrFail", "worth" },
                values: new object[] { 1, "System_Administrator", "admin", "Pass", 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersInformation");
        }
    }
}
