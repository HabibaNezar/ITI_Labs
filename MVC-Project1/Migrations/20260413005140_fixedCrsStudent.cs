using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Project1.Migrations
{
    /// <inheritdoc />
    public partial class fixedCrsStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Courses_CourseCrsId",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Students_StudentSsn",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourses_CourseCrsId",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourses_StudentSsn",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "CourseCrsId",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "StudentSsn",
                table: "StudentCourses");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CrsId",
                table: "StudentCourses",
                column: "CrsId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Courses_CrsId",
                table: "StudentCourses",
                column: "CrsId",
                principalTable: "Courses",
                principalColumn: "CrsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Students_Ssn",
                table: "StudentCourses",
                column: "Ssn",
                principalTable: "Students",
                principalColumn: "Ssn",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Courses_CrsId",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Students_Ssn",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourses_CrsId",
                table: "StudentCourses");

            migrationBuilder.AddColumn<int>(
                name: "CourseCrsId",
                table: "StudentCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentSsn",
                table: "StudentCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseCrsId",
                table: "StudentCourses",
                column: "CourseCrsId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_StudentSsn",
                table: "StudentCourses",
                column: "StudentSsn");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Courses_CourseCrsId",
                table: "StudentCourses",
                column: "CourseCrsId",
                principalTable: "Courses",
                principalColumn: "CrsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Students_StudentSsn",
                table: "StudentCourses",
                column: "StudentSsn",
                principalTable: "Students",
                principalColumn: "Ssn",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
