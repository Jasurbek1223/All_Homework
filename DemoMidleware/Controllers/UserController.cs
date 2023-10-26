using Microsoft.AspNetCore.Mvc;

namespace DemoMidleware.Controllers;

[ApiController]

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
