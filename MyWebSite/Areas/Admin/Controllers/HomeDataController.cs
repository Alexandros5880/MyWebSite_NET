using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebSite.Data.Models;
using MyWebSite.HorizontalClasses.Interfaces;
using System.Threading.Tasks;

namespace MyWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeDataController : Controller
    {
        private readonly IRepositoriesHundler _repos;
        private readonly IMapper _mapper;

        public HomeDataController(IRepositoriesHundler repos, IMapper mapper)
        {
            this._repos = repos;
            this._mapper = mapper;
        }

        // GET: Admin/HomeData
        public async Task<IActionResult> Index()
        {
            return View(await this._repos.HomeData.GetAll());
        }

        // GET: Admin/HomeData/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var homeData = await this._repos.HomeData.Get(id);
            if (homeData == null)
            {
                return NotFound();
            }
            return View(homeData);
        }

        // GET: Admin/HomeData/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/HomeData/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [System.Obsolete]
        public async Task<IActionResult> Create(HomeData homeData, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                // Get File
                //var files = Request.Form.Files;
                homeData.File = file;
                await this._repos.HomeData.Add(homeData);
                await this._repos.HomeData.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(homeData);
        }

        // GET: Admin/HomeData/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var homeData = await this._repos.HomeData.Get(id);
            if (homeData == null)
            {
                return NotFound();
            }
            return View(homeData);
        }

        // POST: Admin/HomeData/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [System.Obsolete]
        public async Task<IActionResult> Edit(HomeData homeData, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    homeData.File = file;
                    this._repos.HomeData.Update(homeData);
                    await this._repos.HomeData.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await HomeDataExists(homeData.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(homeData);
        }

        // GET: Admin/HomeData/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var homeData = await this._repos.HomeData.Get(id);
            if (homeData == null)
                return NotFound();
            return View(homeData);
        }

        // POST: Admin/HomeData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [System.Obsolete]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this._repos.HomeData.Delete(id);
            await this._repos.HomeData.Save();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> HomeDataExists(int id)
        {
            return (await this._repos.HomeData.Get(id)) != null;
        }
    }
}
