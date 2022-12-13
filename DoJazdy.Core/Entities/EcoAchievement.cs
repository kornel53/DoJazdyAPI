namespace DoJazdy.Core.Entities;

public class EcoAchievement
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    public Guid UserId { get; set; }
    public User User { get; set; }
}