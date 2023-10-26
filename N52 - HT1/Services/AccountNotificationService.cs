namespace N52___HT1.Services;

using N52___HT1.Models;
using N52___HT1.Services.Interfaces;

public class AccountNotificationService : IAccountNotificationService
{
    private readonly AccountEventStore _eventStore;
    private readonly IEmailSenderservice _emailSenderservice;
    public AccountNotificationService(AccountEventStore accountEventStore, IEmailSenderservice emailSenderService)
    {
        _eventStore = accountEventStore;
        _emailSenderservice = emailSenderService;

        _eventStore.OnUserCreated += HandleUserCreatedEventAsync;
    }

    public async ValueTask HandleUserCreatedEventAsync(User user)
    {
        Console.WriteLine($"Notifying users whose account created  - {user.FirstName} {user.LastName}");
        await _emailSenderservice.SendAsync(user);
    }
}