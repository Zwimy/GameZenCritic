using Microsoft.AspNetCore.Mvc;

namespace GameZenCritic.Web.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
