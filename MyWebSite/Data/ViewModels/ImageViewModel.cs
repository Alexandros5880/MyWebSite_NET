using Microsoft.CodeAnalysis;

namespace MyWebSite.Data.ViewModels
{
    public class ImageViewModel
    {
        public string ImagePath { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
