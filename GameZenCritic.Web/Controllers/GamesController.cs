using Microsoft.AspNetCore.Mvc;

namespace GameZenCritic.Web.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
