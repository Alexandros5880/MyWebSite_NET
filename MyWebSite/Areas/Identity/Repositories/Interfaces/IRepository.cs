using MyWebSite.Areas.Identity.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.Areas.Identity.Repositories.Interfaces
{
    interface IRepository<T> where T : class, IEntity
    {
        Task<ICollection<T>> GetAll();
        IQueryable<T> GetAllQueryable();
        Task<T> Get(string id);
        Task Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(string id);
    }
}
