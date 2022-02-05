using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebSite.Data.Models;
using MyWebSite.HorizontalClasses.Interfaces;
using System.Threading.Tasks;

namespace MyWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ContactDataController : Controller
    {
        private readonly IRepositoriesHundler _repos;
        private readonly IMapper _mapper;

        public ContactDataController(IRepositoriesHundler repos, IMapper mapper)
        {
            this._repos = repos;
            this._mapper = mapper;
        }

        // GET: Admin/ContactData
        public async Task<IActionResult> Index()
        {
            return View(await this._repos.ContactData.GetAll());
        }

        // GET: Admin/ContactData/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contactData = await this._repos.ContactData.Get(id);
            if (contactData == null)
            {
                return NotFound();
            }
            return View(contactData);
        }

        // GET: Admin/ContactData/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ContactData/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContactData contactData)
        {
            if (ModelState.IsValid)
            {
                await this._repos.ContactData.Add(contactData);
                await this._repos.ContactData.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(contactData);
        }

        // GET: Admin/ContactData/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contactData = await this._repos.ContactData.Get(id);
            if (contactData == null)
            {
                return NotFound();
            }
            return View(contactData);
        }

        // POST: Admin/ContactData/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ContactData contactData)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    this._repos.ContactData.Update(contactData);
                    await this._repos.ContactData.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await ContactDataExists(contactData.ID))
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
            return View(contactData);
        }

        // GET: Admin/ContactData/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactData = await this._repos.ContactData.Get(id);
            if (contactData == null)
            {
                return NotFound();
            }
            return View(contactData);
        }

        // POST: Admin/ContactData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this._repos.ContactData.Delete(id);
            await this._repos.ContactData.Save();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ContactDataExists(int id)
        {
            return (await this._repos.ContactData.Get(id)) != null;
        }
    }
}
