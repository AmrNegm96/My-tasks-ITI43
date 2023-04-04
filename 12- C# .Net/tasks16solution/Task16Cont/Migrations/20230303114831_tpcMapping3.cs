using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task16Cont.Migrations
{
    /// <inheritdoc />
    public partial class tpcMapping3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [PersonSequence]"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmployee = table.Column<bool>(type: "bit", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [PersonSequence]"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmployee = table.Column<bool>(type: "bit", nullable: false),
                    Salary = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [PersonSequence]"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmployee = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });
        }
    }
}
