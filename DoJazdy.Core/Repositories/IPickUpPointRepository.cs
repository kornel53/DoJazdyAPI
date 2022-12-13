using DoJazdy.Core.Entities;

namespace DoJazdy.Core.Repositories;

public interface IPickUpPointRepository
{
	Task<PickUpPoint> GetAsync(Guid id);
	Task<IEnumerable<PickUpPoint>> GetAllAsync();
	Task AddAsync(PickUpPoint pickUpPoint);
	Task DeleteAsync(PickUpPoint pickUpPoint);
}