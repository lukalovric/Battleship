using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = "Admin")]
public class AdminController : ControllerBase
{
    [HttpGet("users")]
    public IActionResult GetAllUsers() => Ok();

    [HttpPut("user/{id}/role")]
    public IActionResult ChangeUserRole(Guid id, [FromBody] ChangeRoleDto dto) => Ok();

    [HttpDelete("game/{id}")]
    public IActionResult DeleteGame(Guid id) => Ok();

    [HttpGet("logs")]
    public IActionResult GetLogs() => Ok();

    [HttpPost("admin")]
    public IActionResult CreateAdmin([FromBody] CreateAdminDto dto) => Ok();
}
