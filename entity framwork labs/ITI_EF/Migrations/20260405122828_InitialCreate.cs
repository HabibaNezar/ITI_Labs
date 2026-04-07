using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI_EF.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Top_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Top_Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Crs_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crs_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Crs_Duration = table.Column<int>(type: "int", nullable: false),
                    Top_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Crs_Id);
                    table.ForeignKey(
                        name: "FK_Courses_Topics_Top_Id",
                        column: x => x.Top_Id,
                        principalTable: "Topics",
                        principalColumn: "Top_Id");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Dept_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dept_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dept_Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dept_Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dept_Manager = table.Column<int>(type: "int", nullable: true),
                    Manager_hiredate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Dept_Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Ins_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ins_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ins_Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Dept_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Ins_Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_Dept_Id",
                        column: x => x.Dept_Id,
                        principalTable: "Departments",
                        principalColumn: "Dept_Id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    St_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    St_Fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    St_Lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    St_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    St_Age = table.Column<int>(type: "int", nullable: true),
                    Dept_Id = table.Column<int>(type: "int", nullable: true),
                    St_super = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.St_Id);
                    table.ForeignKey(
                        name: "FK_Students_Departments_Dept_Id",
                        column: x => x.Dept_Id,
                        principalTable: "Departments",
                        principalColumn: "Dept_Id");
                    table.ForeignKey(
                        name: "FK_Students_Students_St_super",
                        column: x => x.St_super,
                        principalTable: "Students",
                        principalColumn: "St_Id");
                });

            migrationBuilder.CreateTable(
                name: "Ins_Courses",
                columns: table => new
                {
                    Ins_Id = table.Column<int>(type: "int", nullable: false),
                    Crs_Id = table.Column<int>(type: "int", nullable: false),
                    Evaluation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ins_Courses", x => new { x.Ins_Id, x.Crs_Id });
                    table.ForeignKey(
                        name: "FK_Ins_Courses_Courses_Crs_Id",
                        column: x => x.Crs_Id,
                        principalTable: "Courses",
                        principalColumn: "Crs_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ins_Courses_Instructors_Ins_Id",
                        column: x => x.Ins_Id,
                        principalTable: "Instructors",
                        principalColumn: "Ins_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stud_Courses",
                columns: table => new
                {
                    Crs_Id = table.Column<int>(type: "int", nullable: false),
                    St_Id = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud_Courses", x => new { x.St_Id, x.Crs_Id });
                    table.ForeignKey(
                        name: "FK_Stud_Courses_Courses_Crs_Id",
                        column: x => x.Crs_Id,
                        principalTable: "Courses",
                        principalColumn: "Crs_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stud_Courses_Students_St_Id",
                        column: x => x.St_Id,
                        principalTable: "Students",
                        principalColumn: "St_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_Id",
                table: "Courses",
                column: "Top_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Dept_Manager",
                table: "Departments",
                column: "Dept_Manager");

            migrationBuilder.CreateIndex(
                name: "IX_Ins_Courses_Crs_Id",
                table: "Ins_Courses",
                column: "Crs_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_Id",
                table: "Instructors",
                column: "Dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_Crs_Id",
                table: "Stud_Courses",
                column: "Crs_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Dept_Id",
                table: "Students",
                column: "Dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_St_super",
                table: "Students",
                column: "St_super");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Dept_Manager",
                table: "Departments",
                column: "Dept_Manager",
                principalTable: "Instructors",
                principalColumn: "Ins_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Dept_Manager",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "Ins_Courses");

            migrationBuilder.DropTable(
                name: "Stud_Courses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
