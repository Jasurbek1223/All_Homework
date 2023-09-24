using N41___HT2.Service.Interfaces;
using System.Net;
using System.Net.Mail;

namespace N41___HT2.Service
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly SmtpClient _smtp;
        private readonly object _lock = new object();

        public EmailSenderService()
        {
            _smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie"),
                EnableSsl = true
            };
        }

        public async Task<bool> SendEmailAsync(string email)
        {
            var result = false;
            lock (_lock)
            {
                try
                {
                    var mail = new MailMessage("sultonbek.rakhimov.recovery@gmail.com", email);
                    mail.Subject = "Welcome";
                    mail.Body = "Heeeeellllllllllllloooooooooooo";
                    _smtp.Send(mail);
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to send email to {email}: {ex.Message}");
                    result = false;
                }
            }

            Console.WriteLine($"{email} ga email jo'natildi");
            return result;
        }
    }
}
