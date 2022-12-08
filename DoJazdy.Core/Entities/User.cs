namespace DoJazdy.Core.Entities;

public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    
    public UserPersonalData UserPersonalData { get; set; }
    public HashSet<EcoAchievement> EcoAchievements { get; set; }
    public HashSet<Car> Cars { get; set; } = new();
    public HashSet<Journey> Journeys { get; set; } = new();

    public User(int id, string login, string password, string email, int userPersonalDataId, string name, string surname)
    {
        Id = id;
        Login = login;
        Password = password;
        Email = email;
        UserPersonalData = new UserPersonalData(userPersonalDataId, name, surname);
    }

    public void AddCar(Car car)
    {
        Cars.Add(car);
    }

    public void RemoveCar(int id)
    {
        Cars.RemoveWhere(x => x.Id == id);
    }

    public void AddJourney(Journey journey)
    {
        Journeys.Add(journey);
    }

    public void RemoveJourney(int id)
    {
        Journeys.RemoveWhere(x => x.Id == id);
    }

    public void AddEcoAchievement(EcoAchievement ecoAchievement)
    {
        EcoAchievements.Add(ecoAchievement);
    }
    
}