using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NumberController : ControllerBase
{
    [HttpGet("is-even")]
    public IActionResult IsEven(int number)
        => Ok(number % 2 == 0);

    [HttpGet("is-odd")]
    public IActionResult IsOdd(int number)
        => Ok(number % 2 != 0);

    [HttpGet("square")]
    public IActionResult Square(int number)
        => Ok(number * number);

    [HttpGet("cube")]
    public IActionResult Cube(int number)
        => Ok(number * number * number);
}