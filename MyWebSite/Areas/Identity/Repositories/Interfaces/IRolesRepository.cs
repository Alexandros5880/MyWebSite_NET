using MyWebSite.Areas.Identity.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.Areas.Identity.Repositories.Interfaces
{
    public interface IRolesRepository
    {
        Task Add(MyWebSiteRole entity);
        Task<MyWebSiteRole> Delete(string id);
        void Dispose();
        Task<MyWebSiteRole> Get(string id);
        Task<ICollection<MyWebSiteRole>> GetAll();
        IQueryable<MyWebSiteRole> GetAllQueryable();
        Task<MyWebSiteRole> Update(MyWebSiteRole entity);
    }
}