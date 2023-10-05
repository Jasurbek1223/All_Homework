namespace WebApplication2.DataAccess;

using FileBaseContext.Abstractions.Models.FileSet;
using WebApplication2.Models;

public interface IDataContext
{
    IFileSet<User, Guid> Users { get; }
    IFileSet<Order, Guid> Orders { get; }
    ValueTask SaveChangesAsync();
}