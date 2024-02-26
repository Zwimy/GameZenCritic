using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameZenCritic.Infrastructure.Data.Migrations
{
    public partial class Seed4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "dea12856-c198-4129-b3f3-b893d8395085", 0, "728b47a4-49d0-4bfd-80f0-816a08b21c28", "Player", "player@mail.com", false, false, null, "player@mail.com", "player@mail.com", "AQAAAAEAACcQAAAAEF31tCK6DjKnRo2j/ldeDzCv2KzO4ekku7roVQcTKYkLG6/VFR2GPYWobhek/e6n+g==", null, false, "af9bf934-6803-4061-8548-a145ed80c444", false, "player@mail.com" },
                    { "fea12856-c198-4129-b3f3-b893d8395080", 0, "71bbf609-10f0-4db5-8ce2-c9e81b29fac8", "Player", "player2@mail.com", false, false, null, "player2@mail.com", "player2@mail.com", null, null, false, "e60b9841-09c5-416b-9d57-6addca9a6c4f", false, "player2@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Developer",
                columns: new[] { "Id", "GameRep", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, 0, false, "Epic Games" },
                    { 2, 0, false, "From Software" },
                    { 3, 0, false, "Larian Studios Games" },
                    { 4, 0, false, "CD Projekt Red Studio" },
                    { 5, 0, false, "SCE Santa Monica" }
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
                    { new Guid("a75f4424-8937-4cb9-baa7-9f37a8f123a6"), "This is the greatest game ever made!", false, new DateTime(2024, 2, 26, 19, 41, 34, 133, DateTimeKind.Local).AddTicks(5718), 10 },
                    { new Guid("b9a4f07e-1d0f-44d1-ba35-8a6e4fe092bd"), "Was an OK shooter, but overhyped.", false, new DateTime(2024, 2, 26, 19, 41, 34, 133, DateTimeKind.Local).AddTicks(5747), 7 }
                });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "Id", "AgeRating", "AgeRatingPicture", "Description", "DeveloperId", "GenreId", "IsDeleted", "Name", "Picture", "PublisherId", "ReleaseDate", "TotalScore" },
                values: new object[,]
                {
                    { new Guid("3e33c5e3-ec4f-4b31-93b0-686fd2da6314"), "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "With the Empire attacking the Kingdoms of the North and the Wild Hunt, a cavalcade of ghastly riders, breathing down your neck, the only way to survive is to fight back. As Geralt of Rivia, a master swordsman and monster hunter, leave none of your enemies standing.", 4, 3, false, "The Witcher 3: Wild Hunt", "https://pre00.deviantart.net/e81c/th/pre/f/2014/157/f/9/witcher_3_box_cover_warner_bros_variation_by_scratcherpen-d7l8i4h.png", 4, new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0m },
                    { new Guid("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"), "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "An ancient evil has returned to Baldur's Gate, intent on devouring it from the inside out. The fate of Faerun lies in your hands. Alone, you may resist. But together, you can overcome.", 3, 3, false, "Baldur's Gate 3", "https://www.metacritic.com/a/img/resize/04973a32611600dace99c3638bd3b8f6a9e09477/catalog/provider/7/2/7-1695438055.jpg", 3, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.3m },
                    { new Guid("a8bf3a6e-509d-497b-92a7-f2c4d0f81b5b"), "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "The freezing winds of Fimbulwinter have come to Midgard, making survival for Kratos, Atreus, and Mimir in the Norse wilds even more challenging than before. ", 5, 4, false, "God of War: Ragnarok", "https://www.metacritic.com/a/img/resize/ca0bc42afe883be3a8bac27a19cf2f972fb07921/catalog/provider/6/3/6-1-905093-13.jpg", 5, new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.1m },
                    { new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "A New World Created By Hidetaka Miyazaki And George R. R. Martin ELDEN RING, developed by FromSoftware, Inc. and BANDAI NAMCO Entertainment Inc.", 2, 4, false, "Elden Ring", "https://www.metacritic.com/a/img/resize/a7d9a5a01234b361785789476e073076a29dad5b/catalog/provider/6/3/6-1-824862-13.jpg", 2, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.5m },
                    { new Guid("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"), "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "Gears of War blends tactical action with survival horror and thrusts gamers into a deep and harrowing story of humankind's epic battle for survival against the Locust Horde, a nightmarish race of creatures that surface from the bowels of the planet.", 1, 1, false, "Gears of War", "https://www.metacritic.com/a/img/resize/c2c2122b8f2a30ff7dacbdf98d3091c0a9f8088c/catalog/provider/6/12/6-1-68349-52.jpg", 1, new DateTime(2006, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8m }
                });

            migrationBuilder.InsertData(
                table: "GamesPlatforms",
                columns: new[] { "GameId", "PlatformId", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"), 1, false },
                    { new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), 1, false },
                    { new Guid("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"), 1, false },
                    { new Guid("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"), 2, false },
                    { new Guid("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"), 3, false },
                    { new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), 3, false },
                    { new Guid("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"), 4, false },
                    { new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), 4, false }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Description", "GameId", "IsDeleted", "PublishDate", "Title" },
                values: new object[] { new Guid("aae47f27-2e4a-4e68-a4f2-0c5e3946b2ab"), "Elden Ring DLC is fast approaching and the new trailer has ignited a fierce online debate about Messmer The Impaler's origins. Messmer The Impaler is supposedly the big bad in the Shadow of the Erdtree expansion, as the Collector's Edition even dedicates a fully detailed figurine to the soon-to-be-boss. But the lore implications around Messmer have split the player base in two, between those who believe he was teased from the very beginning to those who think he's an entirely new creation made for the DLC. Messmer is the figure with several snakes peeking up out of his red robes. Pair that with the all-new landmark trees that are at the center of the new Land of Shadows map, coiled around each other chaotically, and the imagery is clear. Messmer is the Satan stand-in. He's the original sinner against the Erdtree. ", new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), false, new DateTime(2024, 2, 26, 19, 41, 34, 148, DateTimeKind.Local).AddTicks(6577), "DLC incoming" });

            migrationBuilder.InsertData(
                table: "PlayersGamesReviews",
                columns: new[] { "GameId", "PlayerId", "ReviewId", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), "dea12856-c198-4129-b3f3-b893d8395085", new Guid("a75f4424-8937-4cb9-baa7-9f37a8f123a6"), false },
                    { new Guid("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"), "dea12856-c198-4129-b3f3-b893d8395085", new Guid("b9a4f07e-1d0f-44d1-ba35-8a6e4fe092bd"), false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fea12856-c198-4129-b3f3-b893d8395080");

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: new Guid("3e33c5e3-ec4f-4b31-93b0-686fd2da6314"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: new Guid("a8bf3a6e-509d-497b-92a7-f2c4d0f81b5b"));

            migrationBuilder.DeleteData(
                table: "GamesPlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"), 1 });

            migrationBuilder.DeleteData(
                table: "GamesPlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), 1 });

            migrationBuilder.DeleteData(
                table: "GamesPlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"), 1 });

            migrationBuilder.DeleteData(
                table: "GamesPlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"), 2 });

            migrationBuilder.DeleteData(
                table: "GamesPlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"), 3 });

            migrationBuilder.DeleteData(
                table: "GamesPlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), 3 });

            migrationBuilder.DeleteData(
                table: "GamesPlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"), 4 });

            migrationBuilder.DeleteData(
                table: "GamesPlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), 4 });

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("aae47f27-2e4a-4e68-a4f2-0c5e3946b2ab"));

            migrationBuilder.DeleteData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PlayersGamesReviews",
                keyColumns: new[] { "GameId", "PlayerId", "ReviewId" },
                keyValues: new object[] { new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), "dea12856-c198-4129-b3f3-b893d8395085", new Guid("a75f4424-8937-4cb9-baa7-9f37a8f123a6") });

            migrationBuilder.DeleteData(
                table: "PlayersGamesReviews",
                keyColumns: new[] { "GameId", "PlayerId", "ReviewId" },
                keyValues: new object[] { new Guid("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"), "dea12856-c198-4129-b3f3-b893d8395085", new Guid("b9a4f07e-1d0f-44d1-ba35-8a6e4fe092bd") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395085");

            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: new Guid("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: new Guid("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"));

            migrationBuilder.DeleteData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("a75f4424-8937-4cb9-baa7-9f37a8f123a6"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("b9a4f07e-1d0f-44d1-ba35-8a6e4fe092bd"));

            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
