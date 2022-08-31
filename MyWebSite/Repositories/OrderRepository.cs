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
    public class OrderRepository : IRepository<Order>, IDisposable
    {
        private bool disposedValue;
        private readonly ApplicationDbContext _context;

        public OrderRepository(IApplicationDbContext context)
        {
            this._context = (ApplicationDbContext)context;
        }

        public async Task<Order> Add(Order entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.CreatedDate = DateTime.Now;
            entity.LastUpdateDate = DateTime.Now;
            await this._context.Orders.AddAsync(entity);
            return entity;
        }

        public async Task<Order> Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.Orders
                                    .FirstOrDefaultAsync(p => p.ID == id);
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            this._context.Orders.Remove(entity);
            return entity;
        }

        public async Task<Order> Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return await this._context.Orders
                                    .Include( o => o.Project)
                                    .FirstOrDefaultAsync(p => p.ID == id);
        }

        public async Task<ICollection<Order>> GetAll()
        {
            return await this._context.Orders
                                    .Include(o => o.Project)
                                    .ToListAsync();
        }

        public IQueryable<Order> GetAllQueryable()
        {
            return this._context.Orders;
        }

        public async Task Save()
        {
            await this._context.SaveChangesAsync();
        }

        public Order Update(Order entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.LastUpdateDate = DateTime.Now;
            this._context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
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
