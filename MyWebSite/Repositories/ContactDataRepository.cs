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
    public class ContactDataRepository : IRepository<ContactData>, IDisposable
    {
        private bool disposedValue;
        private readonly ApplicationDbContext _context;

        public ContactDataRepository(IApplicationDbContext context)
        {
            this._context = (ApplicationDbContext)context;
        }

        public async Task<ContactData> Add(ContactData entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.CreatedDate = DateTime.Today;
            await this._context.ContactData.AddAsync(entity);
            return entity;
        }

        public async Task<ContactData> Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.ContactData
                            .FirstOrDefaultAsync(c => c.ID == id);
            this._context.ContactData.Remove(entity);
            return entity;
        }

        public async Task<ContactData> Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return await this._context.ContactData
                .FirstOrDefaultAsync(c => c.ID == id);
        }

        public async Task<ContactData> GetActive()
        {
            return await this._context.ContactData
                                .FirstOrDefaultAsync(c => c.IsActive == true);
        }

        public async Task<ICollection<ContactData>> GetAll()
        {
            return await this._context.ContactData
                                        .ToListAsync();
        }

        public IQueryable<ContactData> GetAllQueryable()
        {
            return this._context.ContactData;
        }

        public async Task Save()
        {
            await this._context.SaveChangesAsync();
        }

        public ContactData Update(ContactData entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.CreatedDate = DateTime.Today;
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
