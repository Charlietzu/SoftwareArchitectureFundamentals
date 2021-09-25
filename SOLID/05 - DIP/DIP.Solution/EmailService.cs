using System.Net.Mail;
using SOLID.DIP.Solution.Interfaces;

namespace SOLID.DIP.Solution
{
    public class EmailService : IEmailService
    {
        public void Send(string from, string to, string subject, string message)
        {
            MailMessage mail = new MailMessage(from, to);
            SmtpClient client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = subject;
            mail.Body = message;
            client.Send(mail);
        }
    }
}