using GameZenCritic.Core.Constants;
using GameZenCritic.Core.Contracts;
using GameZenCritic.Core.Models.Developer;
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

        [HttpGet]
        public async Task<IActionResult> Details(DeveloperDetailsQueryViewModel model)
        {
            var devInfo = await developerService.GetByIdAsync(model.Id, model.Page);
            if (devInfo == null)
            {
                return BadRequest();
            }
            model.Name = devInfo.Name;
            model.GameRep= devInfo.GameRep;
            model.LogoLink= devInfo.LogoLink;
            model.TotalCount = devInfo.TotalCount;
            model.TotalPages = devInfo.TotalPages;
            model.Games = devInfo.Games;

            return View(model);
        }
    }
}