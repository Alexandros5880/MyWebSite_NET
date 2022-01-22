using System.Collections.Generic;

namespace MyWebSite.Data.Models
{
    public class Project
    {
        public int ID { get; set; }
        public ICollection<Image> ImagesPaths { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DownloadLink { get; set; }
        public decimal Price { get; set; }
    }
}
