using GameZenCritic.Core.Contracts;
using GameZenCritic.Core.Models.Game;
using Microsoft.AspNetCore.Mvc;
using static GameZenCritic.Core.Constants.LogicConstants;

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

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllGamesQueryViewModel model)
        {
            //var gameList = await gameService.AllAsync();
            var games = await gameService.AllAsync(
                model.Genre,
                model.SearchTerm,
                model.Page,
                model.ItemsPerPage);

            model.TotalCount = games.TotalCount;
            model.TotalPages = games.TotalPages;
            model.Games = games.Games;
            model.Genres = await gameService.AllGenresNamesAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Game([FromQuery] GameDetailsQueryViewModel model)
        {

            return View(model);
        }
    }
}
