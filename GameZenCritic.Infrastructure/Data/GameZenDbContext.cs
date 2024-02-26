using GameZenCritic.Infrastructure.Data.Models;
using GameZenCritic.Infrastructure.Data.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

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

            builder.Entity<GamePlatform>().HasOne(gp=>gp.Game).WithMany(g=>g.GamesPlatforms).OnDelete(DeleteBehavior.NoAction);
            builder.Entity<GamePlatform>().HasOne(gp=>gp.Platform).WithMany(p=>p.GamesPlatforms).OnDelete(DeleteBehavior.NoAction);

            builder.Entity<GenreGame>().HasOne(gg => gg.Game).WithMany(g => g.GenresGames).OnDelete(DeleteBehavior.NoAction);
            builder.Entity<GenreGame>().HasOne(gg => gg.Genre).WithMany(p => p.GenresGames).OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PlayerGameReview>().HasOne(pgr=>pgr.Game).WithMany(g=>g.PlayersGamesReviews).OnDelete(DeleteBehavior.NoAction);
            builder.Entity<PlayerGameReview>().HasOne(pgr=>pgr.Player).WithMany(g=>g.PlayersGamesReviews).OnDelete(DeleteBehavior.NoAction);

            builder.ApplyConfiguration(new PublisherConfiguration());
            builder.ApplyConfiguration(new PlayerConfiguration());

            base.OnModelCreating(builder);
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
