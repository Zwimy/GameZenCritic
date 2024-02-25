using GameZenCritic.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameZenCritic.Infrastructure.Data
{
    public class GameZenDbContext : IdentityDbContext
    {
        public GameZenDbContext(DbContextOptions<GameZenDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<GamePlatform>().HasKey(gp => new { gp.PlatformId, gp.GameId });
            builder.Entity<GenreGame>().HasKey(gg => new { gg.GenreId, gg.GameId });
            builder.Entity<PlayerGameReview>().HasKey(pgr => new { pgr.PlayerId, pgr.GameId });


        }

        public DbSet<Developer> Developer { get; set; } = null!;
        public DbSet<Game> Game { get; set; } = null!;
        public DbSet<GamePlatform> GamesPlatforms { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<GenreGame> GenresGames { get; set; } = null!;
        public DbSet<News> News { get; set; } = null!;
        public DbSet<Platform> Platform { get; set; } = null!;
        public DbSet<PlayerGameReview> PlayersGamesReviews { get; set; } = null!;
        public DbSet<Publisher> Publisher { get; set; } = null!;
    }
}
