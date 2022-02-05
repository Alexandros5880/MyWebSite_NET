using Microsoft.EntityFrameworkCore;
using MyWebSite.Data;
using MyWebSite.Data.Models;
using MyWebSite.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.Repositories
{
    public class ProjectRepository : IRepository<Project>, IDisposable
    {
        private bool disposedValue;
        private readonly ApplicationDbContext _context;

        public ProjectRepository(IApplicationDbContext context)
        {
            this._context = (ApplicationDbContext)context;
        }

        public async Task<Project> Add(Project entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.CreatedDate = DateTime.Today;
            await this._context.Projects.AddAsync(entity);
            return entity;
        }

        public async Task<Project> Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.Projects
                                    .FirstOrDefaultAsync(p => p.ID == id);
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            this._context.Projects.Remove(entity);
            return entity;

        }

        public async Task<Project> Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.Projects
                                    .Include(p => p.Images)
                                    .FirstOrDefaultAsync(p => p.ID == id);
            return entity;
        }

        public async Task<ICollection<Project>> GetAll()
        {
            return await this._context.Projects
                                    .Include(p => p.Images)
                                    .ToListAsync();
        }

        public IQueryable<Project> GetAllQueryable()
        {
            return this._context.Projects;
        }

        public Project Update(Project entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.CreatedDate = DateTime.Today;
            this._context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public async Task Save()
        {
            await this._context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._context.DisposeAsync();
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
