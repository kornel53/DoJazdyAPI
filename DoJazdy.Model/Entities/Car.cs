namespace DoJazdy.Model.Entities;

public class Car
{
    public int CarId { get; set; }
    public int UserId { get; set; }
    public string Producer { get; set; }
    public string Model { get; set; }
    public string EngineType { get; set; }
    public double EngineCapacity { get; set; }
    
}