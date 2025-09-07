public class StatisticsRepository : IStatisticsRepository
{
    private readonly AppDbContext _context;
    public StatisticsRepository(AppDbContext context) { _context = context; }

    public async Task<GlobalStatsDto> GetGlobalStatsAsync()
    {
        // Aggregate statistics example
        int totalGames = await _context.Games.CountAsync();
        int totalPlayers = await _context.Users.CountAsync();
        double avgDuration = 0; // Calculate from Moves
        return new GlobalStatsDto { TotalGames = totalGames, TotalPlayers = totalPlayers, AverageGameDuration = avgDuration };
    }

    public async Task<IEnumerable<LeaderboardEntryDto>> GetLeaderboardAsync()
    {
        // Query top players; fill LeaderboardEntryDto
        // Example: Most wins
        // return await ... 
        return new List<LeaderboardEntryDto>();
    }

    public async Task<PlayerStatistics> GetPlayerStatsAsync(Guid userId)
        => await _context.PlayerStatistics.FirstOrDefaultAsync(s => s.UserId == userId);
}
