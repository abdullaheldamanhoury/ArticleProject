using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace ArticleProject.Code
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("abd4936@gmail", "domgxmoqpuoieowe"),
                EnableSsl = true,

            };
           return smtpClient.SendMailAsync("abd4936@gmail", email, subject, htmlMessage);
        }
    }
}
