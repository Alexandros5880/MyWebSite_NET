using Microsoft.EntityFrameworkCore;
using MyWebSite.Data;
using MyWebSite.Data.Models;
using MyWebSite.HorizontalClasses;
using MyWebSite.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.Repositories
{
    public class ImageRepository : IRepository<Image>, IDisposable
    {
        private bool disposedValue;
        private readonly ApplicationDbContext _context;
        private readonly FilesTools _filesTools;

        public ImageRepository(IApplicationDbContext context, FilesTools filesTools)
        {
            this._context = (ApplicationDbContext)context;
            this._filesTools = filesTools;
        }

        public async Task<Image> Add(Image entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.CreatedDate = DateTime.Today;
            await this._context.Images.AddAsync(entity);
            return entity;
        }

        public async Task<Image> Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.Images
                                    .FirstOrDefaultAsync(c => c.ID == id);
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            this._context.Remove(entity);
            return entity;
        }

        public async Task<Image> Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.Images
                                    .Include(i => i.Project)
                                    .FirstOrDefaultAsync(c => c.ID == id);
            return entity;
        }

        public async Task<ICollection<Image>> GetAll()
        {
            return await this._context.Images
                                .Include(i => i.Project)
                                .ToListAsync();
        }

        public IQueryable<Image> GetAllQueryable()
        {
            return this._context.Images;
        }

        public Image Update(Image entity)
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
