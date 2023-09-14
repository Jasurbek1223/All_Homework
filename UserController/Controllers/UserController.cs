using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBackend.Models;
using TestBackend.Services;

namespace UserAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService userService;

    public UserController(IUserService userService)
    {
        userService = userService;
    }
    [HttpPost("user")]
    public User AddUser(User user)
    {
        userService.AddUser(user);
        return user;
    }
}
