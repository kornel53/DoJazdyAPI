namespace DoJazdy.Core.Entities;

public class JourneyAdditionalData
{
    public int Id { get; set; }
    public double CO2 { get; set; }
    public double SOx { get; set; }
    public double CO { get; set; }
    public double NOx { get; set; }
    
    public Journey JourneyId { get; set; }
    public Journey Journey { get; set; }
}