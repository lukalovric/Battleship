public class AdminService : IAdminService
{
    public Task<IEnumerable<UserAdminDto>> GetAllUsersAsync() => Task.FromResult(Enumerable.Empty<UserAdminDto>());
    public Task ChangeUserRoleAsync(Guid userId, string newRole) => Task.CompletedTask;
    public Task DeleteGameAsync(Guid gameId) => Task.CompletedTask;
    public Task<IEnumerable<LogEntryDto>> GetLogsAsync() => Task.FromResult(Enumerable.Empty<LogEntryDto>());
    public Task CreateAdminAsync(CreateAdminDto dto) => Task.CompletedTask;
}
