using MyWebSite.Areas.Identity.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.Areas.Identity.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        Task<bool> Add(MyWebSiteUser entity, string password);
        Task<MyWebSiteUser> Delete(string id);
        void Dispose();
        Task<MyWebSiteUser> Get(string id);
        Task<ICollection<MyWebSiteUser>> GetAll();
        IQueryable<MyWebSiteUser> GetAllQueryable();
        Task<MyWebSiteUser> Update(MyWebSiteUser entity);
    }
}