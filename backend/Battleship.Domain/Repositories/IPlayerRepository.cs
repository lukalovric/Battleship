public interface IPlayerRepository
{
    Task<PlayerStatistics> GetStatisticsAsync(Guid userId);
    
}
