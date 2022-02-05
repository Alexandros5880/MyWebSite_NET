using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebSite.Areas.Identity.Data;
using MyWebSite.Areas.Identity.Repositories;
using MyWebSite.Areas.Identity.Repositories.Interfaces;
using System.Threading.Tasks;

namespace MyWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MyWebSiteRolesController : Controller
    {
        private readonly RolesRepository _Roles;
        private readonly UsersRepository _Users;

        public MyWebSiteRolesController(IUsersRepository users, IRolesRepository roles)
        {
            this._Roles = (RolesRepository)roles;
            this._Users = (UsersRepository)users;
    }

        // GET: Admin/MyWebSiteRoles
        public async Task<IActionResult> Index()
        {
            return View(await this._Roles.GetAll());
        }

        // GET: Admin/MyWebSiteRoles/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var myWebSiteRole = await this._Roles.Get(id);
            if (myWebSiteRole == null)
            {
                return NotFound();
            }
            return View(myWebSiteRole);
        }

        // GET: Admin/MyWebSiteRoles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/MyWebSiteRoles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MyWebSiteRole myWebSiteRole)
        {
            if (ModelState.IsValid)
            {
                await this._Roles.Add(myWebSiteRole);
                return RedirectToAction(nameof(Index));
            }
            return View(myWebSiteRole);
        }

        // GET: Admin/MyWebSiteRoles/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var myWebSiteRole = await this._Roles.Get(id);
            if (myWebSiteRole == null)
            {
                return NotFound();
            }
            return View(myWebSiteRole);
        }

        // POST: Admin/MyWebSiteRoles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MyWebSiteRole myWebSiteRole)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await this._Roles.Update(myWebSiteRole);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await MyWebSiteRoleExists(myWebSiteRole.Id))
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
            return View(myWebSiteRole);
        }

        // GET: Admin/MyWebSiteRoles/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var myWebSiteRole = await this._Roles.Get(id);
            if (myWebSiteRole == null)
            {
                return NotFound();
            }
            return View(myWebSiteRole);
        }

        // POST: Admin/MyWebSiteRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await this._Roles.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> MyWebSiteRoleExists(string id)
        {
            return (await this._Roles.Get(id)) != null;
        }
    }
}
