using Microsoft.EntityFrameworkCore.Migrations;

namespace TabbyAcatemy.Migrations
{
    public partial class SeedCourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name", "PhotoPath" },
                values: new object[] { 1, "Linear Algebra", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
