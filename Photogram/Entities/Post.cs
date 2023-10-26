using FileBaseContext.Abstractions.Models.Entity;
using Photogram.Entities.Common;

namespace Photogram.Entities;

public class Post : SoftDeletedEntity
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public Guid UserId { get; set; }
}
