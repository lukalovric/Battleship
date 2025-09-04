using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class GameController : ControllerBase
{
    [Authorize]
    [HttpPost("create")]
    public IActionResult CreateGame([FromBody] CreateGameDto dto) => Ok();

    [Authorize]
    [HttpPost("join/{gameId}")]
    public IActionResult JoinGame(Guid gameId) => Ok();

    [Authorize]
    [HttpPost("move")]
    public IActionResult SendMove([FromBody] MoveDto dto) => Ok();

    [Authorize]
    [HttpPost("place-ships")]
    public IActionResult PlaceShips([FromBody] PlaceShipsDto dto) => Ok();

    [Authorize]
    [HttpPost("surrender/{gameId}")]
    public IActionResult Surrender(Guid gameId) => Ok();

    [Authorize]
    [HttpGet("{gameId}/status")]
    public IActionResult GetGameStatus(Guid gameId) => Ok();
}
