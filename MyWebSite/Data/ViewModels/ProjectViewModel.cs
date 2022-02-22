using MyWebSite.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebSite.Data.ViewModels
{
    public class ProjectViewModel
    {
        public int ID { get; set; }
        public ICollection<Image> Images { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DownloadLink { get; set; }
        public decimal Price { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateDate { get; set; }
    }
}
