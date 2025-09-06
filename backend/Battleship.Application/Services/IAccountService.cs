public interface IAccountService
{
    Task RegisterAsync(RegisterDto dto);
    Task<string> LoginAsync(LoginDto dto);
    Task LogoutAsync(Guid userId);
    Task ChangePasswordAsync(Guid userId, string oldPassword, string newPassword);
    Task<UserProfileDto> GetProfileAsync(Guid userId);
}
