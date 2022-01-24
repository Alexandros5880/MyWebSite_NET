using MyWebSite.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebSite.Data.Models
{
    public class Message : IEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName { get => this.LastName + " " + this.FirstName; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string MyMessage { get; set; }
    }
}
