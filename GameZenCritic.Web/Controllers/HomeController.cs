using GameZenCritic.Core.Contracts;
using GameZenCritic.Core.Models.Home;
using GameZenCritic.Core.Services;
using GameZenCritic.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GameZenCritic.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGameService gameService;
        private readonly IDeveloperService developerService;

        public HomeController(ILogger<HomeController> logger, IGameService _gameService, IDeveloperService _developerService)
        {
            _logger = logger;
            gameService = _gameService;
            developerService = _developerService;
        }

        public async Task<IActionResult> Index()
        {
            var model = new TopGamesAndDevelopersViewModel();
            model.TopDeveloper = await developerService.GetTopDeveloperInfoAsync();
            model.Games = await gameService.TopGamesInfoAsync();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
