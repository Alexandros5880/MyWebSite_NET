using MyWebSite.Data.Models;
using System.Collections.Generic;

namespace MyWebSite.Data.ViewModels
{
    public class ProjectViewModel
    {
        public int ID { get; set; }
        public ICollection<Image> Images { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DownloadLink { get; set; }
        public decimal Price { get; set; }
    }
}
