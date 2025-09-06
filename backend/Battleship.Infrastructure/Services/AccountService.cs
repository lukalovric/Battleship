public class AccountService : IAccountService
{
    public Task RegisterAsync(RegisterDto dto) => Task.CompletedTask;
    public Task<string> LoginAsync(LoginDto dto) => Task.FromResult("jwt-token");
    public Task LogoutAsync(Guid userId) => Task.CompletedTask;
    public Task ChangePasswordAsync(Guid userId, string oldPassword, string newPassword) => Task.CompletedTask;
    public Task<UserProfileDto> GetProfileAsync(Guid userId) => Task.FromResult(new UserProfileDto());
}
