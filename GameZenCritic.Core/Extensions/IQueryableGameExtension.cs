using GameZenCritic.Core.Models.Game;
using GameZenCritic.Infrastructure.Data.Models;

namespace System.Linq
{
    public static class IQueryableGameExtension
    {
        public static IQueryable<GameShortInfoViewModel> ProjectToGameServiceModel(this IQueryable<Game> games)
        {
            return games
                .Select(g => new GameShortInfoViewModel()
                {
                    Id = g.Id,
                    Name = g.Name,
                    Picture = g.Picture,
                    TotalScore = g.TotalScore,
                    ReleaseDate = g.ReleaseDate,
                });
        }
    }
}
