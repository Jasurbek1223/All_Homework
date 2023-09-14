using N36___HT3.Models;

namespace N36___HT3.Interface;

public interface IUserService
{
    User Create(User user);
    User GetById(Guid id);
    IEnumerable<User> GetAll();
    User Update(User user);
    bool Delete(Guid id);
}
