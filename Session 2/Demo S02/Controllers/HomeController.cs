using Microsoft.AspNetCore.Mvc;

namespace Demo_S02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Contactus()
        {
            return View();
        }
    }
}
