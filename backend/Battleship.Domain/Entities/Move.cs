public class Move
{
    public Guid Id { get; set; }
    public Guid GameId { get; set; }
    public Guid PlayerId { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public DateTime Timestamp { get; set; }
    public bool Hit { get; set; }
}