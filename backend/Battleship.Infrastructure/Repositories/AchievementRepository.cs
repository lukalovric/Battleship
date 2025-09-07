public class AchievementRepository : IAchievementRepository
{
    private readonly AppDbContext _context;
    public AchievementRepository(AppDbContext context) { _context = context; }

    public async Task<IEnumerable<Achievement>> GetAchievementsByUserAsync(Guid userId)
        => await _context.Achievements.Where(a => a.UserId == userId).ToListAsync();

    public async Task AddAchievementAsync(Achievement achievement)
        => await _context.Achievements.AddAsync(achievement);
}
