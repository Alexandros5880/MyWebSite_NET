using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebSite.Data.Models;
using MyWebSite.Data.ViewModels;
using MyWebSite.HorizontalClasses.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MessagesController : Controller
    {
        private readonly IRepositoriesHundler _repos;
        private readonly IMapper _mapper;
        private readonly IEmailTool _emailTool;

        public MessagesController(IRepositoriesHundler repos, IMapper mapper, IEmailTool emailTool)
        {
            this._repos = repos;
            this._mapper = mapper;
            this._emailTool = emailTool;
        }

        // GET: Admin/Messages
        public async Task<IActionResult> Index()
        {
            List<MessageViewModel> viewModels = new List<MessageViewModel>();
            foreach (var message in await this._repos.Messages.GetAll())
            {
                viewModels.Add(this._mapper.Map<MessageViewModel>(message));
            }
            return View(viewModels);
        }

        // GET: Admin/Messages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var message = await this._repos.Messages.Get(id);
            if (message == null)
            {
                return NotFound();
            }
            var viewModel = this._mapper.Map<MessageViewModel>(message);
            return View(viewModel);
        }

        // GET: Admin/Messages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Messages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MessageViewModel viewModel)
        {
            var message = this._mapper.Map<Message>(viewModel);
            if (ModelState.IsValid)
            {
                await this ._repos.Messages.Add(message);
                await this._repos.Messages.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(message);
        }

        // GET: Admin/Messages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = await this._repos.Messages.Get(id);
            if (message == null)
            {
                return NotFound();
            }
            var viewModel = this._mapper.Map<MessageViewModel>(message);
            return View(viewModel);
        }

        // POST: Admin/Messages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MessageViewModel viewModel)
        {
            var message = this._mapper.Map<Message>(viewModel);
            if (id != message.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._repos.Messages.Update(message);
                    await this._repos.Messages.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await MessageExists(message.ID))
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
            return View(message);
        }

        // GET: Admin/Messages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var message = await this._repos.Messages.Get(id);
            if (message == null)
            {
                return NotFound();
            }
            var viewModel = this._mapper.Map<MessageViewModel>(message);
            return View(viewModel);
        }

        // POST: Admin/Messages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this._repos.Messages.Delete(id);
            await this._repos.Messages.Save();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> MessageExists(int id)
        {
            return await this._repos.Messages.Get(id) != null;
        }
    }
}
