using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace day_2_ch.Migrations
{
    /// <inheritdoc />
    public partial class updateMyClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dept",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dept",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
