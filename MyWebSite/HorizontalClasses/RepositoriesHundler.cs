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

        public RepositoriesHundler(
            IRepository<CV> cvRepo, 
            IRepository<Image> imgRepo, 
            IRepository<Message> messRepo, 
            IRepository<Project> proRepo)
        {
            this.CVs = (CvRepository)cvRepo;
            this.Images = (ImageRepository)imgRepo;
            this.Messages = (MessageRepository)messRepo;
            this.Projects = (ProjectRepository)proRepo;
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
