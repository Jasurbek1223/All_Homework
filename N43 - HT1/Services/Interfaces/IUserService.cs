using N43___HT1.Models;

namespace N43___HT1.Services.Interfaces;

public interface IUserService
{
    User Create(User user);
    User Update(User user);
    bool Delete(Guid id);
    User Get(Guid id);
    List<User> GetAll();
}
