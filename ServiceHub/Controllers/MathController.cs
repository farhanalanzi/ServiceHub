using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MathController : ControllerBase
{
    [HttpGet("add")]
    public IActionResult Add(int a, int b)
        => Ok(a + b);

    [HttpGet("subtract")]
    public IActionResult Subtract(int a, int b)
        => Ok(a - b);

    [HttpGet("multiply")]
    public IActionResult Multiply(int a, int b)
        => Ok(a * b);

    [HttpGet("divide")]
    public IActionResult Divide(int a, int b)
    {
        if (b == 0)
            return BadRequest("Cannot divide by zero");

        return Ok(a / b);
    }
}