public interface IStatisticsService
{
    Task<GlobalStatsDto> GetGlobalStatsAsync();
    Task<IEnumerable<LeaderboardEntryDto>> GetLeaderboardAsync();
    Task<PlayerStatisticsDto> GetPlayerStatsAsync(Guid userId);
    Task<PlayerStatisticsDto> GetMyStatsAsync(Guid userId);
}
