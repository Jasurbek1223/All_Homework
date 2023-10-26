using FileBaseContext.Abstractions.Models.FileSet;
using Photogram.Entities;

namespace Photogram.DataLayer;

public interface IDataContext
{
    public IFileSet<User, Guid> Users { get; } 

    public IFileSet<Post, Guid> Posts { get; }

    ValueTask SaveChangesAsync();
}
