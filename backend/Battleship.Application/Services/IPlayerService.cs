public interface IPlayerService
{
    Task<PlayerInfoDto> GetPlayerAsync(Guid userId);
    Task UpdateProfileAsync(Guid userId, UpdateProfileDto dto);
    Task<IEnumerable<PlayerInfoDto>> GetAllPlayersAsync();
    Task DeleteOrBlockPlayerAsync(Guid userId);
}
