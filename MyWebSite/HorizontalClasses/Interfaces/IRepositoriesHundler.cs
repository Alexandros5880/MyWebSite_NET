using MyWebSite.Areas.Identity.Repositories;
using MyWebSite.Repositories;

namespace MyWebSite.HorizontalClasses.Interfaces
{
    public interface IRepositoriesHundler
    {
        CvRepository CVs { get; }
        ImageRepository Images { get; }
        MessageRepository Messages { get; }
        ProjectRepository Projects { get; }
        UsersRepository Users { get; }
        RolesRepository Roles { get; }
        HomeDataRepository HomeData { get; }
        ContactDataRepository ContactData { get; }
        OrderRepository Orders { get; }
    }
}
