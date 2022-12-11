namespace DoJazdy.Application.Services;

public interface IJourneyService
{
	Task CreateJourney(JourneyDTO dto);
	Task AddPickUpPoint(JourneyDTO journeyDto, JourneyPickUpPointDTO journeyPickUpPointDto);
	Task AddAdditionalData(JourneyDTO journeyDto, JourneyAdditionalDataDTO journeyAdditionalDataDto);
	Task DeleteJourney(Guid id);
}