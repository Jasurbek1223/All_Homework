using WebApplication1.Models.Entities;
using WebApplication1.Services;
using WebApplication1.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var users = new List<User>
{
    new User("Alice", "Johnson", "alice.j@example.com"),
    new User("Bob", "Smith", "bob.smith@mailbox.net"),
    new User("Emily", "Davis", "emily.d@example.net"),