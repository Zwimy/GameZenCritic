﻿using GameZenCritic.Infrastructure.Data.Models;
using GameZenCritic.Infrastructure.Data.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace GameZenCritic.Infrastructure.Data
{
    /// <summary>
    /// Database context setup for the project
    /// </summary>
    public class GameZenDbContext : IdentityDbContext
    {
        public GameZenDbContext(DbContextOptions<GameZenDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<GamePlatform>().HasKey(gp => new { gp.PlatformId, gp.GameId });
            builder.Entity<PlayerGameReview>().HasKey(pgr => new { pgr.ReviewId, pgr.PlayerId, pgr.GameId });

            builder.Entity<GamePlatform>().HasOne(gp=>gp.Game).WithMany(g=>g.GamesPlatforms).OnDelete(DeleteBehavior.NoAction);
            builder.Entity<GamePlatform>().HasOne(gp=>gp.Platform).WithMany(p=>p.GamesPlatforms).OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PlayerGameReview>().HasOne(pgr=>pgr.Game).WithMany(g=>g.PlayersGamesReviews).OnDelete(DeleteBehavior.NoAction);
            builder.Entity<PlayerGameReview>().HasOne(pgr=>pgr.Player).WithMany(g=>g.PlayersGamesReviews).OnDelete(DeleteBehavior.NoAction);
            builder.Entity<PlayerGameReview>().HasOne(pgr=>pgr.Review).WithMany(r=>r.PlayersGamesReviews).OnDelete(DeleteBehavior.NoAction);

            builder.ApplyConfiguration(new ReviewConfiguration());
            builder.ApplyConfiguration(new PublisherConfiguration());
            builder.ApplyConfiguration(new PlayerConfiguration());
            builder.ApplyConfiguration(new PlatformConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
            builder.ApplyConfiguration(new DeveloperConfiguration());
            builder.ApplyConfiguration(new GameConfiguration());
            builder.ApplyConfiguration(new GamePlatformConfiguration());
            builder.ApplyConfiguration(new NewsConfiguration());
            builder.ApplyConfiguration(new PlayerGameReviewConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Developer> Developer { get; set; } = null!;
        public DbSet<Game> Game { get; set; } = null!;
        public DbSet<GamePlatform> GamesPlatforms { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<News> News { get; set; } = null!;
        public DbSet<Platform> Platform { get; set; } = null!;
        public DbSet<PlayerGameReview> PlayersGamesReviews { get; set; } = null!;
        public DbSet<Publisher> Publisher { get; set; } = null!;
    }
}
