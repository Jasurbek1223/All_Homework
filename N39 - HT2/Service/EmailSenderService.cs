using System.Net.Mail;
using System.Net;

namespace N39___HT2.Service;

public class EmailSenderService : IEmailSenderService
{
    public bool SendEmail(string emailAddress)
    {
        var result = true;
        try
        {
            var smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
            smtp.EnableSsl = true;

            var mail = new MailMessage("sultonbek.rakhimov@gmail.com", emailAddress);
            mail.Subject = "Assalomu alaykum!";
            mail.Body = "Siz muvaffaqqiyatli registratsiyadan o'tdingiz";
            smtp.Send(mail);
        }
        catch (Exception ex)
        {
            result = false;
        }
        return result;
    }
}
