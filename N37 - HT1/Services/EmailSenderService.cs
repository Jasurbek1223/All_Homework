using N37___HT1.Models;
using System.Net.Mail;
using System.Net;
using N37___HT1.Interfaces;

namespace N37___HT1.Services;

public class EmailSenderService : IEmailSenderService
{
    public async Task SendEmailsAsync(IEnumerable<EmailMessage> messages)
    {
        var smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
        smtp.EnableSsl = true;

        foreach (var message in messages)
        {
            var mail = new MailMessage(message.SenderAddress, message.ReceiverAddress);
            mail.Subject = message.Subject;
            mail.Body = message.Body;

            await smtp.SendMailAsync(mail);
        }
    }
}
