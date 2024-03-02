using Microsoft.AspNetCore.Mvc;

namespace GameZenCritic.Web.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
