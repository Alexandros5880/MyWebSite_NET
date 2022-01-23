using MyWebSite.Repositories;

namespace MyWebSite.HorizontalClasses.Interfaces
{
    public interface IRepositoriesHundler
    {
        CvRepository CVs { get; }
        ImageRepository Images { get; }
        MessageRepository Messages { get; }
        ProjectRepository Projects { get; }
    }
}
