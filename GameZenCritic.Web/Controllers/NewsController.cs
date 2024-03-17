using GameZenCritic.Core.Contracts;
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

        public async Task<IActionResult> All()
        {
            
            return View();
        }

        public async Task<IActionResult> Game(int id)
        {
            return View();
        }
    }
}
