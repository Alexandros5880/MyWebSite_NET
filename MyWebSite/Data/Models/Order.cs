using MyWebSite.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace MyWebSite.Data.Models
{
    public class Order : IEntity
    {
        public int ID { get; set; }
        public string OrderID { get; set; } // For PayPal
        public string PayerID { get; set; } // For PayPal
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
    }
}
