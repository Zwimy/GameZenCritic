using GameZenCritic.Core.Contracts;
using GameZenCritic.Core.Models.Home;
using GameZenCritic.Infrastructure.Data.Common;
using GameZenCritic.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Services
{
    public class GameService : IGameService
    {
        private readonly IRepository repository;

        public GameService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<TopGamesAndDevelopersViewModel> TopGamesInfoAsync()
        {
            var topInfo = new TopGamesAndDevelopersViewModel();

            topInfo.TopDeveloper = await repository.AllReadOnly<Developer>()
                .OrderByDescending(d => d.GameRep)
                .Take(1)
                .Select(d => new Models.Developer.DeveloperInfoViewModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    GameRep = d.GameRep,
                    LogoLink = d.LogoLink,
                })
                .FirstAsync();
                
            topInfo.Games = await repository.AllReadOnly<Game>()
                .OrderByDescending(g=>g.TotalScore)
                .Take(3)
                .Select(g=> new Models.Game.GameShortInfoViewModel()
                {
                    Id=g.Id,
                    Name = g.Name,
                    Picture = g.Picture,
                    TotalScore = g.TotalScore,
                })
                .ToListAsync();

            return topInfo;
        }
    }
}
