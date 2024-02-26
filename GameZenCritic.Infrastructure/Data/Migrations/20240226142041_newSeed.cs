﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameZenCritic.Infrastructure.Data.Migrations
{
    public partial class newSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "dea12856-c198-4129-b3f3-b893d8395085", 0, "ac54ea67-d2ca-45ad-9279-040b0beb2676", "Player", "player@mail.com", false, false, null, "player@mail.com", "player@mail.com", "AQAAAAEAACcQAAAAEAo5RWB3br/HhXzTFs6QmBTZd5/d2TqFNiBvjqNROL1XMlKJPT8ug243oO9BAAqG4Q==", null, false, "3268723d-62b6-415a-a85e-a08f966d3594", false, "player@mail.com" },
                    { "fea12856-c198-4129-b3f3-b893d8395080", 0, "05f9a610-8a85-4885-b00a-b08f0682a58b", "Player", "player2@mail.com", false, false, null, "player2@mail.com", "player2@mail.com", null, null, false, "18cb07a2-f21b-44d8-8982-f6a56e43e94b", false, "player2@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "Id", "AgeRating", "AgeRatingPicture", "Description", "Developer", "IsDeleted", "Name", "Picture", "ReleaseDate", "TotalScore" },
                values: new object[,]
                {
                    { new Guid("3e33c5e3-ec4f-4b31-93b0-686fd2da6314"), "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "With the Empire attacking the Kingdoms of the North and the Wild Hunt, a cavalcade of ghastly riders, breathing down your neck, the only way to survive is to fight back. As Geralt of Rivia, a master swordsman and monster hunter, leave none of your enemies standing.", "CD Projekt Red Studio", false, "The Witcher 3: Wild Hunt", "https://pre00.deviantart.net/e81c/th/pre/f/2014/157/f/9/witcher_3_box_cover_warner_bros_variation_by_scratcherpen-d7l8i4h.png", new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0m },
                    { new Guid("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"), "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "An ancient evil has returned to Baldur's Gate, intent on devouring it from the inside out. The fate of Faerun lies in your hands. Alone, you may resist. But together, you can overcome.", "Larian Studios Games", false, "Baldur's Gate 3", "https://www.metacritic.com/a/img/resize/04973a32611600dace99c3638bd3b8f6a9e09477/catalog/provider/7/2/7-1695438055.jpg", new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.3m },
                    { new Guid("a8bf3a6e-509d-497b-92a7-f2c4d0f81b5b"), "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "The freezing winds of Fimbulwinter have come to Midgard, making survival for Kratos, Atreus, and Mimir in the Norse wilds even more challenging than before. ", "SCE Santa Monica", false, "God of War: Ragnarok", "https://www.metacritic.com/a/img/resize/ca0bc42afe883be3a8bac27a19cf2f972fb07921/catalog/provider/6/3/6-1-905093-13.jpg", new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.1m },
                    { new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "A New World Created By Hidetaka Miyazaki And George R. R. Martin ELDEN RING, developed by FromSoftware, Inc. and BANDAI NAMCO Entertainment Inc.", "From Software", false, "Elden Ring", "https://www.metacritic.com/a/img/resize/a7d9a5a01234b361785789476e073076a29dad5b/catalog/provider/6/3/6-1-824862-13.jpg", new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.5m },
                    { new Guid("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"), "Rated M for Mature", "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png", "Gears of War blends tactical action with survival horror and thrusts gamers into a deep and harrowing story of humankind's epic battle for survival against the Locust Horde, a nightmarish race of creatures that surface from the bowels of the planet.", "Epic Games", false, "Gears of War", "https://www.metacritic.com/a/img/resize/c2c2122b8f2a30ff7dacbdf98d3091c0a9f8088c/catalog/provider/6/12/6-1-68349-52.jpg", new DateTime(2006, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8m }
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
                table: "GenresGames",
                columns: new[] { "GameId", "GenreId", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"), 1, false },
                    { new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), 2, false },
                    { new Guid("3e33c5e3-ec4f-4b31-93b0-686fd2da6314"), 3, false },
                    { new Guid("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"), 3, false },
                    { new Guid("a8bf3a6e-509d-497b-92a7-f2c4d0f81b5b"), 4, false }
                });

            migrationBuilder.InsertData(
                table: "PlayersGamesReviews",
                columns: new[] { "GameId", "PlayerId", "Details", "IsDeleted", "Score" },
                values: new object[,]
                {
                    { new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), "dea12856-c198-4129-b3f3-b893d8395085", "This is the greatest game ever made!", false, 10 },
                    { new Guid("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"), "dea12856-c198-4129-b3f3-b893d8395085", "Was an OK shooter, but overhyped.", false, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fea12856-c198-4129-b3f3-b893d8395080");

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
                table: "GenresGames",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { new Guid("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"), 1 });

            migrationBuilder.DeleteData(
                table: "GenresGames",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), 2 });

            migrationBuilder.DeleteData(
                table: "GenresGames",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { new Guid("3e33c5e3-ec4f-4b31-93b0-686fd2da6314"), 3 });

            migrationBuilder.DeleteData(
                table: "GenresGames",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { new Guid("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"), 3 });

            migrationBuilder.DeleteData(
                table: "GenresGames",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { new Guid("a8bf3a6e-509d-497b-92a7-f2c4d0f81b5b"), 4 });

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
                keyColumns: new[] { "GameId", "PlayerId" },
                keyValues: new object[] { new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"), "dea12856-c198-4129-b3f3-b893d8395085" });

            migrationBuilder.DeleteData(
                table: "PlayersGamesReviews",
                keyColumns: new[] { "GameId", "PlayerId" },
                keyValues: new object[] { new Guid("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"), "dea12856-c198-4129-b3f3-b893d8395085" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395085");

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: new Guid("3e33c5e3-ec4f-4b31-93b0-686fd2da6314"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: new Guid("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: new Guid("a8bf3a6e-509d-497b-92a7-f2c4d0f81b5b"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: new Guid("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: new Guid("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

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
        }
    }
}
