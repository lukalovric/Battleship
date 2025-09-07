public interface IStatisticsRepository
{
    Task<GlobalStatsDto> GetGlobalStatsAsync();
    Task<IEnumerable<LeaderboardEntryDto>> GetLeaderboardAsync();
    Task<PlayerStatistics> GetPlayerStatsAsync(Guid userId);
}
