using DoJazdy.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DoJazdy.Infrastructure.DAL;

public class DoJazdyDbContext : DbContext
{
	public DbSet<User> User { get; set; }
	public DbSet<Journey> Journey { get; set; }
	public DbSet<Car> Car { get; set; }
	public DbSet<EcoAchievement> EcoAchievement { get; set; }
	public DbSet<JourneyAdditionalData> JourneyAdditionalData { get; set; }
	public DbSet<JourneyPickUpPoint> JourneyPickUpPoint { get; set; }
	public DbSet<PickUpPoint> PickUpPoint { get; set; }
	public DbSet<UserPersonalData> UserPersonalData { get; set; }

	public DoJazdyDbContext(DbContextOptions<DoJazdyDbContext> options) : base(options)
	{
		
	}
}