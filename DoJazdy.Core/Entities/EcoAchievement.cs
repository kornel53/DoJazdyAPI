namespace DoJazdy.Core.Entities;

public class EcoAchievement
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
}