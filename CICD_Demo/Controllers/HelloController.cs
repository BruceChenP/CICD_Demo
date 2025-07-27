using Microsoft.AspNetCore.Mvc;

namespace hello_devops_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]

    // 2025/07/27 Bruce 修改參數
    // 2025/07/27-2 Bruce 修改參數名稱
    // 2025/07/27-3 Bruce 修改回傳字串
    public IActionResult Get([FromQuery] string content)
    {
        return Ok(new { message = $"Hello World-v4, {content}" });
    }
}