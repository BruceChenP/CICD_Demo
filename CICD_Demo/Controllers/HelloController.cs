using Microsoft.AspNetCore.Mvc;

namespace hello_devops_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]

    // 20205/07/27 Bruce 修改參數
    public IActionResult Get([FromQuery] string context)
    {
        return Ok(new { message = $"Hey Bruce, {context}!" });
    }
}