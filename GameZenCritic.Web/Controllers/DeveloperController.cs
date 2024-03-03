using Microsoft.AspNetCore.Mvc;

namespace GameZenCritic.Web.Controllers
{
    public class DeveloperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
