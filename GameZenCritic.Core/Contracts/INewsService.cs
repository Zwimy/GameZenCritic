﻿using GameZenCritic.Core.Models.Developer;
using GameZenCritic.Core.Models.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Contracts
{
    public interface INewsService
    {
        Task<AllNewsQueryViewModel> GetAllAsync(
            string? searchTerm = null,
            int currentPage = 1
            );

        Task<AllNewsQueryViewModel> GetByGameIdAsync(
            int gameId,
            string? searchTerm = null,
            int currentPage = 1
            );

        Task<NewsDetailViewModel> GetByNewsIdAsync(int id);

    }
}