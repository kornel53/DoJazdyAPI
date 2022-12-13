namespace DoJazdy.Core.Entities;

public class JourneyPickUpPoint
{
	public Guid Id { get; set; }
	public PickUpPoint StartPoint { get; set; }
	public PickUpPoint EndPoint { get; set; }
	public Guid UserId { get; set; }
	public User User { get; set; }
}