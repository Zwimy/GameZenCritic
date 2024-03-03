using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameZenCritic.Infrastructure.Data.Migrations
{
    public partial class _24marseed : Migration
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
                    LogoLink = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Link to picture of Developer logo"),
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
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Review key/identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identifying key")
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    GameId = table.Column<int>(type: "int", nullable: false, comment: "Game key"),
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
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identifying key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false, comment: "Game key/identifier"),
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
                    ReviewId = table.Column<int>(type: "int", nullable: false, comment: "Review key/identifier"),
                    PlayerId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Player key/identifier"),
                    GameId = table.Column<int>(type: "int", nullable: false, comment: "Game key/identifier"),
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "dea12856-c198-4129-b3f3-b893d8395085", 0, "cb03b33f-fa02-41b5-84ef-eccaa2c576f3", "Player", "player@mail.com", false, false, null, "player@mail.com", "player@mail.com", "AQAAAAEAACcQAAAAEBjNQ+YWA1Wp7/g+nML0e/6N2Lwm36inXR84tbauIVfLqzvR+D2bgOEN0jQZ2U/lOQ==", null, false, "aa357e0f-8f0d-4be2-bc53-e256f0e5f10a", false, "player@mail.com" },
                    { "fea12856-c198-4129-b3f3-b893d8395080", 0, "48667189-ecdc-4f7c-a386-2525fdb4805e", "Player", "player2@mail.com", false, false, null, "player2@mail.com", "player2@mail.com", "AQAAAAEAACcQAAAAEDskwUFo1HR/6snL+JfS9oE1JKWOxx9lCIa4m2I/Z0LRbHD6B5OIMI2Z9rsFGC2yTQ==", null, false, "5e2ab7c1-7303-4ae6-8141-fa2796d35a03", false, "player2@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Developer",
                columns: new[] { "Id", "GameRep", "IsDeleted", "LogoLink", "Name" },
                values: new object[,]
                {
                    { 1, 6, false, "https://logodownload.org/wp-content/uploads/2020/10/epic-games-logo-0.png", "Epic Games" },
                    { 2, 6, false, "https://gamingbolt.com/wp-content/uploads/2019/12/FromSoftware-logo.jpg", "From Software" },
                    { 3, 8, false, "https://www.gematsu.com/wp-content/uploads/2022/11/Company-Logo_Larian-Studios-320x456.png", "Larian Studios Games" },
                    { 4, 7, false, "https://www.kitguru.net/wp-content/uploads/2016/03/cd-projekt-red-logo.png", "CD Projekt Red Studio" },
                    { 5, 7, false, "https://i.pinimg.com/564x/1e/5f/3d/1e5f3df1ca42e4719c459ac0792c6d53.jpg", "SCE Santa Monica" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Third Person Shooter" },
                    { 2, false, "Action RPG" },
                    { 3, false, "Western RPG" },
                    { 4, false, "Action Adventure" }
                });

            migrationBuilder.InsertData(
                table: "Platform",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "PC" },
                    { 2, false, "Xbox 360" },
                    { 3, false, "PlayStation 5" },
                    { 4, false, "Xbox Series X" },
                    { 5, false, "PlayStation 4" },
                    { 6, false, "Xbox One" },
                    { 7, false, "Nintendo Switch" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "CountryLocation", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "USA", false, "Microsoft Game Studios" },
                    { 2, "Japan", false, "Bandai Namco Games" },
                    { 3, "Netherlands", false, "Larian Studios Gamess" },
                    { 4, "Poland", false, "CD Projekt Red Studio" },
                    { 5, "USA", false, "PlayStation Studios" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Details", "IsDeleted", "PublishDate", "Score" },
                values: new object[,]
                {
                    { 1, "This is the greatest game ever made!", false, new DateTime(2024, 3, 3, 14, 39, 20, 823, DateTimeKind.Local).AddTicks(8937), 10 },
                    { 2, "Was an OK shooter, but overhyped.", false, new DateTime(2024, 3, 3, 14, 39, 20, 823, DateTimeKind.Local).AddTicks(8963), 7 }
                });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "Id", "AgeRating", "AgeRatingPicture", "Description", "DeveloperId", "GenreId", "IsDeleted", "Name", "Picture", "PublisherId", "ReleaseDate", "TotalScore" },
                values: new object[,]
                {
                    { 1, "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "Gears of War blends tactical action with survival horror and thrusts gamers into a deep and harrowing story of humankind's epic battle for survival against the Locust Horde, a nightmarish race of creatures that surface from the bowels of the planet.", 1, 1, false, "Gears of War", "https://twinfinite.net/wp-content/uploads/2023/01/Best-Xbox-360-Co-Op-Games.png?resize=1000%2C600", 1, new DateTime(2006, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8m },
                    { 2, "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "A New World Created By Hidetaka Miyazaki And George R. R. Martin ELDEN RING, developed by FromSoftware, Inc. and BANDAI NAMCO Entertainment Inc.", 2, 4, false, "Elden Ring", "https://th.bing.com/th/id/OIF.pwBY1yiS46uxscEVyfb5HQ?rs=1&pid=ImgDetMain", 2, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.5m },
                    { 3, "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "An ancient evil has returned to Baldur's Gate, intent on devouring it from the inside out. The fate of Faerun lies in your hands. Alone, you may resist. But together, you can overcome.", 3, 3, false, "Baldur's Gate 3", "https://mcdn.wallpapersafari.com/medium/59/58/Bh5wWX.jpg", 3, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.3m },
                    { 4, "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "With the Empire attacking the Kingdoms of the North and the Wild Hunt, a cavalcade of ghastly riders, breathing down your neck, the only way to survive is to fight back. As Geralt of Rivia, a master swordsman and monster hunter, leave none of your enemies standing.", 4, 3, false, "The Witcher 3: Wild Hunt", "https://th.bing.com/th/id/OIP.ESLUrniRRUtzAk-LMGNjAAHaEK?pid=ImgDet&w=320&h=180&c=7", 4, new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0m },
                    { 5, "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "The freezing winds of Fimbulwinter have come to Midgard, making survival for Kratos, Atreus, and Mimir in the Norse wilds even more challenging than before. ", 5, 4, false, "God of War: Ragnarok", "https://th.bing.com/th/id/OIP.jcAkvpdxr_5gQW0dm6_7VQHaJH?pid=ImgDet&w=146.25&h=180&c=7", 5, new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.1m }
                });

            migrationBuilder.InsertData(
                table: "GamesPlatforms",
                columns: new[] { "GameId", "PlatformId", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, false },
                    { 2, 1, false },
                    { 4, 1, false },
                    { 1, 2, false },
                    { 2, 3, false },
                    { 5, 3, false },
                    { 3, 4, false },
                    { 5, 4, false }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Description", "GameId", "IsDeleted", "PublishDate", "Title" },
                values: new object[] { 1, "Elden Ring DLC is fast approaching and the new trailer has ignited a fierce online debate about Messmer The Impaler's origins. Messmer The Impaler is supposedly the big bad in the Shadow of the Erdtree expansion, as the Collector's Edition even dedicates a fully detailed figurine to the soon-to-be-boss. But the lore implications around Messmer have split the player base in two, between those who believe he was teased from the very beginning to those who think he's an entirely new creation made for the DLC. Messmer is the figure with several snakes peeking up out of his red robes. Pair that with the all-new landmark trees that are at the center of the new Land of Shadows map, coiled around each other chaotically, and the imagery is clear. Messmer is the Satan stand-in. He's the original sinner against the Erdtree. ", 2, false, new DateTime(2024, 3, 3, 14, 39, 20, 838, DateTimeKind.Local).AddTicks(7920), "DLC incoming" });

            migrationBuilder.InsertData(
                table: "PlayersGamesReviews",
                columns: new[] { "GameId", "PlayerId", "ReviewId", "IsDeleted" },
                values: new object[,]
                {
                    { 2, "dea12856-c198-4129-b3f3-b893d8395085", 1, false },
                    { 1, "dea12856-c198-4129-b3f3-b893d8395085", 2, false }
                });

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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fea12856-c198-4129-b3f3-b893d8395080");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395085");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
