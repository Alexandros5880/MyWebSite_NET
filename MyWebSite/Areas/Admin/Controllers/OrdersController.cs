using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebSite.Data.Models;
using MyWebSite.Data.ViewModels;
using MyWebSite.HorizontalClasses.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersController : Controller
    {
        private readonly IRepositoriesHundler _repos;
        private readonly IMapper _mapper;
        private readonly IEmailTool _emailTool;

        public OrdersController(IRepositoriesHundler repos, IMapper mapper, IEmailTool emailTool)
        {
            this._repos = repos;
            this._mapper = mapper;
            this._emailTool = emailTool;
        }

        // GET: Admin/Orders
        public async Task<IActionResult> Index()
        {
            return View(await this._repos.Orders.GetAll());
        }

        // GET: Admin/Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var order = await this._repos.Orders.Get(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // GET: Admin/Orders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OrderViewModel viewModel)
        {
            var order = this._mapper.Map<Order>(viewModel);
            if (ModelState.IsValid)
            {
                await this._repos.Orders.Add(order);
                await this._repos.Orders.Save();
                // Send Email
                // await this._emailTool.Send("body message", "Subject", "Title", "from email", "from password", "to email");
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: Admin/Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var order = await this._repos.Orders.Get(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Admin/Orders/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(OrderViewModel viewModel)
        {
            var order = this._mapper.Map<Order>(viewModel);
            if (ModelState.IsValid)
            {
                try
                {
                    this._repos.Orders.Update(order);
                    await this._repos.Orders.Save();
                    // Send Email
                    // await this._emailTool.Send("body message", "Subject", "Title", "from email", "from password", "to email");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.ID))
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
            return View(order);
        }

        // GET: Admin/Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var order = await this._repos.Orders.Get(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Admin/Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            await this._repos.Orders.Delete(id);
            await this._repos.Orders.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return this._repos.Orders.GetAllQueryable().Any(e => e.ID == id);
        }
    }
}
