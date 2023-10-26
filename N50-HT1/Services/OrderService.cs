using N50_HT1.Models.Entities;
using N50_HT1.Services.Interfaces;
using System.Linq.Expressions;

namespace N50_HT1.Services;

public class OrderService : IOrderService
{
    private List<Order> _orders;

    public OrderService(List<Order> orders)
    {
        _orders = orders;
    }

    public Order Create(Order order)
    {
        if (order == null)
            throw new ArgumentNullException("Order is null");

        _orders.Add(order);
        return order;
    }

    public void Delete(Guid id)
    {
        var existOrder = Get(id);
        _orders.Remove(existOrder);
    }

    public void Delete(Order order)
    {
        _orders.Remove(order);
    }

    public IQueryable<Order> Get(Expression<Func<Order, bool>> predicate)
    {
        return _orders.Where(predicate.Compile()).AsQueryable();
    }

    public Order Get(Guid id)
    {
        return _orders.FirstOrDefault(order => order.Id == id);
    }

    public List<Order> GetAll()
    {
        return _orders.ToList();
    }

    public Order Update(Order order)
    {
        var existOrder = Get(order.Id);
        if(existOrder != null)
            existOrder.Amount = order.Amount;

        return existOrder;
    }
}
