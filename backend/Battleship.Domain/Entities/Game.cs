public class Game
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Status { get; set; } // "Pending", "Active", "Completed"
    public Guid CreatedByUserId { get; set; }
    public ICollection<GamePlayer> Players { get; set; }
    public ICollection<Move> Moves { get; set; }
}