using DoJazdy.Core.Entities;

namespace DoJazdy.Core.Repositories;

public interface IJourneyPickUpPointRepository
{
	Task<JourneyPickUpPoint> GetAsync(Guid id);
	Task<IEnumerable<JourneyPickUpPoint>> GetAllAsync();
	Task AddAsync(JourneyPickUpPoint pickUpPoint);
	Task DeleteAsync(JourneyPickUpPoint pickUpPoint);
}