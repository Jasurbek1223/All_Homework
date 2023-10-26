using DemoWebUser.Models;
using FileBaseContext.Abstractions.Models.FileSet;

namespace DemoWebUser.Data;

public interface IDataContext
{
    IFileSet<User, Guid> Users { get; }

    ValueTask SaveChangesAsync();
}