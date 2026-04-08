using Microsoft.Extensions.DependencyInjection;
using WorshipSet.Application;
using WorshipSet.Application.Features.Readings;
using WorshipSet.Application.Features.Songs;

namespace WorshipSet.Dependencies;

public static class DependencyContainer
{
    public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        services.AddScoped<ISongRepository, SongRepository>();
        services.AddScoped<IReadingRepository, ReadingRepository>();
        return services;
    }
}
