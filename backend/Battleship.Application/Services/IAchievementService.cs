public interface IAchievementService
{
    Task<IEnumerable<AchievementDto>> GetMyAchievementsAsync(Guid userId);
    Task GrantAchievementAsync(Guid userId, GrantAchievementDto dto);
}
