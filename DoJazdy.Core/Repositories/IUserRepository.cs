using DoJazdy.Core.Entities;

namespace DoJazdy.Core.Repositories;

public interface IUserRepository
{
	Task<User> GetAsync(Guid id);
	Task<IEnumerable<User>> GetAllAsync();
	Task AddAsync(User user);
	Task DeleteAsync(User user);
}