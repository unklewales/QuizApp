using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApp.Migrations
{
    /// <inheritdoc />
    public partial class restructureQuestionmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Questions_CorrectAnswerId",
                table: "Questions");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CorrectAnswerId",
                table: "Questions",
                column: "CorrectAnswerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Questions_CorrectAnswerId",
                table: "Questions");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CorrectAnswerId",
                table: "Questions",
                column: "CorrectAnswerId",
                unique: true);
        }
    }
}
