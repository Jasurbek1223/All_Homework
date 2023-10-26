using FileBaseContext.Abstractions.Models.Entity;

namespace DemoWebUser.Models;

public class User : IFileSetEntity<Guid>
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string UserName { get; set; }

    public DateTime DateOfBirth { get; set; }
}