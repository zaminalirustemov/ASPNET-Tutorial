using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int number = 25;
            ViewData["Data number"] = -4;
            ViewBag.Number = +4;
            TempData["Temp number"] = 999;

            return View(number);
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
