public class MatchmakingRepository : IMatchmakingRepository
{
    private readonly AppDbContext _context;
    public MatchmakingRepository(AppDbContext context) { _context = context; }

    public async Task<IEnumerable<Game>> GetOpenGamesAsync()
        => await _context.Games.Where(g => g.Status == "Pending").ToListAsync();

    public async Task<Game> AssignPlayerToGameAsync(Guid userId)
    {
        var game = await _context.Games
           .FirstOrDefaultAsync(g => g.Status == "Pending" && g.Players.Count < 2);
        // Logic to add user to the game
        // Save changes
        return game;
    }
}
