using DemoTokenExample.Constants;
using DemoTokenExample.Models.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


public class TokenGeneratorService
{
    private readonly IConfiguration _configuration;

    public TokenGeneratorService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GetToken(User user)
    {
        var jwtSecurityToken = GetJwtSecurityToken(user);
        var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        return token;
    }

    private JwtSecurityToken GetJwtSecurityToken(User user)
    {
        var claims = GetClaims(user);

        var key = Encoding.UTF8.GetBytes(_configuration.GetSection("Jwt:Key").Value!);

        var secretKey = new SymmetricSecurityKey(key);

        var credentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        return new JwtSecurityToken(
            issuer: "MyServer.App",
            audience: "MyClientApp",
            claims: claims,
            signingCredentials: credentials,
            notBefore: DateTime.UtcNow,
            expires: DateTime.UtcNow.AddDays(1));
    }


    private List<Claim> GetClaims(User user)
    {
        return new List<Claim>
        {
            new(ClaimTypes.Email, user.EmailAddress),
            new (ClaimConstants.UserId, user.Id.ToString())
        };
    }
}