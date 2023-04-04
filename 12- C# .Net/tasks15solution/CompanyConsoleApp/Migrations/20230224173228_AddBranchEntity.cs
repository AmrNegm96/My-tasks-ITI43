using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class AddBranchEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OrderDeposit",
                table: "Clients",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Money");

            migrationBuilder.AlterColumn<string>(
                name: "MName",
                table: "Clients",
                type: "nchar(2)",
                fixedLength: true,
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nchar(2)",
                oldFixedLength: true,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    City = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.AlterColumn<decimal>(
                name: "OrderDeposit",
                table: "Clients",
                type: "Money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<string>(
                name: "MName",
                table: "Clients",
                type: "nchar(2)",
                fixedLength: true,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(2)",
                oldFixedLength: true,
                oldMaxLength: 2);
        }
    }
}
