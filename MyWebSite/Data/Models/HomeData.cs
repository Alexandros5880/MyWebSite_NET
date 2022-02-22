using Microsoft.AspNetCore.Http;
using MyWebSite.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebSite.Data.Models
{
    public class HomeData : IEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        [DataType(DataType.MultilineText)]
        public string Paragraph { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
        public string ImagePath { get; set; }
        public string ImageFullPath { get; set; }
        public bool IsActive { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateDate { get; set; }
        public HomeData()
        {
            this.CreatedDate = DateTime.Now;
            this.LastUpdateDate = DateTime.Now;
        }
    }
}
