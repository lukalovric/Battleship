public class PlayerService : IPlayerService
{
    public Task<PlayerInfoDto> GetPlayerAsync(Guid userId) => Task.FromResult(new PlayerInfoDto());
    public Task UpdateProfileAsync(Guid userId, UpdateProfileDto dto) => Task.CompletedTask;
    public Task<IEnumerable<PlayerInfoDto>> GetAllPlayersAsync() => Task.FromResult(Enumerable.Empty<PlayerInfoDto>());
    public Task DeleteOrBlockPlayerAsync(Guid userId) => Task.CompletedTask;
}
