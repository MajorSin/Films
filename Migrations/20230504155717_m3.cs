using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "PosterTable",
                newName: "FilmId");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "BannerTable",
                newName: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_PosterTable_FilmId",
                table: "PosterTable",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_BannerTable_FilmId",
                table: "BannerTable",
                column: "FilmId");

            migrationBuilder.AddForeignKey(
                name: "FK_BannerTable_FilmsTable_FilmId",
                table: "BannerTable",
                column: "FilmId",
                principalTable: "FilmsTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PosterTable_FilmsTable_FilmId",
                table: "PosterTable",
                column: "FilmId",
                principalTable: "FilmsTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BannerTable_FilmsTable_FilmId",
                table: "BannerTable");

            migrationBuilder.DropForeignKey(
                name: "FK_PosterTable_FilmsTable_FilmId",
                table: "PosterTable");

            migrationBuilder.DropIndex(
                name: "IX_PosterTable_FilmId",
                table: "PosterTable");

            migrationBuilder.DropIndex(
                name: "IX_BannerTable_FilmId",
                table: "BannerTable");

            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "PosterTable",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "BannerTable",
                newName: "MovieId");
        }
    }
}
