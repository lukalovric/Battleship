using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AchievementController : ControllerBase
{
    [Authorize]
    [HttpGet]
    public IActionResult GetMyAchievements() => Ok();

    [Authorize(Roles = "Admin")]
    [HttpPost("{userId}/grant")]
    public IActionResult GrantAchievement(Guid userId, [FromBody] GrantAchievementDto dto) => Ok();
}
