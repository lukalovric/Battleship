public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; } // For storage
    public string Role { get; set; } // "Player", "Admin"
    public bool IsBlocked { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<GamePlayer> GamePlayers { get; set; }
    public ICollection<Achievement> Achievements { get; set; }
}
