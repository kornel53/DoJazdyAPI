namespace DoJazdy.Core.Entities;

public class UserPersonalData
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string Surname { get; set; }
	
	public Guid UserId { get; set; }
	public User User { get; set; }

	public UserPersonalData(Guid id, string name, string surname, User user)
	{
		Id = id;
		Name = name;
		Surname = surname;
		User = user;
		UserId = user.Id;
	}
}