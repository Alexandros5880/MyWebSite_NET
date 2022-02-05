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
    public class CvRepository : IRepository<CV>, IDisposable
    {
        private bool disposedValue;
        private readonly ApplicationDbContext _context;

        public CvRepository(IApplicationDbContext context)
        {
            this._context = (ApplicationDbContext)context;
        }

        public async Task<CV> Add(CV entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.CreatedDate = DateTime.Today;
            await this._context.CVs.AddAsync(entity);
            return entity;
        }

        public async Task<CV> Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.CVs
                .FirstOrDefaultAsync(c => c.ID == id);
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            this._context.CVs.Remove(entity);
            return entity;
        }

        public async Task<CV> Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.CVs
                            .FirstOrDefaultAsync(c => c.ID == id);
            return entity;
        }

        public async Task<CV> GetActive()
        {
            var entity = await this._context.CVs
                            .FirstOrDefaultAsync(c => c.IsActive == true);
            return entity;
        }

        public async Task<ICollection<CV>> GetAll()
        {
            return await this._context.CVs.ToListAsync();
        }

        public IQueryable<CV> GetAllQueryable()
        {
            return this._context.CVs;
        }

        public CV Update(CV entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.CreatedDate = DateTime.Today;
            this._context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public async Task DeactivateAll()
        {
            foreach (var cv in this._context.CVs)
            {
                cv.IsActive = false;
                this.Update(cv);
                await this.Save();
            }
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
