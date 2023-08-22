using N28_Project.Model;

namespace N28_Project.Service;

public interface IUserService
{
    void Add(User user);
    UserService Get(int id);
    List<User> GetAll();
    void Update(User user);
    void Delete(int id);


}
