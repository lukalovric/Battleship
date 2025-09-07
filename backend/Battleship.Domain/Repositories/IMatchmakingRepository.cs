public interface IMatchmakingRepository
{
    Task<IEnumerable<Game>> GetOpenGamesAsync();
    Task<Game> AssignPlayerToGameAsync(Guid userId);
}
