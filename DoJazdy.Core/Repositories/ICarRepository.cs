using DoJazdy.Core.Entities;

namespace DoJazdy.Core.Repositories;

public interface ICarRepository
{
	Task<Car> GetAsync(Guid id);
	Task<IEnumerable<Car>> GetAllAsync();
	Task AddAsync(Car car);
	Task DeleteAsync(Car car);
}