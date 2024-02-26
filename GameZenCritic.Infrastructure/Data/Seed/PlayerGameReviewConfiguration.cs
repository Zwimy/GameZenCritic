using GameZenCritic.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Infrastructure.Data.Seed
{
    /// <summary>
    /// Entity configuration for PlayerGameReview
    /// </summary>
    internal class PlayerGameReviewConfiguration : IEntityTypeConfiguration<PlayerGameReview>
    {
        public void Configure(EntityTypeBuilder<PlayerGameReview> builder)
        {
            var data = new SeedData();

            builder.HasData(data.playersGamesReviews);
        }
    }
}
