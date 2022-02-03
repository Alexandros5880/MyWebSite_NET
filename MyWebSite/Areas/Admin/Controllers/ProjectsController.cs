﻿using AutoMapper;
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
    public class ProjectsController : Controller
    {
        private readonly IRepositoriesHundler _repos;
        private readonly IMapper _mapper;
        private readonly IEmailTool _emailTool;

        public ProjectsController(IRepositoriesHundler repos, IMapper mapper, IEmailTool emailTool)
        {
            this._repos = repos;
            this._mapper = mapper;
            this._emailTool = emailTool;
        }

        // GET: Admin/Projects
        public async Task<IActionResult> Index()
        {
            List<ProjectViewModel> viewModels = new List<ProjectViewModel>();
            foreach (var project in await this._repos.Projects.GetAll())
            {
                viewModels.Add(this._mapper.Map<ProjectViewModel>(project));
            }
            return View(viewModels);
        }

        // GET: Admin/Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var project = await this._repos.Projects.Get(id);
            if (project == null)
            {
                return NotFound();
            }
            var viewModel = this._mapper.Map<ProjectViewModel>(project);
            return View(viewModel);
        }

        // GET: Admin/Projects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProjectViewModel viewModel)
        {
            var project = this._mapper.Map<Project>(viewModel);
            if (ModelState.IsValid)
            {
                await this ._repos.Projects.Add(project);
                await this._repos.Projects.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        // GET: Admin/Projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var project = await this._repos.Projects.Get(id);
            if (project == null)
            {
                return NotFound();
            }
            var viewModel = this._mapper.Map<ProjectViewModel>(project);
            return View(viewModel);
        }

        // POST: Admin/Projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProjectViewModel viewModel)
        {
            var project = this._mapper.Map<Project>(viewModel);
            if (id != project.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._repos.Projects.Update(project);
                    await this._repos.Projects.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await ProjectExists(project.ID))
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
            return View(project);
        }

        // GET: Admin/Projects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var project = await this._repos.Projects.Get(id);
            if (project == null)
            {
                return NotFound();
            }
            var viewModel = this._mapper.Map<ProjectViewModel>(project);
            return View(viewModel);
        }

        // POST: Admin/Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this._repos.Projects.Delete(id);
            await this._repos.Projects.Save();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ProjectExists(int id)
        {
            return this._repos.Projects.Get(id) != null;
        }
    }
}
