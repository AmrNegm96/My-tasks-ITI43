using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class ClientBranchRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BranchClient",
                columns: table => new
                {
                    BranchesId = table.Column<int>(type: "int", nullable: false),
                    ClientsCID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchClient", x => new { x.BranchesId, x.ClientsCID }); //compositePK
                    table.ForeignKey(
                        name: "FK_BranchClient_Branches_BranchesId",
                        column: x => x.BranchesId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchClient_Clients_ClientsCID",
                        column: x => x.ClientsCID,
                        principalTable: "Clients",
                        principalColumn: "CID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchClient_ClientsCID",
                table: "BranchClient",
                column: "ClientsCID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchClient");
        }
    }
}
