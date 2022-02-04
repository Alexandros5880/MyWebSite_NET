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
        private readonly RoleManager<MyWebSiteRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public UsersRepository(UserManager<MyWebSiteUser> userManager, RoleManager<MyWebSiteRole> roleManager, IApplicationDbContext context)
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
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
            
            var user = await this._context.Users.FirstOrDefaultAsync(u => u.Id.Equals(entity.Id));
            user.Email = entity.Email;
            user.UserName = entity.Email;
            user.PasswordHash = entity.PasswordHash;
            user.EmailConfirmed = true;
            user.PhoneNumberConfirmed = true;

            this._context.Users.Attach(user);
            this._context.Entry(user).State = EntityState.Modified;
            await this._context.SaveChangesAsync();
            return entity;
        }

        public async Task AddToRole(MyWebSiteUser user, MyWebSiteRole role)
        {
            //await this._userManager.AddToRoleAsync(user, role.Name);
            IdentityUserRole<string> userRole = new IdentityUserRole<string>()
            {
                UserId = user.Id,
                RoleId = role.Id
            };
            await this._context.UserRoles.AddAsync(userRole);
            await this._context.SaveChangesAsync();
        }

        public async Task RemoveFromRole(MyWebSiteUser user, MyWebSiteRole role)
        {
            //await this._userManager.RemoveFromRoleAsync(user, role.Name);
            IdentityUserRole<string> userRole = await this._context.UserRoles
                .FirstOrDefaultAsync(r => r.RoleId.Equals(role.Id) && r.UserId.Equals(user.Id));
            this._context.UserRoles.Remove(userRole);
            await this._context.SaveChangesAsync();
        }

        public async Task<ICollection<MyWebSiteRole>> GetRoles(MyWebSiteUser user)
        {
            var rolesNames = await this._userManager.GetRolesAsync(user);
            return await this._roleManager.Roles
                                            .Where(r => rolesNames.Contains(r.Name))
                                            .ToListAsync();
        }

        public async Task<IEnumerable<MyWebSiteRole>> GetOtherRoles(MyWebSiteUser user)
        {
            var userRoles = await this.GetRoles(user);
            var usersRolesIds = userRoles.Select(r => r.Id);
            this._context.Attach(user);
            return await this._roleManager.Roles
                                            .Where(r => !usersRolesIds.Contains(r.Id))
                                            .ToListAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._userManager.Dispose();
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
