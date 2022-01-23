using MyWebSite.Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebSite.Data.Models
{
    public class Image : IEntity
    {
        public int ID { get; set; }
        public string Path { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        [Required]
        public Project Project { get; set; }
    }
}
