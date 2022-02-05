using MyWebSite.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Data.Models
{
    public class ContactData : IEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.DateTime)]
        public string UploadDate { get; set; }
        public bool IsActive { get; set; }
    }
}
