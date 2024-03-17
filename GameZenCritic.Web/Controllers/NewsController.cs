using Microsoft.AspNetCore.Mvc;

namespace GameZenCritic.Web.Controllers
{
    public class NewsController : Controller
    {
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
