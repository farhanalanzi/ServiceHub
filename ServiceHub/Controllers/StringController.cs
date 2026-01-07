using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StringController : ControllerBase
{
    [HttpGet("uppercase")]
    public IActionResult Uppercase(string text)
        => Ok(text.ToUpper());

    [HttpGet("lowercase")]
    public IActionResult Lowercase(string text)
        => Ok(text.ToLower());

    [HttpGet("length")]
    public IActionResult Length(string text)
        => Ok(text.Length);

    [HttpGet("reverse")]
    public IActionResult Reverse(string text)
        => Ok(new string(text.Reverse().ToArray()));
}