using MyWebSite.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastUpdateDate { get; set; }
        public Order()
        {
            this.CreatedDate = DateTime.Now;
            this.LastUpdateDate = DateTime.Now;
        }
    }
}
