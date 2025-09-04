using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class StatisticsController : ControllerBase
{
    [HttpGet("global")]
    public IActionResult GetGlobalStats() => Ok();

    [HttpGet("leaderboard")]
    public IActionResult GetLeaderboard() => Ok();

    [Authorize]
    [HttpGet("me")]
    public IActionResult GetMyStats() => Ok();

    [Authorize(Roles = "Admin")]
    [HttpGet("player/{userId}")]
    public IActionResult GetPlayerStats(Guid userId) => Ok();
}
