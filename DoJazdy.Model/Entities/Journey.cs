namespace DoJazdy.Model.Entities;

public class Journey
{
    public int Id { get; set; }
    public DateOnly DateOnly { get; set; }
    public TimeOnly TimeOnly { get; set; }
    public double Distance { get; set; }
    public int CountOfPassengers { get; set; }
    public int MaxPassengers { get; set; }
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }
    
    public IEnumerable<User> Users { get; set; }
    public int CarId { get; set; }
    public Car Car { get; set; }
    
    public JourneyAdditionalData JourneyAdditionalData { get; set; }
    public IEnumerable<JourneyPickUpPoint> JourneyPickUpPoints { get; set; }
}