using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task16Cont.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    
                    //added by default that carry the naem of entity using TPH strategy 
                    
                    Discriminator = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Salary = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
