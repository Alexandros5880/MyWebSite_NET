using MyWebSite.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebSite.Data.ViewModels
{
    public class OrderViewModel
    {
        public int ID { get; set; }
        public string OrderID { get; set; } // For PayPal
        public string PayerID { get; set; } // For PayPal
        public ICollection<Project> Projects { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateDate { get; set; }
    }
}
