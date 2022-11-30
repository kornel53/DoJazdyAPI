namespace DoJazdy.Model.Entities;

public class Journey
{
    public int JourneyId { get; set; }
    public int UserId { get; set; }
    public int CarId { get; set; }
    public double Distance { get; set; }
    public int CountOfPassengers { get; set; }
    public bool IsDriver { get; set; }
}