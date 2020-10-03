using Microsoft.EntityFrameworkCore.Migrations;

namespace SongsListTutorial.Migrations
{
    public partial class fixGenreName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Genre_GenreID",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Genres_GenreID",
                table: "Songs",
                column: "GenreID",
                principalTable: "Genres",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Genres_GenreID",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Genre_GenreID",
                table: "Songs",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
