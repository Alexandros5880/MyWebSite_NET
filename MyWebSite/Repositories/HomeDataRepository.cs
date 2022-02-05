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
    public class HomeDataRepository : IRepository<HomeData>, IDisposable
    {
        private bool disposedValue;
        private readonly ApplicationDbContext _context;

        public HomeDataRepository(IApplicationDbContext context)
        {
            this._context = (ApplicationDbContext)context;
        }

        public async Task<HomeData> Add(HomeData entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.CreatedDate = DateTime.Today;
            await this._context.HomeData.AddAsync(entity);
            return entity;
        }

        public async Task<HomeData> Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.HomeData
                                        .FirstOrDefaultAsync(e => e.ID == id);
            this._context.HomeData.Remove(entity);
            return entity;
        }

        public async Task<HomeData> Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return await this._context.HomeData
                .FirstOrDefaultAsync(e => e.ID == id);
        }

        public async Task<ICollection<HomeData>> GetAll()
        {
            return await this._context.HomeData
                                .ToListAsync();
        }

        public IQueryable<HomeData> GetAllQueryable()
        {
            return this._context.HomeData;
        }

        public async Task Save()
        {
            await this._context.SaveChangesAsync();
        }

        public HomeData Update(HomeData entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.LastUpdateDate = DateTime.Today;
            this._context.Entry(entity).State = EntityState.Modified;
            return entity;
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
