using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using MyWebSite.Data.DataTypes;
using System;
using System.IO;

namespace MyWebSite.HorizontalClasses
{
    public class FilesTools
    {
        [Obsolete]
        private IHostingEnvironment _environment;

        [Obsolete]
        public FilesTools(IHostingEnvironment environment)
        {
            this._environment = environment;
        }

        [Obsolete]
        public Paths CreateFile(IFormFile file, string subPath, string filename = null)
        {
            string wwwPath = this._environment.WebRootPath;
            string path = Path.Combine(this._environment.WebRootPath, subPath);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var fileName = filename == null? file.FileName : "homeImage" + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(path, fileName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            var paths = new Paths {
                Absolute = filePath,
                Path = Path.Combine("\\" + subPath, fileName)
            };
            return paths;
        }

        [Obsolete]
        public bool DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            return File.Exists(path);
        }
    }
}
