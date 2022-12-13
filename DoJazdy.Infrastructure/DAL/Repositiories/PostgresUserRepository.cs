using DoJazdy.Core.Entities;
using DoJazdy.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DoJazdy.Infrastructure.DAL.Repositiories;

public class PostgresUserRepository : IUserRepository
{
	private readonly DoJazdyDbContext _dbContext;

	public PostgresUserRepository(DoJazdyDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public Task<User> GetAsync(Guid id)
		=> _dbContext.User.SingleOrDefaultAsync(x => x.Id == id);

	public async Task<IEnumerable<User>> GetAllAsync()
		=> await _dbContext.User.ToListAsync();

	public async Task AddAsync(User user)
	{
		await _dbContext.User.AddAsync(user);
		await _dbContext.SaveChangesAsync();
	}

	public async Task DeleteAsync(User user)
	{
		_dbContext.User.Remove(user);
		await _dbContext.SaveChangesAsync();
	}
}