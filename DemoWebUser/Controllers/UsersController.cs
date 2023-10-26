using DemoWebUser.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebUser.Controllers;


[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{UserId:guid}")]
    public async ValueTask<IActionResult> GetByIdAsync([FromRoute] Guid userId)
    {
        try
        {
            var user = await _userService.GetByIdAsync(userId);
            return Ok(user);
        }
        catch (InvalidOperationException ex)
        {
            return NotFound($"{ex.Message}");
        }
    }


}
