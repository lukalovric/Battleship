public class ShipDto
{
    public int Size { get; set; }
    public bool IsSunk { get; set; }
    public List<ShipPositionDto> Positions { get; set; }
}