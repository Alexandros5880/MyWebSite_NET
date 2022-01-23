using MyWebSite.Data.Interfaces;

namespace MyWebSite.Data.Models
{
    public class Image : IEntity
    {
        public int ID { get; set; }
        public string Path { get; set; }
    }
}
