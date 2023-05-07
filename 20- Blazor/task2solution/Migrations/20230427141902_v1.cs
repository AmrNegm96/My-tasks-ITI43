using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorDay2Task.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    TrackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.TrackId);
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    TraineeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsGraduated = table.Column<bool>(type: "bit", nullable: false),
                    TrackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.TraineeId);
                    table.ForeignKey(
                        name: "FK_Trainees_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "TrackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "TrackId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "SD Track", "SD" },
                    { 2, "LD Track", "LD" },
                    { 3, "MD Track", "MD" },
                    { 4, "HD Track", "HD" },
                    { 5, "4K Track", "4K" },
                    { 6, "8K Track", "8K" },
                    { 7, "MP3 Track", "MP3" },
                    { 8, "FLAC Track", "FLAC" },
                    { 9, "WAV Track", "WAV" },
                    { 10, "AAC Track", "AAC" },
                    { 11, "AC3 Track", "AC3" },
                    { 12, "DTS Track", "DTS" },
                    { 13, "PCM Track", "PCM" },
                    { 14, "AVI Track", "AVI" },
                    { 15, "MKV Track", "MKV" },
                    { 16, "MP4 Track", "MP4" },
                    { 17, "FLV Track", "FLV" },
                    { 18, "WMV Track", "WMV" },
                    { 19, "MOV Track", "MOV" },
                    { 20, "MPEG Track", "MPEG" }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "TraineeId", "Birthdate", "Email", "Gender", "IsGraduated", "MobileNo", "Name", "TrackId" },
                values: new object[,]
                {
                    { 1, new DateTime(2015, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmed@gmail.com", 0, true, "01093959322", "ahmed", 1 },
                    { 2, new DateTime(2014, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sara@gmail.com", 1, false, "0123456789", "Sara", 2 },
                    { 3, new DateTime(2013, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali@gmail.com", 0, false, "0111222333", "Ali", 3 },
                    { 4, new DateTime(2012, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma@gmail.com", 1, true, "0101122334", "Fatma", 1 },
                    { 5, new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "omar@gmail.com", 0, false, "0123456789", "Omar", 4 },
                    { 6, new DateTime(2010, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "mona@gmail.com", 1, true, "0109876543", "Mona", 5 },
                    { 7, new DateTime(2009, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "khaled@gmail.com", 0, false, "0112233445", "Khaled", 6 },
                    { 8, new DateTime(2008, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "nadia@gmail.com", 1, false, "0102233445", "Nadia", 7 },
                    { 9, new DateTime(2007, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "hazem@gmail.com", 0, true, "0123456789", "Hazem", 2 },
                    { 10, new DateTime(2006, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dina@gmail.com", 1, false, "0111122334", "Dina", 8 },
                    { 11, new DateTime(2005, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "youssef@gmail.com", 0, true, "0109998887", "Youssef", 9 },
                    { 12, new DateTime(2004, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "nour@gmail.com", 1, false, "0101122334", "Nour", 10 },
                    { 13, new DateTime(2003, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "hamza@gmail.com", 0, false, "0123456789", "Hamza", 11 },
                    { 14, new DateTime(2002, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "salma@gmail.com", 1, true, "0111222333", "Salma", 12 },
                    { 15, new DateTime(2001, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "mohamed@gmail.com", 0, false, "01093959322", "Mohamed", 13 },
                    { 16, new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "sara@gmail.com", 1, true, "0123456789", "Sara", 14 },
                    { 17, new DateTime(1999, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmed@gmail.com", 0, false, "0102233445", "Ahmed", 15 },
                    { 18, new DateTime(1998, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "yasmine@gmail.com", 1, false, "0112233445", "Yasmine", 16 },
                    { 19, new DateTime(1997, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "hassan@gmail.com", 0, true, "0101122334", "Hassan", 17 },
                    { 20, new DateTime(1996, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "dalia@gmail.com", 1, false, "0123456789", "Dalia", 18 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_TrackId",
                table: "Trainees",
                column: "TrackId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trainees");

            migrationBuilder.DropTable(
                name: "Tracks");
        }
    }
}
