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
    public class MessageRepository : IRepository<Message>, IDisposable
    {
        private bool disposedValue;
        private readonly ApplicationDbContext _context;

        public MessageRepository(IApplicationDbContext context)
        {
            this._context = (ApplicationDbContext)context;
        }

        public async Task<Message> Add(Message entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await this._context.Messages.AddAsync(entity);
            return entity;
        }

        public async Task<Message> Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.Messages
                                    .FirstOrDefaultAsync(m => m.ID == id);
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            this._context.Messages.Remove(entity);
            return entity;
        }

        public async Task<Message> Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.Messages
                                    .FirstOrDefaultAsync(m => m.ID == id);
            return entity;
        }

        public async Task<ICollection<Message>> GetAll()
        {
            return await this._context.Messages
                                    .ToListAsync();
        }

        public IQueryable<Message> GetAllQueryable()
        {
            return this._context.Messages;
        }

        public Message Update(Message entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.LastUpdateDate = DateTime.Now;
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
