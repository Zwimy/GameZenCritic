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
    /// Entity configuration for GenreGame
    /// </summary>
    internal class GenreGameConfiguration : IEntityTypeConfiguration<GenreGame>
    {
        public void Configure(EntityTypeBuilder<GenreGame> builder)
        {
            var data = new SeedData();

            builder.HasData(data.genresGames);
        }
    }
}
