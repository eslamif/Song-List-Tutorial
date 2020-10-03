using Microsoft.EntityFrameworkCore.Migrations;

namespace SongsListTutorial.Migrations
{
    public partial class AddSongFkToGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GenreID",
                table: "Songs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1,
                column: "GenreID",
                value: "M");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 2,
                column: "GenreID",
                value: "RC");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 3,
                column: "GenreID",
                value: "R");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GenreID",
                table: "Songs",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Genre_GenreID",
                table: "Songs",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Genre_GenreID",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_GenreID",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Songs");
        }
    }
}
