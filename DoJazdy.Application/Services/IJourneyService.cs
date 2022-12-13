using DoJazdy.Core.Entities;

namespace DoJazdy.Application.Services;

public interface IJourneyService
{
	Task CreateJourney(Guid userId, Journey journey);
	Task AddPickUpPoint(Guid journeyId, JourneyPickUpPoint journeyPickUpPoint);
	Task AddAdditionalData(Guid journeyId, JourneyAdditionalData journeyAdditionalData);
	Task DeleteJourney(Guid journeyId);
}