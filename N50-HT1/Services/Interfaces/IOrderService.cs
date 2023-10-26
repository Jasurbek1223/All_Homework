using N50_HT1.Models.Entities;
using System.Linq.Expressions;

namespace N50_HT1.Services.Interfaces;

public interface IOrderService
{
    IQueryable<Order> Get(Expression<Func<Order, bool>> predicate);
    Order Create(Order order);
    Order Update(Order order);
    Order Get(Guid id);
    List<Order> GetAll();
    void Delete(Guid id);
    void Delete(Order order);
}
