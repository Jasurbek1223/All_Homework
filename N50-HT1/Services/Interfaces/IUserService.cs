using N50_HT1.Models.Entities;

namespace N50_HT1.Services.Interfaces;

public interface IUserService
{
    User Create(User user);
    User Update(User user);
    User Get(Guid id);
    List<User> GetAll();
    void Delete(Guid id);
    void Delete(User user);
}
