using MyWebSite.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.Repositories.Interface
{
    public interface IProjectRepository
    {
        Task<Project> Add(Project entity);
        Task<Project> Delete(int? id);
        void Dispose();
        Task<Project> Get(int? id);
        Task<ICollection<Project>> GetAll();
        IQueryable<Project> GetAllQueryable();
        Project GetSync(int? id);
        Task Save();
        Task<Project> Update(Project entity);
    }
}