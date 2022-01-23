using MyWebSite.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Data.Models
{
    public class CV : IEntity
    {
        public int ID  { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public string Path { get; set; }
        public string Description { get; set; }
    }
}
