using Microsoft.EntityFrameworkCore;
using MyWebSite.Data;
using MyWebSite.Data.DataTypes;
using MyWebSite.Data.Models;
using MyWebSite.HorizontalClasses;
using MyWebSite.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MyWebSite.Repositories
{
    public class HomeDataRepository : IRepository<HomeData>, IDisposable
    {
        private bool disposedValue;
        private readonly ApplicationDbContext _context;
        private readonly FilesTools _filesTools;

        public HomeDataRepository(IApplicationDbContext context, FilesTools filesTools)
        {
            this._context = (ApplicationDbContext)context;
            this._filesTools = filesTools;
        }

        [Obsolete]
        public async Task<HomeData> Add(HomeData entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.CreatedDate = DateTime.Now;
            entity.LastUpdateDate = DateTime.Now;

            // Convert the image data to base64
            string imageBase64 = FilesTools.IformFileToBase64(entity.File);
            entity.Base64 = imageBase64;

            // Save Image In Locals Directories
            //Paths imagePaths = this._filesTools.CreateFile(entity.File, "img\\home\\", "homeImage");
            //entity.ImageFullPath = imagePaths.Absolute;
            //entity.ImagePath = imagePaths.Path;

            await this._context.HomeData.AddAsync(entity);
            if (entity.IsActive == true)
            {
                foreach (var rec in this._context.HomeData.Where(r => r.ID != entity.ID))
                {
                    rec.IsActive = false;
                }
            }
            return entity;
        }

        [Obsolete]
        public async Task<HomeData> Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.HomeData
                                        .FirstOrDefaultAsync(e => e.ID == id);
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            // Delete File If Exists From Local Directories
            string path = "";
            this._filesTools.DeleteFile(entity.ImageFullPath);
            path = this._filesTools.GetDir(entity.ImagePath);
            if (!String.IsNullOrEmpty(path))
                this._filesTools.DeleteDir(path);

            this._context.HomeData.Remove(entity);
            return entity;
        }

        public async Task<HomeData> Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return await this._context.HomeData
                .FirstOrDefaultAsync(e => e.ID == id);
        }

        public async Task<HomeData> GetActive()
        {
            return await this._context.HomeData
                                .FirstOrDefaultAsync(h => h.IsActive == true);
        }

        public async Task<ICollection<HomeData>> GetAll()
        {
            return await this._context.HomeData
                                .ToListAsync();
        }

        public IQueryable<HomeData> GetAllQueryable()
        {
            return this._context.HomeData;
        }

        public async Task Save()
        {
            await this._context.SaveChangesAsync();
        }

        [Obsolete]
        public HomeData Update(HomeData entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.LastUpdateDate = DateTime.Now;
            if (entity.File != null)
            {
                // Convert the image data to base64
                string imageBase64 = FilesTools.IformFileToBase64(entity.File);
                entity.Base64 = imageBase64;

                // Delete File If Exists From Local Directories
                string path = "";
                this._filesTools.DeleteFile(entity.ImageFullPath);
                path = this._filesTools.GetDir(entity.ImagePath);
                if (!String.IsNullOrEmpty(path))
                    this._filesTools.DeleteDir(path);
                entity.ImageFullPath = "";
                entity.ImagePath = "";

                // Save Image In Locals Directories
                //Paths imagePaths = this._filesTools.CreateFile(entity.File, "img\\home\\", "homeImage");
                //if ((imagePaths.Absolute != null) &&
                //    (imagePaths.Path != null))
                //{
                //    entity.ImageFullPath = imagePaths.Absolute;
                //    entity.ImagePath = imagePaths.Path;
                //}
            }
            this._context.Entry(entity).State = EntityState.Modified;
            if (entity.IsActive == true)
            {
                foreach (var rec in this._context.HomeData.Where(r => r.ID != entity.ID))
                {
                    rec.IsActive = false;
                }
            }
            return entity;
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
