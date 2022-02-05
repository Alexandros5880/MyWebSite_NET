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
        public bool IsActive { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateDate { get; set; }
        public HomeData()
        {
            this.CreatedDate = DateTime.Today;
        }
    }
}
