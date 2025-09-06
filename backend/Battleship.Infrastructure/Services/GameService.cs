public class GameService : IGameService
{
    public Task<GameDto> CreateGameAsync(Guid userId, CreateGameDto dto) => Task.FromResult(new GameDto());
    public Task JoinGameAsync(Guid userId, Guid gameId) => Task.CompletedTask;
    public Task SendMoveAsync(Guid userId, MoveDto dto) => Task.CompletedTask;
    public Task PlaceShipsAsync(Guid userId, PlaceShipsDto dto) => Task.CompletedTask;
    public Task SurrenderAsync(Guid userId, Guid gameId) => Task.CompletedTask;
    public Task<GameStatusDto> GetGameStatusAsync(Guid gameId) => Task.FromResult(new GameStatusDto());
}
