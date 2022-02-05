using MyWebSite.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Data.Models
{
    public class HomeData : IEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        [DataType(DataType.MultilineText)]
        public string Paragraph { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Url)]
        public string FacebookLink { get; set; }
        [DataType(DataType.Url)]
        public string InstagramLink { get; set; }
        [DataType(DataType.Url)]
        public string LinkedLin { get; set; }
        [DataType(DataType.DateTime)]
        public string UploadDate { get; set; }
        public bool IsActive { get; set; }
    }
}
