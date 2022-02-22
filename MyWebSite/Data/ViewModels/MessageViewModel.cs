using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebSite.Data.ViewModels
{
    public class MessageViewModel
    {
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string MyMessage { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateDate { get; set; }
    }
}
