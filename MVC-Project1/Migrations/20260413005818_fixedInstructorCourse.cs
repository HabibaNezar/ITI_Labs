using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Project1.Migrations
{
    /// <inheritdoc />
    public partial class fixedInstructorCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstructorCourses_Courses_CourseCrsId",
                table: "InstructorCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorCourses_Instructors_InstructorInsId",
                table: "InstructorCourses");

            migrationBuilder.DropIndex(
                name: "IX_InstructorCourses_CourseCrsId",
                table: "InstructorCourses");

            migrationBuilder.DropIndex(
                name: "IX_InstructorCourses_InstructorInsId",
                table: "InstructorCourses");

            migrationBuilder.DropColumn(
                name: "CourseCrsId",
                table: "InstructorCourses");

            migrationBuilder.DropColumn(
                name: "InstructorInsId",
                table: "InstructorCourses");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCourses_CrsId",
                table: "InstructorCourses",
                column: "CrsId");

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorCourses_Courses_CrsId",
                table: "InstructorCourses",
                column: "CrsId",
                principalTable: "Courses",
                principalColumn: "CrsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorCourses_Instructors_InsId",
                table: "InstructorCourses",
                column: "InsId",
                principalTable: "Instructors",
                principalColumn: "InsId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstructorCourses_Courses_CrsId",
                table: "InstructorCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorCourses_Instructors_InsId",
                table: "InstructorCourses");

            migrationBuilder.DropIndex(
                name: "IX_InstructorCourses_CrsId",
                table: "InstructorCourses");

            migrationBuilder.AddColumn<int>(
                name: "CourseCrsId",
                table: "InstructorCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstructorInsId",
                table: "InstructorCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCourses_CourseCrsId",
                table: "InstructorCourses",
                column: "CourseCrsId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCourses_InstructorInsId",
                table: "InstructorCourses",
                column: "InstructorInsId");

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorCourses_Courses_CourseCrsId",
                table: "InstructorCourses",
                column: "CourseCrsId",
                principalTable: "Courses",
                principalColumn: "CrsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorCourses_Instructors_InstructorInsId",
                table: "InstructorCourses",
                column: "InstructorInsId",
                principalTable: "Instructors",
                principalColumn: "InsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
