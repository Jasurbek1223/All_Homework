using N63___HT1.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace N63___HT1.Services.Interfaces;

public interface ITokenGenerateService
{
    string GetToken(User user);

    JwtSecurityToken GetJwtToken(User user);

    List<Claim> GetClaims(User user);
}
