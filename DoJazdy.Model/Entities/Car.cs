namespace DoJazdy.Model.Entities;

public class Car
{
    public int Id { get; set; }
    public string Producer { get; set; }
    public string Model { get; set; }
    public string EngineType { get; set; }
    public double EngineCapacity { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}