using N52___HT1.Models;
using N52___HT1.Services;
using N52___HT1.Services.Interfaces;
using N52_HT1.Services;

var builder = new ServiceCollection();

builder
    .AddSingleton<IUserService, UserService>()
    .AddSingleton<IEmailSenderservice, EmailSenderService>()
    .AddSingleton<IAccountNotificationService, AccountNotificationService>()
    .AddSingleton<AccountEventStore>();

var services = builder.BuildServiceProvider();

var userService = services.GetService<IUserService>() ?? throw new InvalidOperationException();
var accountNotificationService = services.GetRequiredService<IAccountNotificationService>();

var user = new User("Johan", "Liebert", "jasurabdulxaev@gmail.com", "J@sur1223");

var addedUser = await userService.Create(user);
Console.WriteLine($"{addedUser.FirstName} {addedUser.LastName}");