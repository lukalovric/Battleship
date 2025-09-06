public interface IAdminService
{
    Task<IEnumerable<UserAdminDto>> GetAllUsersAsync();
    Task ChangeUserRoleAsync(Guid userId, string newRole);
    Task DeleteGameAsync(Guid gameId);
    Task<IEnumerable<LogEntryDto>> GetLogsAsync();
    Task CreateAdminAsync(CreateAdminDto dto);
}
