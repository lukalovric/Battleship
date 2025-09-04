using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PlayerController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetPlayer(Guid id) => Ok();

    [Authorize]
    [HttpPut("profile")]
    public IActionResult UpdateProfile([FromBody] UpdateProfileDto dto) => Ok();

    [Authorize(Roles = "Admin")]
    [HttpGet("all")]
    public IActionResult GetAllPlayers() => Ok();

    [Authorize(Roles = "Admin")]
    [HttpDelete("{id}")]
    public IActionResult DeleteOrBlockPlayer(Guid id) => Ok();
}
