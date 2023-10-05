using N51___T1.Models;
using N51___T1.Services.Interfaces;

namespace N51___T1.Services;

public class AccountService : IAccountService
{
    private readonly IUserService _userService;
    private readonly IEmailSenderService _emailSenderService;

    public AccountService(IEmailSenderService emailSenderService, IUserService userService)
    {
        _userService = userService;
        _emailSenderService = emailSenderService;
    }
    public async ValueTask<bool> RegisterAsync(RegisterDetails registerDetails)
    {
        var user = new User
        {
            EmailAddress = registerDetails.EamilAddress,
            Password = registerDetails.Password
        };
        var createdUser = await _userService.CreateAsync(user);
        var result = await _emailSenderService.SendEmailAsync(createdUser.EmailAddress, "", "");

        return result;
    }
}
