public class StatisticsService : IStatisticsService
{
    public Task<GlobalStatsDto> GetGlobalStatsAsync() => Task.FromResult(new GlobalStatsDto());
    public Task<IEnumerable<LeaderboardEntryDto>> GetLeaderboardAsync() => Task.FromResult(Enumerable.Empty<LeaderboardEntryDto>());
    public Task<PlayerStatisticsDto> GetPlayerStatsAsync(Guid userId) => Task.FromResult(new PlayerStatisticsDto());
    public Task<PlayerStatisticsDto> GetMyStatsAsync(Guid userId) => Task.FromResult(new PlayerStatisticsDto());
}
