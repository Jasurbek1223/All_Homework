using N24___HT1.Model;

namespace N24___HT1.Interface;

interface IUserService
{
    List<User> Get(int pageSize, int pageToken);
    List<User> Search(string searchKeyword,int pageSize, int pageToken);
    List<User> Filter(UserFilterModel filterModel);
    User Add(string firstName, string lastName, string emailAddress);
    User Update(User user);
    User Delete(int id);

}
