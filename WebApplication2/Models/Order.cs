namespace WebApplication2.Models;

using FileBaseContext.Abstractions.Models.Entity;

public class Order : IFileSetEntity<Guid>
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public Guid UserId { get; set; }
}
