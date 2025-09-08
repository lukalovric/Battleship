public class PlayerInfoDto
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public bool IsBlocked { get; set; }
    public PlayerStatisticsDto Statistics { get; set; }
}