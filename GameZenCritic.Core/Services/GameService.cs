﻿using GameZenCritic.Core.Contracts;
using GameZenCritic.Core.Models.Home;
using GameZenCritic.Core.Models.Game;
using GameZenCritic.Infrastructure.Data.Common;
using GameZenCritic.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameZenCritic.Core.Constants.LogicConstants;

namespace GameZenCritic.Core.Services
{
    public class GameService : IGameService
    {
        private readonly IRepository repository;
        private readonly IDeveloperService developerService;

        public GameService(IRepository _repository, IDeveloperService _developerService)
        {
            repository = _repository;
            developerService = _developerService;
        }

        // to-do cleanup
        //public async Task<IEnumerable<GameShortInfoViewModel>> AllAsync()
        //{
        //    return await repository.AllReadOnly<Game>()
        //        .OrderByDescending(g => g.ReleaseDate)
        //        .Select(g=> new GameShortInfoViewModel()
        //        {
        //            Id = g.Id,
        //            Name = g.Name,
        //            Picture = g.Picture,
        //            TotalScore = g.TotalScore,
        //            ReleaseDate = g.ReleaseDate,
        //        })
        //        .ToListAsync();
        //}

        public async Task<AllGamesQueryModel> AllAsync(string? genre = null, string? searchTerm = null, int currentPage = 1, int gamesPerPage = 3)
        {
            var gamesToShow = repository.AllReadOnly<Game>();

            if (genre != null)
            {
                gamesToShow = gamesToShow
                    .Where(g => g.Genre.Name == genre);
            }

            if (searchTerm != null)
            {
                string normalizedSearchTerm = searchTerm.ToLower();
                gamesToShow = gamesToShow
                    .Where(g => (g.Name.ToLower().Contains(normalizedSearchTerm) ||
                                g.Publisher.Name.ToLower().Contains(normalizedSearchTerm) ||
                                g.Developer.Name.ToLower().Contains(normalizedSearchTerm) ||
                                g.Description.ToLower().Contains(normalizedSearchTerm)));
            }

            gamesToShow = gamesToShow.OrderByDescending(g => g.ReleaseDate);

            var games = await gamesToShow
                .Skip((currentPage - 1) * gamesPerPage)
                .Take(gamesPerPage)
                .ProjectToGameServiceModel()
                .ToListAsync();

            int totalGames = await gamesToShow.CountAsync();
            int totalPages = (int)Math.Ceiling((decimal)totalGames / (decimal)gamesPerPage);

            return new AllGamesQueryModel()
            {
                Games = games,
                TotalGamesCount = totalGames,
                TotalPages = totalPages
            };
        }

        public async Task<IEnumerable<string>> AllGenresNamesAsync()
        {
            return await repository.AllReadOnly<Genre>()
                .Select(g => g.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<IEnumerable<GameShortInfoViewModel>> ByDevIdAsync(int id)
        {
            return await repository.AllReadOnly<Game>()
                .Where(g => g.DeveloperId == id)
                .OrderByDescending(g => g.ReleaseDate)
                .Select(g => new GameShortInfoViewModel()
                {
                    Id = g.Id,
                    Name = g.Name,
                    Picture = g.Picture,
                    TotalScore = g.TotalScore,
                })
                .ToListAsync();
        }

        public async Task<TopGamesAndDevelopersViewModel> TopGamesInfoAsync()
        {
            var topInfo = new TopGamesAndDevelopersViewModel();

            topInfo.TopDeveloper = await developerService.GetTopDeveloperInfoAsync();

            topInfo.Games = await repository.AllReadOnly<Game>()
                .OrderByDescending(g=>g.TotalScore)
                .Take(3)
                .Select(g=> new GameShortInfoViewModel()
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
