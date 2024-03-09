using GameZenCritic.Core.Constants;
using GameZenCritic.Core.Contracts;
using GameZenCritic.Core.Extensions;
using GameZenCritic.Core.Models.Game;
using Microsoft.AspNetCore.Mvc;
using static GameZenCritic.Core.Constants.LogicConstants;
namespace GameZenCritic.Web.Controllers
{
    public class DeveloperController : Controller
    {
        private readonly IDeveloperService developerService;
        private readonly ILogger<DeveloperController> logger;

        public DeveloperController(ILogger<DeveloperController> _logger,IDeveloperService _developerService)
        {
            logger = _logger;
            developerService = _developerService;
        }

        public async Task <IActionResult> All()
        {
            var model = await developerService.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> Details(int id, int page = StartPage)
        {
            var modelBase = await developerService.GetByIdAsync(id);

            int count = modelBase.Games.Count();

            var paginatedGames = modelBase.Games.OrderBy(g => g.ReleaseDate).Skip((page - StartPage) * PageSize).Take(PageSize);

            modelBase.PaginatedGames = new PaginatedList<GameShortInfoViewModel>(paginatedGames, modelBase.Games.Count(), page, PageSize);

            return View(modelBase);
        }
    }
}