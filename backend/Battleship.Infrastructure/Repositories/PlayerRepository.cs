public class PlayerRepository : IPlayerRepository
{
    private readonly AppDbContext _context;
    public PlayerRepository(AppDbContext ctx) { _context = ctx; }

    public async Task<PlayerStatistics> GetStatisticsAsync(Guid userId)
        => await _context.PlayerStatistics.FirstOrDefaultAsync(s => s.UserId == userId);
}
