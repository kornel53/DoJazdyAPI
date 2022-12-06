namespace DoJazdy.Model.Entities;

public class JourneyWaypoints
{
    public int JourneyWaypointsId { get; set; }
    public int JourneyId { get; set; }
    public string XStart { get; set; }
    public string YStart { get; set; }
    public string XEnd { get; set; }
    public string YEnd { get; set; }
}