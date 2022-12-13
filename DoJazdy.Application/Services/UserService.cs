using DoJazdy.Core.Entities;
using DoJazdy.Core.Repositories;

namespace DoJazdy.Application.Services;

public class UserService : IUserService
{
	private readonly IUserRepository _userRepository;

	public UserService(IUserRepository userRepository)
	{
		_userRepository = userRepository;
	}

	public async Task<Guid> LoginUser(UserLoginDTO userLoginDto)
	{
		var users = await _userRepository.GetAllAsync();
		return users.Where(x => x.Password == userLoginDto.Password).Select(x => x.Id).FirstOrDefault();
	}

	public async Task<bool> RegisterUser(User user)
	{
		var users = await _userRepository.GetAllAsync();
		if (users.FirstOrDefault(x => x.Login == user.Login) is not null)
		{
			user.Id = Guid.NewGuid();
			await _userRepository.AddAsync(user);
			return true;
		}

		return false;
	}

	public Task AddEcoAchievementForUser(Guid userId, EcoAchievement ecoAchievement)
	{
		throw new NotImplementedException();
	}

	public Task JoinJourney(Guid userId, Guid journeyId)
	{
		throw new NotImplementedException();
	}

	public Task AddCar(Guid userId, Car car)
	{
		throw new NotImplementedException();
	}
}