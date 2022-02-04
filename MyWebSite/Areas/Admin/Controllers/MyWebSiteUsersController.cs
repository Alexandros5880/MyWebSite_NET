using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebSite.Areas.Identity.Data;
using MyWebSite.Areas.Identity.Repositories;
using MyWebSite.Areas.Identity.Repositories.Interfaces;
using System.Threading.Tasks;

namespace MyWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MyWebSiteUsersController : Controller
    {
        private readonly UsersRepository _Users;
        private readonly RolesRepository _Roles;

        public MyWebSiteUsersController(IUsersRepository users, IRolesRepository roles)
        {
            this._Users = (UsersRepository)users;
            this._Roles = (RolesRepository)roles;
        }

        // GET: Admin/MyWebSiteUsers
        public async Task<IActionResult> Index()
        {
            return View(await this._Users.GetAll());
        }

        // GET: Admin/MyWebSiteUsers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var myWebSiteUser = await this._Users.Get(id);
            if (myWebSiteUser == null)
            {
                return NotFound();
            }
            return View(myWebSiteUser);
        }

        // GET: Admin/MyWebSiteUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/MyWebSiteUsers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MyWebSiteUser user)
        {
            if (ModelState.IsValid)
            {
                if (user.Password == user.ConfingPassword)
                {
                    await this._Users.Add(user, user.Password);
                    return RedirectToAction(nameof(Index));
                }
                ViewBag.Error = "Enter your password again.";
            }
            return View(user);
        }

        // GET: Admin/MyWebSiteUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var myWebSiteUser = await this._Users.Get(id);
            if (myWebSiteUser == null)
            {
                return NotFound();
            }
            return View(myWebSiteUser);
        }

        // POST: Admin/MyWebSiteUsers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MyWebSiteUser user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await this._Users.Update(user);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MyWebSiteRoleExists(user.Id))
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
            return View(user);
        }

        // GET: Admin/MyWebSiteUsers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var myWebSiteUser = await this._Users.Get(id);
            if (myWebSiteUser == null)
            {
                return NotFound();
            }
            return View(myWebSiteUser);
        }

        // POST: Admin/MyWebSiteUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await this._Users.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool MyWebSiteRoleExists(string id)
        {
            return this._Users.Get(id) != null;
        }
    }
}
