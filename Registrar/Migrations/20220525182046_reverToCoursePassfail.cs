using Microsoft.EntityFrameworkCore.Migrations;

namespace Registrar.Migrations
{
    public partial class reverToCoursePassfail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassFail",
                table: "Students");

            migrationBuilder.AddColumn<bool>(
                name: "PassFail",
                table: "CourseStudent",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PassFail",
                table: "Courses",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassFail",
                table: "CourseStudent");

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
    }
}
