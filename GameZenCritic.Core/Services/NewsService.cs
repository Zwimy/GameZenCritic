using GameZenCritic.Core.Contracts;
using GameZenCritic.Core.Models.News;
using GameZenCritic.Infrastructure.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Services
{
    public class NewsService : INewsService
    {
        private readonly IRepository repository;

        public NewsService(IRepository _repository)
        {
            repository = _repository;
        }

        public Task<AllNewsQueryViewModel> GetAllAsync(string? searchTerm = null, int currentPage = 1)
        {
            throw new NotImplementedException();
        }

        public Task<AllNewsQueryViewModel> GetByGameIdAsync(int gameId, string? searchTerm = null, int currentPage = 1)
        {
            throw new NotImplementedException();
        }

        public Task<NewsDetailViewModel> GetByNewsIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
