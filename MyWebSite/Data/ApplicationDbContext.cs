using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyWebSite.Areas.Identity.Data;
using MyWebSite.Data.Models;

namespace MyWebSite.Data
{
    public class ApplicationDbContext : IdentityDbContext<MyWebSiteUser>, IApplicationDbContext
    {

        public DbSet<CV> CVs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Project> Projects { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Add seed Data
            builder.Entity<CV>().HasData(new CV() { ID = 1, IsActive = true, Description = "My CV", Path = "/CV/CV.pdf" });
        }

    }
}
