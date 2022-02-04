using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyWebSite.Areas.Identity.Data;
using MyWebSite.Areas.Identity.Repositories.Interfaces;
using MyWebSite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.Areas.Identity.Repositories
{
    public class RolesRepository : IRepository<MyWebSiteRole>, IDisposable
    {
        private readonly RoleManager<MyWebSiteRole> _roleManager;
        private readonly ApplicationDbContext _context;
        private bool disposedValue;

        public RolesRepository(RoleManager<MyWebSiteRole> roleManager, IApplicationDbContext context)
        {
            this._roleManager = roleManager;
            this._context = (ApplicationDbContext)context;
        }

        public async Task<ICollection<MyWebSiteRole>> GetAll()
        {
            return await this._roleManager.Roles.ToListAsync();
        }

        public IQueryable<MyWebSiteRole> GetAllQueryable()
        {
            return this._roleManager.Roles;
        }

        public async Task<MyWebSiteRole> Get(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return await this._roleManager.FindByIdAsync(id);
        }

        public async Task Add(MyWebSiteRole entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await this._roleManager.CreateAsync(entity);
            await this._context.SaveChangesAsync();
        }

        public async Task<MyWebSiteRole> Update(MyWebSiteRole entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await this._roleManager.UpdateAsync(entity);
            await this._context.SaveChangesAsync();
            return entity;
        }

        public async Task<MyWebSiteRole> Delete(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var role = await this._roleManager.FindByIdAsync(id);
            await this._roleManager.DeleteAsync(role);
            await this._context.SaveChangesAsync();
            return role;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._roleManager.Dispose();
                    this._context.Dispose();
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
