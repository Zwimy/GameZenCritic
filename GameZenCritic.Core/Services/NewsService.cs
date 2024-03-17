using GameZenCritic.Core.Contracts;
using GameZenCritic.Core.Models.Game;
using GameZenCritic.Core.Models.News;
using GameZenCritic.Infrastructure.Data.Common;
using GameZenCritic.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
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

        public async Task<AllNewsQueryViewModel> GetAllAsync(string? searchTerm = null, int currentPage = 1, int? gameId = null)
        {
            var newsToShow = repository.AllReadOnly<News>();
            var model = new AllNewsQueryViewModel();

            if (searchTerm != null)
            {
                string normalizedSearchTerm = searchTerm.ToLower();
                newsToShow = newsToShow
                    .Where(n => (n.Title.ToLower().Contains(normalizedSearchTerm) ||
                                n.Description.ToLower().Contains(normalizedSearchTerm) ||
                                n.Game.Name.ToLower().Contains(normalizedSearchTerm) ||
                                n.Game.Description.ToLower().Contains(normalizedSearchTerm)));
            }

            if (gameId != null)
            {
                newsToShow = newsToShow
                    .Where(n => n.GameId == gameId);
            }

            newsToShow = newsToShow.OrderByDescending(g => g.PublishDate);

            var news = await newsToShow
                .Skip((currentPage - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .ProjectToNewsServiceModel()
                .ToListAsync();

            int totalNews = await newsToShow.CountAsync();
            int totalPages = (int)Math.Ceiling((decimal)totalNews / (decimal)model.ItemsPerPage);

            model.News = news;
            model.TotalCount = totalNews;
            model.TotalPages = totalPages;

            return model;
        }

        public async Task<NewsDetailViewModel?> GetByNewsIdAsync(int id)
        {
            var article = await repository.AllReadOnly<News>()
                .Select(n=> new NewsDetailViewModel()
                {
                    Id = n.Id,
                    Title = n.Title,
                    Description = n.Description,
                    GameId = n.GameId,
                    GameName = n.Game.Name,
                    PublishDate = n.PublishDate,
                })
                .FirstOrDefaultAsync(n=>n.Id == id);

            if (article == null)
            {
                return null;
            }

            return article;
        }
    }
}
