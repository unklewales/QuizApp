using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApp.Migrations
{
    /// <inheritdoc />
    public partial class updatedQuizModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Quizes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Quizes_DepartmentId",
                table: "Quizes",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizes_Departments_DepartmentId",
                table: "Quizes",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quizes_Departments_DepartmentId",
                table: "Quizes");

            migrationBuilder.DropIndex(
                name: "IX_Quizes_DepartmentId",
                table: "Quizes");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Quizes");
        }
    }
}
