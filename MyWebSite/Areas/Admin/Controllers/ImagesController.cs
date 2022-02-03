using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyWebSite.Data.Models;
using MyWebSite.HorizontalClasses.Interfaces;
using System.Threading.Tasks;

namespace MyWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ImagesController : Controller
    {
        private readonly IRepositoriesHundler _repos;
        private readonly IMapper _mapper;
        private readonly IEmailTool _emailTool;

        public ImagesController(IRepositoriesHundler repos, IMapper mapper, IEmailTool emailTool)
        {
            this._repos = repos;
            this._mapper = mapper;
            this._emailTool = emailTool;
        }

        // GET: Admin/Images
        public async Task<IActionResult> Index()
        {
            return View(await this._repos.Images.GetAll());
        }

        // GET: Admin/Images/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await this._repos.Images.Get(id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        // GET: Admin/Images/Create
        public async Task<IActionResult> Create()
        {
            ViewData["ProjectId"] = new SelectList(await this._repos.Projects.GetAll(), "ID", "Title");
            return View();
        }

        // POST: Admin/Images/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ImagePath,ProjectId")] Image image)
        {
            if (ModelState.IsValid)
            {
                this._repos.Images.Add(image);
                await this._repos.Images.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(await this._repos.Projects.GetAll(), "ID", "Title", image.ProjectId);
            return View(image);
        }

        // GET: Admin/Images/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await this._repos.Images.Get(id);
            if (image == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(await this._repos.Projects.GetAll(), "ID", "Title", image.ProjectId);
            return View(image);
        }

        // POST: Admin/Images/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ImagePath,ProjectId")] Image image)
        {
            if (id != image.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._repos.Images.Update(image);
                    await this._repos.Images.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await ImageExists(image.ID))
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
            ViewData["ProjectId"] = new SelectList(await this._repos.Projects.GetAll(), "ID", "Title", image.ProjectId);
            return View(image);
        }

        // GET: Admin/Images/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await this._repos.Images.Get(id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        // POST: Admin/Images/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this._repos.Images.Delete(id);
            await this._repos.Images.Save();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ImageExists(int id)
        {
            return await this._repos.Images.Get(id) != null;
        }
    }
}
