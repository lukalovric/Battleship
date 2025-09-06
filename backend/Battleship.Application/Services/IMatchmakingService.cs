public interface IMatchmakingService
{
    Task<IEnumerable<GameOverviewDto>> GetAvailableGamesAsync();
    Task<GameDto> AutoJoinAsync(Guid userId);
    Task<IEnumerable<GameOverviewDto>> GetUserMatchesAsync(Guid userId);
}
