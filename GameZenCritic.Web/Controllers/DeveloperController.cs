using GameZenCritic.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

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

        public async Task<IActionResult> Details()
        {
            return View();
        }
    }
}