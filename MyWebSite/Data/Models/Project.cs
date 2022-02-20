using Microsoft.AspNetCore.Http;
using MyWebSite.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebSite.Data.Models
{
    public class Project : IEntity
    {
        public int ID { get; set; }
        public ICollection<Image> Images { get; set; }
        [NotMapped]
        public IFormFile[] Files { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string DownloadLinkZip { get; set; }
        public string DownloadLinkTar { get; set; }
        public string Link { get; set; }
        public string WebPage { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(8,4)")]
        public decimal Price { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateDate { get; set; }
        public Project()
        {
            this.CreatedDate = DateTime.Today;
        }
    }
}

