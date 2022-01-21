using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Portofolio()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
