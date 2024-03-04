using GameZenCritic.Core.Contracts;
using GameZenCritic.Core.Models.Developer;
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
    }
}
