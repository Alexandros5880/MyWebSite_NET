using Microsoft.EntityFrameworkCore;
using MyWebSite.Data.Models;

namespace MyWebSite.Data
{
    public interface IApplicationDbContext
    {
        DbSet<CV> CVs { get; set; }
        DbSet<Image> Images { get; set; }
        DbSet<Message> Messages { get; set; }
        DbSet<Project> Projects { get; set; }
    }
}