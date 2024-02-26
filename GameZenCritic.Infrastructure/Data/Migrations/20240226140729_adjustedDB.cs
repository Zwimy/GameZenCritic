using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameZenCritic.Infrastructure.Data.Migrations
{
    public partial class adjustedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Developer_DeveloperId",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_Game_Publisher_PublisherId",
                table: "Game");

            migrationBuilder.DropTable(
                name: "Developer");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropIndex(
                name: "IX_Game_DeveloperId",
                table: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Game_PublisherId",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "DeveloperId",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Game");

            migrationBuilder.AlterTable(
                name: "PlayersGamesReviews",
                comment: "The reviews from each player for each game including score and details");

            migrationBuilder.AlterTable(
                name: "GenresGames",
                comment: "List of the games and genres, many to many related");

            migrationBuilder.AlterTable(
                name: "Genres",
                comment: "The genre of the game e.g. Action, Adventure etc.");

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

            migrationBuilder.AddColumn<string>(
                name: "Developer",
                table: "Game",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                comment: "The game developer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Developer",
                table: "Game");

            migrationBuilder.AlterTable(
                name: "PlayersGamesReviews",
                oldComment: "The reviews from each player for each game including score and details");

            migrationBuilder.AlterTable(
                name: "GenresGames",
                oldComment: "List of the games and genres, many to many related");

            migrationBuilder.AlterTable(
                name: "Genres",
                oldComment: "The genre of the game e.g. Action, Adventure etc.");

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

            migrationBuilder.AddColumn<int>(
                name: "DeveloperId",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Developer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Game_DeveloperId",
                table: "Game",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_PublisherId",
                table: "Game",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_News_GameId",
                table: "News",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Developer_DeveloperId",
                table: "Game",
                column: "DeveloperId",
                principalTable: "Developer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Publisher_PublisherId",
                table: "Game",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
