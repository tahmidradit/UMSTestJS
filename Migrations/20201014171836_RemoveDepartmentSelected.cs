using Microsoft.EntityFrameworkCore.Migrations;

namespace UMSTestJS.Migrations
{
    public partial class RemoveDepartmentSelected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentSelected",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Departments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_StudentId",
                table: "Departments",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Students_StudentId",
                table: "Departments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Students_StudentId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_StudentId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Departments");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentSelected",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
