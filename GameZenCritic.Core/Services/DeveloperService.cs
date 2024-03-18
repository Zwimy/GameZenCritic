using GameZenCritic.Core.Contracts;
using GameZenCritic.Core.Models.Developer;
using GameZenCritic.Core.Models.Game;
using GameZenCritic.Infrastructure.Data.Common;
using GameZenCritic.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using static GameZenCritic.Core.Constants.LogicConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameZenCritic.Core.Services
{
    public class DeveloperService : IDeveloperService
    {
        private readonly IRepository repository;

        public DeveloperService(IRepository _repository)
        {
            repository = _repository;
        }



        public async Task<DeveloperInfoViewModel> GetTopDeveloperInfoAsync()
        {
            return await repository.AllReadOnly<Developer>()
                .OrderByDescending(d => d.GameRep)
                .Select(d => new DeveloperInfoViewModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    GameRep = d.GameRep,
                    LogoLink = d.LogoLink,
                })
                .FirstAsync(); 
        }

        public async Task<IEnumerable<DeveloperInfoViewModel>> GetAllAsync()
        {
            return await repository.AllReadOnly<Developer>()
                .OrderByDescending(d => d.GameRep)
                .Select(d => new DeveloperInfoViewModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    GameRep = d.GameRep,
                    LogoLink = d.LogoLink,
                })
                .ToListAsync();
        }

        public async Task<DeveloperDetailsQueryViewModel?> GetByIdAsync(int id, int page)
        {
            var devInfo =  await repository.AllReadOnly<Developer>()
                .Where(d => d.Id == id)
                .Select(d => new DeveloperDetailsQueryViewModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    GameRep = d.GameRep,
                    LogoLink = d.LogoLink,
                })
                .FirstOrDefaultAsync();

            if (devInfo == null)
            {
                return null;
            }

            var gamesToShow = repository.AllReadOnly<Game>()
                .Where(g => g.DeveloperId == id);
;

            var games = await gamesToShow
                .Skip((page - PageNext) * devInfo.ItemsPerPage)
                .Take(devInfo.ItemsPerPage)
                .OrderByDescending(g => g.ReleaseDate)
                .ProjectToGameServiceModel()
                .ToListAsync();

            int totalGames = await gamesToShow.CountAsync();
            int totalPages = (int)Math.Ceiling((decimal)totalGames / (decimal)devInfo.ItemsPerPage);

            devInfo.Games = games;
            devInfo.TotalPages = totalPages;
            devInfo.TotalCount = totalGames;

            return devInfo;
        }
    }
}
