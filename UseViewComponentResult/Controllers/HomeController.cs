using Microsoft.AspNetCore.Mvc;

namespace UseViewComponentResult.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
