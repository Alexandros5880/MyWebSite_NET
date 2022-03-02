using Microsoft.AspNetCore.Http;
using MyWebSite.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebSite.Data.Models
{
    public class CV : IEntity
    {
        public int ID  { get; set; }
        public bool IsActive { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
        public string CVPath { get; set; }
        public string CVFullPath { get; set; }
        public string Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastUpdateDate { get; set; }
        public CV()
        {
            this.CreatedDate = DateTime.Now;
            this.LastUpdateDate = DateTime.Now;
        }
    }
}
