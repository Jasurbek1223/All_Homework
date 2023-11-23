using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using N63___HT1.Constants;
using N63___HT1.Models;
using N63___HT1.Services.Interfaces;
using N63___HT1.Settings;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace N63___HT1.Services;

public class TokenGeneratorService : ITokenGenerateService
{
    private readonly JwtSettings _jwtSettings;

    public TokenGeneratorService(IOptions<JwtSettings> jwtSettings)
    {
        _jwtSettings = jwtSettings.Value;
    }

    public string GetToken(User user)
    {
        var jwtToken = GetJwtToken(user);
        var token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
        return token;
    }

    public JwtSecurityToken GetJwtToken(User user)
    {
        var claims = GetClaims(user);

        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        return new JwtSecurityToken(
            issuer: _jwtSettings.ValidIssuer,
            audience: _jwtSettings.ValidAudience,
            claims: claims,
            notBefore: DateTime.UtcNow,
            expires: DateTime.Now.AddMinutes(_jwtSettings.ExpirationTimeInMinutes),
            signingCredentials: credentials);
    }

    public List<Claim> GetClaims(User user)
    {
        return new List<Claim>()
        {
            new(ClaimTypes.Email, user.Email),
            new(ClaimConstants.UserId, user.Id.ToString())
        };
    }
}
