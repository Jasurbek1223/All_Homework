using N24___HT1.Interface;
using N24___HT1.Model;
using System.Text.RegularExpressions;

namespace N24___HT1.Service;

internal class UserCredentialsService : IUserCredentialsService
{
    private List<UserCredentials> credentials;

    public UserCredentialsService(List<UserCredentials> credentials)
    {
        this.credentials = credentials;
    }

    public UserCredentials Add(int userId, string password)
    {
        if(!IsStrongPassword(password))
        {
            throw new ArgumentException("Password is not strong");
        }

        var newUserCredentials = new UserCredentials
        {
            Id = credentials.Count() + 1,
            Password = password,
            UserId = userId
        };
        credentials.Add(newUserCredentials);
        return newUserCredentials;
    }

    public UserCredentials GetByUserId(int userId)
    {
        return credentials.FirstOrDefault(x => x.UserId == userId);
    }


    private bool IsStrongPassword(string password)
    {
        var strongPasswordRegex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,}$");
        return strongPasswordRegex.IsMatch(password);
    }




}
