using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using MyWebSite.Data.DataTypes;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

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
            this.CreateDir(path);
            var fileName = filename == null? file.FileName : "homeImage" + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(path, fileName);
            this.DeleteFile(filePath);
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

        public string GetDir(string path)
        {
            return new DirectoryInfo(path).FullName;
        }

        public bool DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            return File.Exists(path);
        }

        public bool CreateFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            return File.Exists(path);
        }

        public bool DeleteDir(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
            }
            return Directory.Exists(path);
        }

        public bool CreateDir(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return Directory.Exists(path);
        }

        public static string IformFileToBase64(IFormFile imageFile)
        {
            using (var ms = new MemoryStream())
            {
                imageFile.CopyTo(ms);
                var fileBytes = ms.ToArray();
                string imageBase64 = "data:image/jpg;base64, " + Convert.ToBase64String(fileBytes);
                return (string)imageBase64.Clone();
            }
        }
    }
}
