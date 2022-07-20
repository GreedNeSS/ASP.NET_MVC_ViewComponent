using Microsoft.AspNetCore.Mvc;

namespace ViewComponentContext.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
