public class GameRepository : IGameRepository
{
    private readonly AppDbContext _context;
    public GameRepository(AppDbContext context) { _context = context; }

    public async Task<Game> GetByIdAsync(Guid id)
        => await _context.Games.FindAsync(id);

    public async Task<IEnumerable<Game>> GetActiveGamesAsync()
        => await _context.Games.Where(g => g.Status == "Active").ToListAsync();

    public async Task<IEnumerable<Game>> GetGamesByUserAsync(Guid userId)
        => await _context.Games.Where(g => g.Players.Any(p => p.UserId == userId)).ToListAsync();

    public async Task AddAsync(Game game)
        => await _context.Games.AddAsync(game);

    public void Update(Game game)
        => _context.Games.Update(game);

    public async Task SaveChangesAsync()
        => await _context.SaveChangesAsync();
}
