public interface IGameRepository
{
    Task<Game> GetByIdAsync(Guid id);
    Task<IEnumerable<Game>> GetActiveGamesAsync();
    Task<IEnumerable<Game>> GetGamesByUserAsync(Guid userId);
    Task AddAsync(Game game);
    void Update(Game game);
    Task SaveChangesAsync();
}
