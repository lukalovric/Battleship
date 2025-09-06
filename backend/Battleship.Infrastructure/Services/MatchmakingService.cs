public class MatchmakingService : IMatchmakingService
{
    public Task<IEnumerable<GameOverviewDto>> GetAvailableGamesAsync() => Task.FromResult(Enumerable.Empty<GameOverviewDto>());
    public Task<GameDto> AutoJoinAsync(Guid userId) => Task.FromResult(new GameDto());
    public Task<IEnumerable<GameOverviewDto>> GetUserMatchesAsync(Guid userId) => Task.FromResult(Enumerable.Empty<GameOverviewDto>());
}
