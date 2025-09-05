public class Ship
{
    public Guid Id { get; set; }
    public Guid GamePlayerId { get; set; }
    public int Size { get; set; }
    public bool IsSunk { get; set; }
    public ICollection<ShipPosition> Positions { get; set; }
}