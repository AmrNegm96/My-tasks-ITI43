using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task16Cont.Migrations
{
    /// <inheritdoc />
    public partial class tpcMapping2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnrollmentDate",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "People");

            migrationBuilder.CreateSequence(
                name: "PersonSequence");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "People",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR [PersonSequence]",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "PersonSequence");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "People",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR [PersonSequence]")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "EnrollmentDate",
                table: "People",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "People",
                type: "money",
                nullable: true);
        }
    }
}
