using DoJazdy.Core.Repositories;
using DoJazdy.Infrastructure.DAL.Repositiories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DoJazdy.Infrastructure.DAL;

public static class Extensions
{
	public static IServiceCollection AddPostgres(this IServiceCollection services,
		IConfiguration configuration)
	{
		var section = configuration.GetSection("postgres");
		services.Configure<PostgresOptions>(section);
		var options = new PostgresOptions();
		section.Bind(options);
		services.AddDbContext<DoJazdyDbContext>(x => x.UseNpgsql(options.ConnectionString));
		services.AddScoped<IUserRepository, PostgresUserRepository>();
        
		return services;
	}
}