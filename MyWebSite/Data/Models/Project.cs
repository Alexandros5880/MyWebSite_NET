using MyWebSite.Data.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Data.Models
{
    public class Project : IEntity
    {
        public int ID { get; set; }
        public ICollection<Image> Images { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string DownloadLink { get; set; }
        public decimal Price { get; set; }
    }
}
