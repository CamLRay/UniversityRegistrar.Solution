using Microsoft.EntityFrameworkCore.Migrations;

namespace Registrar.Migrations
{
    public partial class AddCourseNum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourseNum",
                table: "Courses",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseNum",
                table: "Courses");
        }
    }
}
