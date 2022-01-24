using System.Threading.Tasks;

namespace MyWebSite.HorizontalClasses.Interfaces
{
    public interface IEmailTool
    {
        Task Send(
            string body,
            string subject = "My WebSite Client",
            string title = "My WebSite Client",
            string from = "alexandrosplatanios15@gmail.com",
            string password = "upsmaenwfcgkzurb",
            string to = "alexandrosplatanios28@gmail.com"
            );
    }
}