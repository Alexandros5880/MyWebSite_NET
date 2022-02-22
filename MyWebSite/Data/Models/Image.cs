using MyWebSite.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebSite.Data.Models
{
    public class Image : IEntity
    {
        public int ID { get; set; }
        [Required]
        public string ImagePath { get; set; }
        public string ImageFullPath { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        [Required]
        public Project Project { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateDate { get; set; }
        public Image()
        {
            this.CreatedDate = DateTime.Now;
            this.LastUpdateDate = DateTime.Now;
        }
    }
}
