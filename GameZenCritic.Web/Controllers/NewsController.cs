using Microsoft.AspNetCore.Mvc;

namespace GameZenCritic.Web.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
