using MyWebSite.Data.Interfaces;

namespace MyWebSite.Data.Models
{
    public class CV : IEntity
    {
        public int ID  { get; set; }
        public bool IsActive { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
    }
}
