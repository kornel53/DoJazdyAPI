namespace DoJazdy.Core.Entities;

public class UserPersonalData
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Surname { get; set; }
	
	public int UserId { get; set; }
	public User User { get; set; }

	public UserPersonalData(int id, string name, string surname)
	{
		Id = id;
		Name = name;
		Surname = surname;
	}
}