using Microsoft.AspNetCore.Mvc;
using MyWebSite.HorizontalClasses.Interfaces;
using System.Threading.Tasks;

namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositoriesHundler _repos;

        public HomeController(IRepositoriesHundler repos)
        {
            this._repos = repos;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Resume()
        {
            var cv = await this._repos.CVs.GetActive();
            return View(cv);
        }

        public async Task<IActionResult> Portofolio()
        {
            return View();
        }

        public async Task<IActionResult> Contact()
        {
            return View();
        }
    }
}
