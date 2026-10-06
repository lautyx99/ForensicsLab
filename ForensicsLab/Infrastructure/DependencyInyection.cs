using Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInyection
    {
        public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddDbContext<ForensicsLabContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString(
                        "DefaultConnection"));
            });

            return services;
        }
    }
}
