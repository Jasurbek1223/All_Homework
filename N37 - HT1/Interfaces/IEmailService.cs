using N37___HT1.Models;

namespace N37___HT1.Interfaces;

public interface IEmailService
{
    IEnumerable<EmailMessage> GetMessages(IEnumerable<EmailTemplate> templates, IEnumerable<User> users);
}
