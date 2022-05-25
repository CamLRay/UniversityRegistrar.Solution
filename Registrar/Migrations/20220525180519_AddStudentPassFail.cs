using Microsoft.EntityFrameworkCore.Migrations;

namespace Registrar.Migrations
{
    public partial class AddStudentPassFail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassFail",
                table: "Courses");

            migrationBuilder.AddColumn<bool>(
                name: "PassFail",
                table: "Students",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassFail",
                table: "Students");

            migrationBuilder.AddColumn<bool>(
                name: "PassFail",
                table: "Courses",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
