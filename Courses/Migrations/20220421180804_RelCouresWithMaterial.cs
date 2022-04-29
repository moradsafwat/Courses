using Microsoft.EntityFrameworkCore.Migrations;

namespace Courses.Migrations
{
    public partial class RelCouresWithMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Materials_CourseId",
                table: "Materials");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_CourseId",
                table: "Materials",
                column: "CourseId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Materials_CourseId",
                table: "Materials");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_CourseId",
                table: "Materials",
                column: "CourseId");
        }
    }
}
