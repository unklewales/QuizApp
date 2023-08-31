using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApp.Migrations
{
    /// <inheritdoc />
    public partial class changethingsinquestionmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Answers_CorrectAnswerId",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "CorrectAnswerId",
                table: "Questions",
                newName: "AnswerId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_CorrectAnswerId",
                table: "Questions",
                newName: "IX_Questions_AnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Answers_AnswerId",
                table: "Questions",
                column: "AnswerId",
                principalTable: "Answers",
                principalColumn: "AnswerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Answers_AnswerId",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "AnswerId",
                table: "Questions",
                newName: "CorrectAnswerId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_AnswerId",
                table: "Questions",
                newName: "IX_Questions_CorrectAnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Answers_CorrectAnswerId",
                table: "Questions",
                column: "CorrectAnswerId",
                principalTable: "Answers",
                principalColumn: "AnswerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
