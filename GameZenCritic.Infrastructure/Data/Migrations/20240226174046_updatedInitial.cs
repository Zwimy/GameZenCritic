using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameZenCritic.Infrastructure.Data.Migrations
{
    public partial class updatedInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Developer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identifying key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the company"),
                    GameRep = table.Column<int>(type: "int", nullable: false, comment: "Rounded down reputation of the game developer for all games"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Deletion flag")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developer", x => x.Id);
                },
                comment: "The developer company of the game");

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identifying key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the Genre"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Deletion flag")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                },
                comment: "The genre of the game e.g. Action, Adventure etc.");

            migrationBuilder.CreateTable(
                name: "Platform",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Platform identifier key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Platform name"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Deletion flag")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platform", x => x.Id);
                },
                comment: "Platform list inclusing identifier and name");

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Publisher identifier key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the publisher company"),
                    CountryLocation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the publisher company"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Deletion flag")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                },
                comment: "The publisher company of the game");

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Review key/identifier"),
                    Details = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, comment: "Text info for the review"),
                    Score = table.Column<int>(type: "int", nullable: false, comment: "The score on this review 0-10"),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "When the review is written"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Deletion flag")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Identifying key"),
                    Name = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false, comment: "Name of the game"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Detailed info of the game"),
                    Picture = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Link to picture of box art for the game"),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the game initial release"),
                    AgeRating = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Rating for recommended age (usually by ESRB)"),
                    AgeRatingPicture = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Link to picture of age rating for the game"),
                    TotalScore = table.Column<decimal>(type: "decimal(4,2)", nullable: false, comment: "Average total score of reviews for the game"),
                    DeveloperId = table.Column<int>(type: "int", nullable: false, comment: "The game developer identifier"),
                    PublisherId = table.Column<int>(type: "int", nullable: false, comment: "The game publisher identifier"),
                    GenreId = table.Column<int>(type: "int", nullable: false, comment: "The game genre identifier"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Deletion flag")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_Developer_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "Developer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Game_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Game_Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Game list including description and various info");

            migrationBuilder.CreateTable(
                name: "GamesPlatforms",
                columns: table => new
                {
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Game key"),
                    PlatformId = table.Column<int>(type: "int", nullable: false, comment: "Platform key"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Deletion flag")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamesPlatforms", x => new { x.PlatformId, x.GameId });
                    table.ForeignKey(
                        name: "FK_GamesPlatforms_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GamesPlatforms_Platform_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platform",
                        principalColumn: "Id");
                },
                comment: "List of the games and platforms, many to many related");

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Identifying key"),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Game key/identifier"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Title for the news article"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Text description for the news article"),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "When the article  is published"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Deletion flag")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "News list including title and description for a game");

            migrationBuilder.CreateTable(
                name: "PlayersGamesReviews",
                columns: table => new
                {
                    ReviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Review key/identifier"),
                    PlayerId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Player key/identifier"),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Game key/identifier"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Deletion flag")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayersGamesReviews", x => new { x.ReviewId, x.PlayerId, x.GameId });
                    table.ForeignKey(
                        name: "FK_PlayersGamesReviews_AspNetUsers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlayersGamesReviews_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlayersGamesReviews_Review_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Review",
                        principalColumn: "Id");
                },
                comment: "The reviews navigational entity from each player for each game");

            migrationBuilder.CreateIndex(
                name: "IX_Game_DeveloperId",
                table: "Game",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_GenreId",
                table: "Game",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_PublisherId",
                table: "Game",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_GamesPlatforms_GameId",
                table: "GamesPlatforms",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_News_GameId",
                table: "News",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersGamesReviews_GameId",
                table: "PlayersGamesReviews",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersGamesReviews_PlayerId",
                table: "PlayersGamesReviews",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GamesPlatforms");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "PlayersGamesReviews");

            migrationBuilder.DropTable(
                name: "Platform");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Developer");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
