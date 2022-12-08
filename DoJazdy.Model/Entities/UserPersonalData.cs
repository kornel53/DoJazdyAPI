namespace DoJazdy.Model.Entities;

public class UserPersonalData
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Surname { get; set; }
	
	public int UserId { get; set; }
	public User User { get; set; }
}