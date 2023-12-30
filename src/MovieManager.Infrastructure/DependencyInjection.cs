using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieManager.Infrastructure.Persistence;
namespace MovieManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
            return services;
        }
    }
}