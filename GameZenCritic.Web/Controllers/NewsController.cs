using GameZenCritic.Core.Contracts;
using GameZenCritic.Core.Models.Game;
using GameZenCritic.Core.Models.News;
using GameZenCritic.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameZenCritic.Web.Controllers
{
    public class NewsController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly INewsService newsService;

        public NewsController(ILogger<HomeController> _logger, INewsService _newsService)
        {
            logger = _logger;
            newsService = _newsService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllNewsQueryViewModel model)
        {
            var news = await newsService.GetAllAsync(
                model.SearchTerm,
                model.Page,
                model.GameId);

            model.TotalCount = news.TotalCount;
            model.TotalPages = news.TotalPages;
            model.News = news.News;

            if (!news.News.Any() || !ModelState.IsValid)
            {
                return BadRequest();
            }

            return View(model);
        }

        public async Task<IActionResult> Article(int id)
        {
            var model = await newsService.GetByNewsIdAsync(id);
            if (!ModelState.IsValid || model == null)
            {
                return BadRequest();
            }
            return View(model);
        }
    }
}
