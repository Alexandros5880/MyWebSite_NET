using MyWebSite.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.Repositories.Interface
{
    interface IRepository<T> where T : class, IEntity
    {
        Task<ICollection<T>> GetAll();
        IQueryable<T> GetAllQueryable();
        Task<T> Get(int? id);
        Task<T> Add(T entity);
        T Update(T entity);
        Task<T> Delete(int? id);
        Task Save();
    }
}
