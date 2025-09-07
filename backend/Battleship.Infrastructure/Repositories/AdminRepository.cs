public class AdminRepository : IAdminRepository
{
    private readonly AppDbContext _context;
    public AdminRepository(AppDbContext context) { _context = context; }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
        => await _context.Users.ToListAsync();

    public async Task ChangeUserRoleAsync(Guid userId, string role)
    {
        var user = await _context.Users.FindAsync(userId);
        if (user != null) user.Role = role;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteGameAsync(Guid gameId)
    {
        var game = await _context.Games.FindAsync(gameId);
        if (game != null) _context.Games.Remove(game);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<LogEntryDto>> GetLogsAsync()
    {
        // Logs usually come from a logging system, or from a DB table
        return new List<LogEntryDto>();
    }

    public async Task AddAdminAsync(User user)
    {
        user.Role = "Admin";
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }
}
