namespace DoJazdy.Core.Entities;

public class Car
{
    public Guid Id { get; set; }
    public string Producer { get; set; }
    public string Model { get; set; }
    public string EngineType { get; set; }
    public double EngineCapacity { get; set; }
    public string LicencePlate { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
}