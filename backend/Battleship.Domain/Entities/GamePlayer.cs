﻿public class GamePlayer
{
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid GameId { get; set; }
    public Game Game { get; set; }
    public int BoardSize { get; set; }
    public ICollection<Ship> Ships { get; set; }
}