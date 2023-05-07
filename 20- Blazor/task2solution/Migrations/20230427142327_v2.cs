using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorDay2Task.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Tracks_TrackId",
                table: "Trainees");

            migrationBuilder.AlterColumn<int>(
                name: "TrackId",
                table: "Trainees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Tracks_TrackId",
                table: "Trainees",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "TrackId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Tracks_TrackId",
                table: "Trainees");

            migrationBuilder.AlterColumn<int>(
                name: "TrackId",
                table: "Trainees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Tracks_TrackId",
                table: "Trainees",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "TrackId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
