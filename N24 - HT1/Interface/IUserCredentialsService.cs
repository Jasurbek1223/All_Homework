using N24___HT1.Model;

namespace N24___HT1.Interface;

interface IUserCredentialsService
{
    UserCredentials Add(int userId, string password);
    UserCredentials GetByUserId(int userId);

}
