namespace WebApplication2.Services.Interface;

using System.Linq.Expressions;
using WebApplication2.Models;

public interface IOrderService
{
    IQueryable<Order> Get(Expression<Func<Order, bool>> predicate);

    ValueTask<ICollection<Order>> GetAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default);

    ValueTask<Order?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    ValueTask<Order> CreateAsync(Order user, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<Order> UpdateAsync(Order user, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<Order> DeleteAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default);
}
















