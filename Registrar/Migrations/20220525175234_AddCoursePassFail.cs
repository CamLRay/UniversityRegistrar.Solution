using Microsoft.EntityFrameworkCore.Migrations;

namespace Registrar.Migrations
{
    public partial class AddCoursePassFail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Courses");
        }
    }
}
