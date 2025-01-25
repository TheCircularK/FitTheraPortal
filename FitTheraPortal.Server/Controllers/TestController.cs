using Microsoft.AspNetCore.Mvc;

namespace FitTheraPortal.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { message = "test" });
    }
}