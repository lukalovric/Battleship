public interface IAchievementRepository
{
    Task<IEnumerable<Achievement>> GetAchievementsByUserAsync(Guid userId);
    Task AddAchievementAsync(Achievement achievement);
}
