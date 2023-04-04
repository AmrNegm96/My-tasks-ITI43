﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task16Cont.Migrations
{
    /// <inheritdoc />
    public partial class IsEmployeeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "People");

            migrationBuilder.AddColumn<bool>(
                name: "IsEmployee",
                table: "People",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEmployee",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "People",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
