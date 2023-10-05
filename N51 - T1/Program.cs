using Microsoft.Extensions.DependencyInjection;
using N51___T1.Models;
using N51___T1.Services;
using N51___T1.Services.Interfaces;

var services = new ServiceCollection();

// Register services
services
    .AddSingleton<IAccountService, AccountService>()
    .AddSingleton<IUserService, UserService>()
    .AddSingleton<IEmailSenderService, EmailSenderService>();

// Build service provider
var provider = services.BuildServiceProvider();

// Requesting service
var accountService = provider.GetRequiredService<IAccountService>();

var result = await accountService.RegisterAsync(new RegisterDetails
{
    EamilAddress = "sultonbek.rakhimov@gmail.com",
    Password = "Testtest_1"
});

Console.WriteLine(result);