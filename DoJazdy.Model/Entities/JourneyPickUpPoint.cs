namespace DoJazdy.Model.Entities;

public class JourneyPickUpPoint
{
	public int Id { get; set; }
	public PickUpPoint StartPoint { get; set; }
	public PickUpPoint EndPoint { get; set; }
	public int UserId { get; set; }
	public User User { get; set; }
}