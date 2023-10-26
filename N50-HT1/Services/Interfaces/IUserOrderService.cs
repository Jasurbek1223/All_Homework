using N50_HT1.Models.Entities;

namespace N50_HT1.Services.Interfaces;

public interface IUserOrderService
{
    KeyValuePair<User, List<Order>> GetUserOrdersByUserId(Guid userId);
}
