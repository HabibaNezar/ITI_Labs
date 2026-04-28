using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Project1.Migrations
{
    /// <inheritdoc />
    public partial class addTopics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Topics",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Topics",
                table: "Courses");
        }
    }
}
