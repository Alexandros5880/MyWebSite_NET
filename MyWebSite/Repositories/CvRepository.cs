using Microsoft.EntityFrameworkCore;
using MyWebSite.Data;
using MyWebSite.Data.DataTypes;
using MyWebSite.Data.Models;
using MyWebSite.HorizontalClasses;
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
        private readonly FilesTools _filesTools;

        public CvRepository(IApplicationDbContext context, FilesTools filesTools)
        {
            this._context = (ApplicationDbContext)context;
            this._filesTools = filesTools;
        }

        [Obsolete]
        public async Task<CV> Add(CV entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.CreatedDate = DateTime.Now;
            entity.LastUpdateDate = DateTime.Now;
            Paths paths = this._filesTools.CreateFile(entity.File, "CV\\");
            entity.CVFullPath = paths.Absolute;
            entity.CVPath = paths.Path;
            await this._context.CVs.AddAsync(entity);
            if (entity.IsActive == true)
            {
                foreach (var rec in this._context.CVs.Where(r => r.ID != entity.ID))
                {
                    rec.IsActive = false;
                }
            }
            return entity;
        }

        [Obsolete]
        public async Task<CV> Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.CVs
                .FirstOrDefaultAsync(c => c.ID == id);
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            this._filesTools.DeleteFile(entity.CVFullPath);
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

        [Obsolete]
        public CV Update(CV entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.LastUpdateDate = DateTime.Now;
            if (entity.File != null)
            {
                Paths paths = this._filesTools.CreateFile(entity.File, "CV\\");
                if ((paths.Absolute != null) &&
                    (paths.Path != null))
                {
                    entity.CVFullPath = paths.Absolute;
                    entity.CVPath = paths.Path;
                }
            }
            this._context.Entry(entity).State = EntityState.Modified;
            if (entity.IsActive == true)
            {
                foreach (var rec in this._context.CVs.Where(r => r.ID != entity.ID))
                {
                    rec.IsActive = false;
                }
            }
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
