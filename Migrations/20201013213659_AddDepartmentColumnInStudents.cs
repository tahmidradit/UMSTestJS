using Microsoft.EntityFrameworkCore.Migrations;

namespace UMSTestJS.Migrations
{
    public partial class AddDepartmentColumnInStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartmentSelected",
                table: "Students",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentSelected",
                table: "Students");
        }
    }
}
