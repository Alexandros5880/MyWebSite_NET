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
    public class UsersRepository : IDisposable, IUsersRepository
    {
        private bool disposedValue;
        private readonly UserManager<MyWebSiteUser> _userManager;
        private readonly ApplicationDbContext _context;

        public UsersRepository(UserManager<MyWebSiteUser> userManager, IApplicationDbContext context)
        {
            this._userManager = userManager;
            this._context = (ApplicationDbContext)context;
        }

        public async Task<bool> Add(MyWebSiteUser entity, string password)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.UserName = entity.Email;
            var result = await this._userManager.CreateAsync(entity, password);
            if (result.Succeeded)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public async Task<MyWebSiteUser> Delete(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var user = await this._userManager.FindByIdAsync(id);
            await this._userManager.DeleteAsync(user);
            await this._context.SaveChangesAsync();
            return user;
        }

        public async Task<MyWebSiteUser> Get(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return await this._userManager.FindByIdAsync(id);
        }

        public async Task<ICollection<MyWebSiteUser>> GetAll()
        {
            return await this._userManager.Users.ToListAsync();
        }

        public IQueryable<MyWebSiteUser> GetAllQueryable()
        {
            return this._userManager.Users;
        }

        public async Task<MyWebSiteUser> Update(MyWebSiteUser entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await this._userManager.UpdateAsync(entity);
            await this._context.SaveChangesAsync();
            return entity;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._userManager.Dispose();
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
