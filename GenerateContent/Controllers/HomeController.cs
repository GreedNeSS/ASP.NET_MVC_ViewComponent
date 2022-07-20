using Microsoft.AspNetCore.Mvc;

namespace GenerateContent.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
