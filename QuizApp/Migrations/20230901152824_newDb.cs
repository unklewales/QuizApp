using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApp.Migrations
{
    /// <inheritdoc />
    public partial class newDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsCorrect",
                table: "Questions",
                newName: "IsCorrectD");

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrectA",
                table: "Questions",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrectB",
                table: "Questions",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrectC",
                table: "Questions",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCorrectA",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "IsCorrectB",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "IsCorrectC",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "IsCorrectD",
                table: "Questions",
                newName: "IsCorrect");
        }
    }
}
