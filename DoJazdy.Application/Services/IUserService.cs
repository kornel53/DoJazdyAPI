namespace DoJazdy.Application.Services;

public interface IUserService
{
	Task<bool> LoginUser(UserLoginDataDTO dto);
	Task RegisterUser(UserDTO dto);
	Task AddEcoAchievementForUser(UserDTO userDto, EcoAchievementDTO ecoAchievementDto);
	Task JoinJourney(UserDTO userDto, JourneyDTO journeyDto);
	Task AddCar(UserDTO userDto, CarDTO carDto);
}