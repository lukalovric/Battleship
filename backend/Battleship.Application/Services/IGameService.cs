public interface IGameService
{
    Task<GameDto> CreateGameAsync(Guid userId, CreateGameDto dto);
    Task JoinGameAsync(Guid userId, Guid gameId);
    Task SendMoveAsync(Guid userId, MoveDto dto);
    Task PlaceShipsAsync(Guid userId, PlaceShipsDto dto);
    Task SurrenderAsync(Guid userId, Guid gameId);
    Task<GameStatusDto> GetGameStatusAsync(Guid gameId);
}
