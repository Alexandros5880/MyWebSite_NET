using MyWebSite.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebSite.Data.Models
{
    public class ContactData : IEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        [DataType(DataType.Html)]
        public string AddressMap { get; set; }
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool IsActive { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateDate { get; set; }
        public ContactData()
        {
            this.CreatedDate = DateTime.Today;
        }
    }
}
