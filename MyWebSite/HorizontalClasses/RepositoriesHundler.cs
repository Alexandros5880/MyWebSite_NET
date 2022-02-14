using MyWebSite.Areas.Identity.Repositories;
using MyWebSite.Areas.Identity.Repositories.Interfaces;
using MyWebSite.Data.Models;
using MyWebSite.HorizontalClasses.Interfaces;
using MyWebSite.Repositories;
using MyWebSite.Repositories.Interface;
using System;

namespace MyWebSite.HorizontalClasses
{
    public class RepositoriesHundler : IRepositoriesHundler, IDisposable
    {
        private bool disposedValue;

        public CvRepository CVs { get; protected set; }
        public ImageRepository Images { get; protected set; }
        public MessageRepository Messages { get; protected set; }
        public ProjectRepository Projects { get; protected set; }
        public UsersRepository Users { get; protected set; }
        public RolesRepository Roles { get; protected set; }
        public HomeDataRepository HomeData { get; protected set; }
        public ContactDataRepository ContactData { get; protected set; }

        public RepositoriesHundler(
            IRepository<CV> cvRepo, 
            IRepository<Image> imgRepo, 
            IRepository<Message> messRepo,
            IRepository<Project> proRepo,
            IUsersRepository users,
            IRolesRepository roles,
            IRepository<HomeData> homeDataRepo,
            IRepository<ContactData> contactDataRepo
            )
        {
            this.CVs = (CvRepository)cvRepo;
            this.Images = (ImageRepository)imgRepo;
            this.Messages = (MessageRepository)messRepo;
            this.Projects = (ProjectRepository)proRepo;
            this.Users = (UsersRepository)users;
            this.Roles = (RolesRepository)roles;
            this.HomeData = (HomeDataRepository)homeDataRepo;
            this.ContactData = (ContactDataRepository)contactDataRepo;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.CVs.Dispose();
                    this.Images.Dispose();
                    this.Messages.Dispose();
                    this.Projects.Dispose();
                    this.Users.Dispose();
                    this.Roles.Dispose();
                    this.HomeData.Dispose();
                    this.ContactData.Dispose();
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
