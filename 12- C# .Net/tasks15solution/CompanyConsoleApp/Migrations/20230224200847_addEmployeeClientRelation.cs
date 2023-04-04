using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class addEmployeeClientRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeClient",
                columns: table => new
                {
                    EmployeeEID = table.Column<int>(type: "int", nullable: false),
                    clientCID = table.Column<int>(type: "int", nullable: false),
                    Visit = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeClient", x => new { x.clientCID, x.EmployeeEID });
                    table.ForeignKey(
                        name: "FK_EmployeeClient_Clients_clientCID",
                        column: x => x.clientCID,
                        principalTable: "Clients",
                        principalColumn: "CID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeClient_Employees_EmployeeEID",
                        column: x => x.EmployeeEID,
                        principalTable: "Employees",
                        principalColumn: "EId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeClient_EmployeeEID",
                table: "EmployeeClient",
                column: "EmployeeEID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeClient");
        }
    }
}
