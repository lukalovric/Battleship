public class GamePlayerDto
{
    public Guid UserId { get; set; }
    public string Username { get; set; }
    public List<ShipDto> Ships { get; set; }
}