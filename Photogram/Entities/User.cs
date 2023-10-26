using FileBaseContext.Abstractions.Models.Entity;
using Photogram.Entities.Common;

namespace Photogram.Entities;

public class User : SoftDeletedEntity
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string ProfileImagePath { get; set; }
}
