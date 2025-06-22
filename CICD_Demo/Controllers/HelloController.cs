using Microsoft.AspNetCore.Mvc;

namespace hello_devops_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] string name = "World")
    {
        return Ok(new { message = $"Hello, {name}!" });
    }
}