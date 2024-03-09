using GameZenCritic.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace GameZenCritic.Web.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameService gameService;
        private readonly ILogger<GamesController> logger;

        public GamesController(ILogger<GamesController> _logger, IGameService _gameService)
        {
            logger = _logger;
            gameService = _gameService;
        }

        public IActionResult All()
        {
            return View();
        }
    }
}
