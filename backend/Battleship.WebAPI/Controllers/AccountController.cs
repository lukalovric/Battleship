using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register([FromBody] RegisterDto dto) => Ok();

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginDto dto) => Ok();

    [Authorize]
    [HttpPost("logout")]
    public IActionResult Logout() => Ok();

    [Authorize]
    [HttpPost("change-password")]
    public IActionResult ChangePassword([FromBody] ChangePasswordDto dto) => Ok();

    [Authorize]
    [HttpGet("profile")]
    public IActionResult GetProfile() => Ok();
}
