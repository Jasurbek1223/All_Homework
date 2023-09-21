namespace N41___HT2.Service.Interfaces;
public interface IEmailSenderService
{
    public Task<bool> SendEmailAsync(string email);
}