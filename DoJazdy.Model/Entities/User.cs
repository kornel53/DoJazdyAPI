namespace DoJazdy.Model.Entities;

public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }


    public UserPersonalData UserPersonalData { get; set; }
    public IEnumerable<EcoAchievement> EcoAchievements { get; set; }
    public IEnumerable<Car> Cars { get; set; }
    public IEnumerable<Journey> Journeys { get; set; }
}