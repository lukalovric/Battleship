public class GameDto
{
    public Guid Id { get; set; }
    public string Status { get; set; }
    public int BoardSize { get; set; }
    public List<GamePlayerDto> Players { get; set; }
}
