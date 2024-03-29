﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebSite.Data.Models;
using MyWebSite.Data.ViewModels;
using MyWebSite.HorizontalClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MyWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CVsController : Controller
    {
        private readonly IRepositoriesHundler _repos;
        private readonly IMapper _mapper;
        private readonly IEmailTool _emailTool;

        public CVsController(IRepositoriesHundler repos, IMapper mapper, IEmailTool emailTool)
        {
            this._repos = repos;
            this._mapper = mapper;
            this._emailTool = emailTool;
        }

        // GET: Admin/CVs
        public async Task<IActionResult> Index()
        {
            List<CvViewModel> viewModels = new List<CvViewModel>();
            foreach (var cV in await this._repos.CVs.GetAll())
            {
                viewModels.Add(this._mapper.Map<CvViewModel>(cV));
            }
            return View(viewModels);
        }

        // GET: Admin/CVs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cV = await this._repos.CVs.Get(id);
            if (cV == null)
            {
                return NotFound();
            }
            var cvViewModel = this._mapper.Map<CvViewModel>(cV);
            return View(cvViewModel);
        }

        // GET: Admin/CVs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/CVs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [System.Obsolete]
        public async Task<IActionResult> Create(CvViewModel cvViewModel, IFormFile file)
        {
            var cV = this._mapper.Map<CV>(cvViewModel);
            if (ModelState.IsValid)
            {
                cV.File = file;
                await this._repos.CVs.Add(cV);
                await this._repos.CVs.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(cV);
        }

        // GET: Admin/CVs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cV = await this._repos.CVs.Get(id);
            if (cV == null)
            {
                return NotFound();
            }
            var cvViewModel = this._mapper.Map<CvViewModel>(cV);
            return View(cvViewModel);
        }

        // POST: Admin/CVs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [System.Obsolete]
        public async Task<IActionResult> Edit(CvViewModel cvViewModel, IFormFile file)
        {
            var cV = this._mapper.Map<CV>(cvViewModel);
            if (ModelState.IsValid)
            {
                try
                {
                    cV.File = file == null ? cV.File  : file;
                    this._repos.CVs.Update(cV);
                    await this._repos.CVs.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await CVExists(cV.ID))
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
            return View(cV);
        }

        // GET: Admin/CVs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cV = await this._repos.CVs.Get(id);
            if (cV == null)
            {
                return NotFound();
            }
            var cvViewModel = this._mapper.Map<CvViewModel>(cV);
            return View(cvViewModel);
        }

        // POST: Admin/CVs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [System.Obsolete]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this._repos.CVs.Delete(id);
            await this._repos.CVs.Save();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> CVExists(int id)
        {
            return await this._repos.CVs.Get(id) != null;
        }
    }
}
