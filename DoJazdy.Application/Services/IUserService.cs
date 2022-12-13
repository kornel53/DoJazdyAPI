

using DoJazdy.Core.Entities;

namespace DoJazdy.Application.Services;

public interface IUserService
{
	Task<Guid> LoginUser(UserLoginDTO userLoginDto);
	Task<bool> RegisterUser(User user);
	Task AddEcoAchievementForUser(Guid userId, EcoAchievement ecoAchievement);

	Task JoinJourney(Guid userId, Guid journeyId);
	Task AddCar(Guid userId, Car car);
}