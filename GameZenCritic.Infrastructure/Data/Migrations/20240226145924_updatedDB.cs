using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameZenCritic.Infrastructure.Data.Migrations
{
    public partial class updatedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Publisher",
                comment: "The publisher company of the game");

            migrationBuilder.AlterTable(
                name: "PlayersGamesReviews",
                comment: "The reviews from each player for each game including score and details");

            migrationBuilder.AlterTable(
                name: "News",
                comment: "News list including title and description for a game");

            migrationBuilder.AlterTable(
                name: "GenresGames",
                comment: "List of the games and genres, many to many related");

            migrationBuilder.AlterTable(
                name: "Genres",
                comment: "The genre of the game e.g. Action, Adventure etc.");

            migrationBuilder.AlterTable(
                name: "Developer",
                comment: "The developer company of the game");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Publisher",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Name of the publisher company",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Publisher",
                type: "bit",
                nullable: false,
                comment: "Deletion flag",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Publisher",
                type: "int",
                nullable: false,
                comment: "Publisher identifier key",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "PlayersGamesReviews",
                type: "int",
                nullable: false,
                comment: "The score for the game on this review 0-10",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "PlayersGamesReviews",
                type: "bit",
                nullable: false,
                comment: "Deletion flag",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "PlayersGamesReviews",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                comment: "Text info for the review",
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<Guid>(
                name: "GameId",
                table: "PlayersGamesReviews",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Game key/identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "PlayerId",
                table: "PlayersGamesReviews",
                type: "nvarchar(450)",
                nullable: false,
                comment: "Player key/identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Platform",
                type: "bit",
                nullable: false,
                comment: "Deletion flag",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "News",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "Title for the news article",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "News",
                type: "bit",
                nullable: false,
                comment: "Deletion flag",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<Guid>(
                name: "GameId",
                table: "News",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Game key/identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "News",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                comment: "Text description for the news article",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "News",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Identifying key",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "GenresGames",
                type: "bit",
                nullable: false,
                comment: "Deletion flag",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<Guid>(
                name: "GameId",
                table: "GenresGames",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Game key/identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "GenresGames",
                type: "int",
                nullable: false,
                comment: "Genre key/identifier",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Name of the Genre",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Genres",
                type: "bit",
                nullable: false,
                comment: "Deletion flag",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Genres",
                type: "int",
                nullable: false,
                comment: "Identifying key",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "GamesPlatforms",
                type: "bit",
                nullable: false,
                comment: "Deletion flag",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalScore",
                table: "Game",
                type: "decimal(4,2)",
                nullable: false,
                comment: "Average total score of reviews for the game",
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Game",
                type: "datetime2",
                nullable: false,
                comment: "Date of the game initial release",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "Game",
                type: "int",
                nullable: false,
                comment: "The game publisher identifier",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Game",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Link to picture of box art for the game",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Game",
                type: "nvarchar(180)",
                maxLength: 180,
                nullable: false,
                comment: "Name of the game",
                oldClrType: typeof(string),
                oldType: "nvarchar(180)",
                oldMaxLength: 180);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Game",
                type: "bit",
                nullable: false,
                comment: "Deletion flag",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "DeveloperId",
                table: "Game",
                type: "int",
                nullable: false,
                comment: "The game developer identifier",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Game",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Detailed info of the game",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "AgeRatingPicture",
                table: "Game",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Link to picture of age rating for the game",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "AgeRating",
                table: "Game",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Rating for recommended age (usually by ESRB)",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Game",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Identifying key",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Developer",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Name of the company",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Developer",
                type: "bit",
                nullable: false,
                comment: "Deletion flag",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Developer",
                type: "int",
                nullable: false,
                comment: "Identifying key",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395085",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4b86d05-2db4-4a96-aa13-9f5c29cd5416", "AQAAAAEAACcQAAAAEJ7O9kFmyca59lQ1x7gUkjckPzwgcCadNd/Z0FXo0VjXZRhbwkDrAYz/YnLrNAs6JQ==", "6bca43c1-d1a6-473c-8030-9327ab9a9270" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fea12856-c198-4129-b3f3-b893d8395080",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b23d35c-bc4f-41a9-b0f1-d1aecd689368", "cf9602a9-216e-4fa5-9a4c-eb43c6aa9af7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Publisher",
                oldComment: "The publisher company of the game");

            migrationBuilder.AlterTable(
                name: "PlayersGamesReviews",
                oldComment: "The reviews from each player for each game including score and details");

            migrationBuilder.AlterTable(
                name: "News",
                oldComment: "News list including title and description for a game");

            migrationBuilder.AlterTable(
                name: "GenresGames",
                oldComment: "List of the games and genres, many to many related");

            migrationBuilder.AlterTable(
                name: "Genres",
                oldComment: "The genre of the game e.g. Action, Adventure etc.");

            migrationBuilder.AlterTable(
                name: "Developer",
                oldComment: "The developer company of the game");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Publisher",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Name of the publisher company");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Publisher",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Deletion flag");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Publisher",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Publisher identifier key")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "PlayersGamesReviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The score for the game on this review 0-10");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "PlayersGamesReviews",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Deletion flag");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "PlayersGamesReviews",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldComment: "Text info for the review");

            migrationBuilder.AlterColumn<Guid>(
                name: "GameId",
                table: "PlayersGamesReviews",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Game key/identifier");

            migrationBuilder.AlterColumn<string>(
                name: "PlayerId",
                table: "PlayersGamesReviews",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "Player key/identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Platform",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Deletion flag");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "News",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Title for the news article");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "News",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Deletion flag");

            migrationBuilder.AlterColumn<Guid>(
                name: "GameId",
                table: "News",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Game key/identifier");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "News",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldComment: "Text description for the news article");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "News",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Identifying key");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "GenresGames",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Deletion flag");

            migrationBuilder.AlterColumn<Guid>(
                name: "GameId",
                table: "GenresGames",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Game key/identifier");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "GenresGames",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Genre key/identifier");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Name of the Genre");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Genres",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Deletion flag");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Genres",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Identifying key")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "GamesPlatforms",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Deletion flag");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalScore",
                table: "Game",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldComment: "Average total score of reviews for the game");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Game",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Date of the game initial release");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "Game",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The game publisher identifier");

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Game",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Link to picture of box art for the game");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Game",
                type: "nvarchar(180)",
                maxLength: 180,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(180)",
                oldMaxLength: 180,
                oldComment: "Name of the game");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Game",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Deletion flag");

            migrationBuilder.AlterColumn<int>(
                name: "DeveloperId",
                table: "Game",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The game developer identifier");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Game",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Detailed info of the game");

            migrationBuilder.AlterColumn<string>(
                name: "AgeRatingPicture",
                table: "Game",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Link to picture of age rating for the game");

            migrationBuilder.AlterColumn<string>(
                name: "AgeRating",
                table: "Game",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Rating for recommended age (usually by ESRB)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Game",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Identifying key");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Developer",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Name of the company");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Developer",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Deletion flag");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Developer",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Identifying key")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395085",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe6be01e-1747-43fd-88e4-30895ad7f0e3", "AQAAAAEAACcQAAAAENU31P1xv80M/xCmXc671Wu1lnc7DANCCNhLY74JmhZoG/05qUzzgXs483BVVSp/EA==", "f9ff5402-8eec-4561-a776-56f8cef64a06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fea12856-c198-4129-b3f3-b893d8395080",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42983abf-866a-45d3-a895-6035fc38605f", "48fbfb52-6a51-421a-b2c0-59751c4331f2" });
        }
    }
}
