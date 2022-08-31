using FluentEmail.Core;
using FluentEmail.Smtp;
using MyWebSite.HorizontalClasses.Interfaces;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MyWebSite.HorizontalClasses
{
    public class EmailTool : IEmailTool
    {

        public async Task Send(
            string body,
            string subject = "My WebSite Client",
            string title = "My WebSite Client",
            string from = "alexandrosplatanios15@gmail.com", 
            string password = "Takara719791", 
            string to = "alexandrosplatanios28@gmail.com")
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = false;
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(from, password);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;

            Email.DefaultSender = new SmtpSender(smtp);
            var email = Email
                        .From(from, title)
                        .To(to)
                        .Subject(subject)
                        .Body(body);
            await email.SendAsync();
        }

    }
}
