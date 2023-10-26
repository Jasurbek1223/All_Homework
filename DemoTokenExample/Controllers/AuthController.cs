using DemoTokenExample.Models.DTOs;
using DemoTokenExample.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace DemoTokenExample.Controllers;


[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly TokenGeneratorService _tokenGeneratorService;

    public AuthController(TokenGeneratorService tokenGeneratorService)
    {
        _tokenGeneratorService = tokenGeneratorService;
    }

    [HttpPost]
    public IActionResult Login([FromBody] LoginDetails loginDetails)
    {
        // get user with email address and password in user service
        var user = new User
        {
            Id = Guid.NewGuid(),
            EmailAddress = loginDetails.EmailAddress,
            Password = loginDetails.Password
        };

        var data = _tokenGeneratorService.GetToken(user);
        return Ok(data);
    }
}

//[ApiController]
//[Route("api/[controller]")]
//public class AuthController : ControllerBase
//{
//    private readonly TokenGeneratorService _tokenGeneratorService;

//    public AuthController(TokenGeneratorService tokenGeneratorService)
//    {
//        _tokenGeneratorService = tokenGeneratorService;
//    }

//    [HttpPost("login")]
//    public ValueTask<IActionResult> Login([FromBody] LoginDetails loginDetails)
//    {
//        var user = new User
//        {
//            Id = Guid.NewGuid(),
//            Email = loginDetails.EmailAddress,
//            Password = loginDetails.Password,
//        };

//        var token = _tokenGeneratorService.GetToken(user);

//        return new ValueTask<IActionResult>(Ok(token));
//    }
//}