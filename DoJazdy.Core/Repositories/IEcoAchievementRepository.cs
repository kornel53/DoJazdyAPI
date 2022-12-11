using DoJazdy.Core.Entities;

namespace DoJazdy.Core.Repositories;

public interface IEcoAchievementRepository
{
	Task<EcoAchievement> GetAsync(Guid id);
	Task<IEnumerable<EcoAchievement>> GetAllAsync();
	Task AddAsync(EcoAchievement ecoAchievement);
	Task DeleteAsync(EcoAchievement ecoAchievement);
}