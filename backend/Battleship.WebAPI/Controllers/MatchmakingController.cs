using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MatchmakingController : ControllerBase
{
    [Authorize]
    [HttpGet("available")]
    public IActionResult GetAvailableGames() => Ok();

    [Authorize]
    [HttpPost("auto-join")]
    public IActionResult AutoJoin() => Ok();

    [Authorize]
    [HttpGet("my-matches")]
    public IActionResult GetUserMatches() => Ok();
}
