using Microsoft.AspNetCore.Mvc;
using MyWebSite.Data.ViewModels;
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
            var projects = await this._repos.Projects.GetAll();
            return View(projects);
        }

        public async Task<IActionResult> Contact()
        {
            return View();
        }

        public async Task<ActionResult> _Details(int? id)
        {
            if (id == null)
                return BadRequest();
            var project = await this._repos.Projects.Get(id);
            if (project == null)
                return BadRequest();
            return PartialView("_Details", project);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Message(MessageViewModel message)
        {
            if (message == null)
                return BadRequest();
            return View("Index");
        }
    }
}
