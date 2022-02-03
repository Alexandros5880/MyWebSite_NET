using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyWebSite.Areas.Identity.Data;
using MyWebSite.Areas.Identity.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.Areas.Identity.Repositories
{
    public class RolesRepository : IRepository<MyWebSiteRole>, IDisposable
    {
        private readonly UserManager<MyWebSiteUser> _userManager;
        private readonly RoleManager<MyWebSiteRole> _roleManager;
        private bool disposedValue;

        public RolesRepository(UserManager<MyWebSiteUser> userManager, RoleManager<MyWebSiteRole> roleManager)
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
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
        }

        public async Task<MyWebSiteRole> Update(MyWebSiteRole entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await this._roleManager.UpdateAsync(entity);
            return entity;
        }

        public async Task<MyWebSiteRole> Delete(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var role = await this._roleManager.FindByIdAsync(id);
            await this._roleManager.DeleteAsync(role);
            return role;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._userManager.Dispose();
                    this._roleManager.Dispose();
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
