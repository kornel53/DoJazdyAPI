using DoJazdy.Core.Entities;

namespace DoJazdy.Core.Repositories;

public interface IJourneyRepository
{
	Task<Journey> GetAsync(Guid id);
	Task<IEnumerable<Journey>> GetAllAsync();
	Task AddAsync(Journey journey);
	Task DeleteAsync(Journey journey);
}