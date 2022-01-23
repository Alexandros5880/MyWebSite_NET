using MyWebSite.Data.Interfaces;

namespace MyWebSite.Data.Models
{
    public class Message : IEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string MyMessage { get; set; }
    }
}
