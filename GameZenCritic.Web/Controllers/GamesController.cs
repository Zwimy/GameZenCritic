using GameZenCritic.Core.Contracts;
using GameZenCritic.Core.Extensions;
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

        public async Task<IActionResult> All(int page = StartPage)
        {
            var modelBase = await gameService.AllAsync();
            int count = modelBase.Count();

            var paginatedGames = modelBase.OrderBy(g => g.ReleaseDate).Skip((page - StartPage) * PageSize).Take(PageSize);

            var model = new PaginatedList<GameShortInfoViewModel>(paginatedGames, modelBase.Count(), page, PageSize);

            return View(model);
        }
    }
}
