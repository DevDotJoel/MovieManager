using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieManager.Application.Common.Interfaces.Persistence;
using MovieManager.Infrastructure.Persistence;
using MovieManager.Infrastructure.Persistence.Repositories;
namespace MovieManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<MovieManagerDbContext>(options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
            services.AddScoped<IMovieRepository, MovieRepository>();
            return services;
        }
    }
}