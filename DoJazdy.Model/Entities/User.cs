namespace DoJazdy.Model.Entities;

public class User
{
    public int UserID { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public bool VerifiedEmail { get; set; }
    
}