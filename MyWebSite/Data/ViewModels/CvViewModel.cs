using Microsoft.AspNetCore.Http;

namespace MyWebSite.Data.ViewModels
{
    public class CvViewModel
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public IFormFile File { get; set; }
        public string CVPath { get; set; }
        public string CVFullPath { get; set; }
        public string Description { get; set; }
    }
}
