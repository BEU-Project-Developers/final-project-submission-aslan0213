using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsAppQuiz.Migrations
{
    /// <inheritdoc />
    public partial class UpdateQuestionsAddAbzas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Text",
                value: "You have a six year old child with you in\n your car. You have just parked so you\n can collect a prescription from the \nchemist. You should -");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Text",
                value: "You have just passed this sign.\n Can you park on this road ?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Text",
                value: "You hear the siren of an ambulance\n approaching you from behind. You should -");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Text",
                value: "Are you allowed to use a hand-held \nmobile phone while driving a car?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Text",
                value: "You are driving on a road with\n a speed limit of 60km/h or less. How much space\n must you leavewhen passing a bicycle rider?-");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Text",
                value: "You should leave a gap between your vehicle and the\n one you are following. In good conditions\r\nthe gap should be -");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Text",
                value: "If the boomgates are down and the signals are flashing,\n at a railway level crossing, you may begin\r\nto cross -");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Text",
                value: "You drive up to an intersection with a stop sign.\n There is no painted stop line. Where should you\r\nstop?");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Text",
                value: "You have a six year old child with you in your car. You have just parked so you\n can collect a prescription from the chemist. You should -");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Text",
                value: "You have just passed this sign. Can you park on this road ?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Text",
                value: "You hear the siren of an ambulance approaching you from behind. You should -");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Text",
                value: "Are you allowed to use a hand-held mobile phone while driving a car?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Text",
                value: "You are driving on a road with a speed limit of 60km/h or less. How much space must you leave\nwhen passing a bicycle rider?-");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Text",
                value: "You should leave a gap between your vehicle and the one you are following. In good conditions\r\nthe gap should be -");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Text",
                value: "If the boomgates are down and the signals are flashing, at a railway level crossing, you may begin\r\nto cross -");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Text",
                value: "You drive up to an intersection with a stop sign. There is no painted stop line. Where should you\r\nstop?");
        }
    }
}
