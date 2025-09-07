public interface IAdminRepository
{
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task ChangeUserRoleAsync(Guid userId, string role);
    Task DeleteGameAsync(Guid gameId);
    Task<IEnumerable<LogEntryDto>> GetLogsAsync();
    Task AddAdminAsync(User user);
}
