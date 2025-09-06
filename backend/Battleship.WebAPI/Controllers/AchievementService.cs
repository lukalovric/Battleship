public class AchievementService : IAchievementService
{
    public Task<IEnumerable<AchievementDto>> GetMyAchievementsAsync(Guid userId) => Task.FromResult(Enumerable.Empty<AchievementDto>());
    public Task GrantAchievementAsync(Guid userId, GrantAchievementDto dto) => Task.CompletedTask;
}
