namespace WebApplication2.Services;
using System.Linq.Expressions;
using WebApplication2.DataAccess;
using WebApplication2.Models;
using WebApplication2.Services.Interface;

public class OrderService : IOrderService
{
    private readonly IDataContext _dataContext;
    private Order user;

    public async ValueTask<Order> CreateAsync(Order order, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        await _dataContext.Orders.AddAsync(order, cancellationToken);

        if (saveChanges)
            await _dataContext.SaveChangesAsync();

        return user;
    }

    public ValueTask<Order> DeleteAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Order> Get(Expression<Func<Order, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ICollection<Order>> GetAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Order?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    ValueTask<Order> IOrderService.UpdateAsync(Order user, bool saveChanges, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}