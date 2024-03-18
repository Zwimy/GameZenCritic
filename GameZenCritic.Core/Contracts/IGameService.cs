﻿using GameZenCritic.Core.Models.Game;
using GameZenCritic.Core.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Contracts
{
    public interface IGameService
    {
        Task<AllGamesQueryViewModel> AllAsync(
            string? category = null,
            string? searchTerm = null,
            int currentPage = 1,
            int gamesPerPage = 3);

        Task<IEnumerable<GameShortInfoViewModel>> ByDevIdAsync(int id);
        Task<IEnumerable<GameShortInfoViewModel>> TopGamesInfoAsync();

        Task<IEnumerable<string>> AllGenresNamesAsync();
    }
}
