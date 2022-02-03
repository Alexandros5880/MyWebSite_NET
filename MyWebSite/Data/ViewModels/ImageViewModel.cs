

using MyWebSite.Data.Models;

namespace MyWebSite.Data.ViewModels
{
    public class ImageViewModel
    {
        public int ID { get; set; }
        public string ImagePath { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
