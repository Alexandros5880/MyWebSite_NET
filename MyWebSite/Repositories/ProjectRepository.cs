using Microsoft.EntityFrameworkCore;
using MyWebSite.Data;
using MyWebSite.Data.Models;
using MyWebSite.HorizontalClasses;
using MyWebSite.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.Repositories
{
    public class ProjectRepository : IRepository<Project>, IDisposable
    {
        private bool disposedValue;
        private readonly ApplicationDbContext _context;
        private readonly FilesTools _filesTools;

        public ProjectRepository(IApplicationDbContext context, FilesTools filesTools)
        {
            this._context = (ApplicationDbContext)context;
            this._filesTools = filesTools;
        }

        [Obsolete]
        public async Task<Project> Add(Project entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.CreatedDate = DateTime.Today;
            await this.AddImages(entity);
            await this._context.Projects.AddAsync(entity);
            return entity;
        }

        [Obsolete]
        public async Task AddImages(Project project)
        {
            if (project == null)
                throw new ArgumentNullException(nameof(project));
            if (project.Files.Length == 0)
                throw new ArgumentException(nameof(project.Files));
            foreach (var file in project.Files)
            {
                var image = new Image()
                {
                    Project = project,
                    CreatedDate = DateTime.Today,
                    LastUpdateDate = DateTime.Today
                };
                var subPath = $"img\\projects\\{project.Title}\\";
                var paths = this._filesTools.CreateFile(file, subPath);
                image.ImageFullPath = paths.Absolute;
                image.ImagePath = paths.Path;
                await this._context.Images.AddAsync(image);
                //await this.Save();
            }
        }

        [Obsolete]
        public async Task<Project> Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.Projects
                                    .FirstOrDefaultAsync(p => p.ID == id);
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await this.RemoveImages(entity);
            this._context.Projects.Remove(entity);
            return entity;

        }

        [Obsolete]
        public async Task RemoveImages(Project project)
        {
            if (project == null)
                throw new ArgumentNullException(nameof(project));
            project = await this.Get(project.ID);
            string path = "";
            foreach (var image in project.Images)
            {
                this._filesTools.DeleteFile(image.ImageFullPath);
                path = this._filesTools.GetDir(image.ImagePath);
            }
            this._filesTools.DeleteDir(path);
        }

        public async Task<Project> Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.Projects
                                    .Include(p => p.Images)
                                    .FirstOrDefaultAsync(p => p.ID == id);
            return entity;
        }

        public async Task<ICollection<Project>> GetAll()
        {
            return await this._context.Projects
                                    .Include(p => p.Images)
                                    .ToListAsync();
        }

        public IQueryable<Project> GetAllQueryable()
        {
            return this._context.Projects;
        }

        public Project Update(Project entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.CreatedDate = DateTime.Today;
            this._context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public async Task Save()
        {
            await this._context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._context.DisposeAsync();
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
