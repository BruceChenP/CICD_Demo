using Microsoft.AspNetCore.Mvc;

namespace hello_devops_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]

    // 20205/07/27 Bruce 修改參數
    // 20205/07/27-2 Bruce 修改參數名稱
    public IActionResult Get([FromQuery] string content)
    {
        return Ok(new { message = $"Hey Bruce, {content}!" });
    }
}